using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTienLoi
{
    public partial class frm_QLNV : Form
    {
        public frm_QLNV()
        {
            InitializeComponent();
        }
        void loadDL()
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                List<DANHSACHNV_Result> ds_nv = db.DANHSACHNV().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("manv");
                dt.Columns.Add("tennv");
                dt.Columns.Add("gmail");
                dt.Columns.Add("sdt");
                dt.Columns.Add("luong");
                dt.Columns.Add("chucvu");
                dt.Columns.Add("taikhoan");
                foreach(DANHSACHNV_Result item in ds_nv)
                {
                    dt.Rows.Add(item.MANV, item.TENNV, item.GMAIL, item.SDT, item.LUONG, item.TENCV,item.MATK);
                }
                dgvDSNV.DataSource = dt;
                cbChucVu.DataSource = db.CHUCVUs.ToList();
                cbChucVu.DisplayMember = "TENCV";
                cbChucVu.ValueMember = "MACV";
            }
        }
        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            loadDL();
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNV.Text = dgvDSNV.CurrentRow.Cells["tennv"].Value.ToString();
            txtMaNV.Text = dgvDSNV.CurrentRow.Cells["manv"].Value.ToString();
            txtSDT.Text = dgvDSNV.CurrentRow.Cells["sdt"].Value.ToString();
            txtLuong.Text = dgvDSNV.CurrentRow.Cells["luong"].Value.ToString();
            txtGmail.Text = dgvDSNV.CurrentRow.Cells["gmail"].Value.ToString();
            txtTK.Text = dgvDSNV.CurrentRow.Cells["taikhoan"].Value.ToString();
            cbChucVu.Text = dgvDSNV.CurrentRow.Cells["chucvu"].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || txtLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHANVIEN nv = new NHANVIEN();
                if(String.IsNullOrEmpty(txtTK.Text) == false)
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.TENTK = txtTK.Text;
                    tk.MK = "1";
                    db.TAIKHOANs.Add(tk);
                    db.SaveChanges();
                }
                
                int matk = int.Parse(db.laymatk().FirstOrDefault().ToString());
                nv.TENNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.LUONG = decimal.Parse(txtLuong.Text);
                nv.GMAIL = txtGmail.Text;
                nv.MATK = matk;
                nv.MACV = int.Parse(cbChucVu.SelectedValue.ToString());
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                
            }
            loadDL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa chọn thông tin");
                    return;
                }
                NHANVIEN nv = db.NHANVIENs.Where(p=> p.MANV.ToString() == txtMaNV.Text).FirstOrDefault();
                nv.TENNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.LUONG = decimal.Parse(txtLuong.Text);
                nv.GMAIL = txtGmail.Text;
                
                db.SaveChanges();
            }
            loadDL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                if(txtMaNV.Text == "")
                {
                    MessageBox.Show("Chưa chọn thông tin");
                    return;
                }
                NHANVIEN nv = db.NHANVIENs.Where(p => p.MANV.ToString() == txtMaNV.Text).FirstOrDefault();
                db.NHANVIENs.Remove(nv);
                db.SaveChanges();
            }
            loadDL();
        }
        bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtLuong.Text) == false)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtLuong.Text = "";
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSDT.Text) == false)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtSDT.Text = "";
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    dt.Rows.Add(item.MANV, item.TENNV, item.GMAIL, item.SDT, item.LUONG, item.TENCV, item.TENTK);
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
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHANVIEN nv = new NHANVIEN();
                nv.TENNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.LUONG = decimal.Parse(txtLuong.Text);
                nv.GMAIL = txtGmail.Text;
                nv.MACV = int.Parse(cbChucVu.SelectedValue.ToString());
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHANVIEN nv = db.NHANVIENs.Where(p=> p.MANV.ToString() == txtMaNV.Text).FirstOrDefault();
                nv.TENNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.LUONG = decimal.Parse(txtLuong.Text);
                nv.GMAIL = txtGmail.Text;
                nv.MACV = int.Parse(cbChucVu.SelectedValue.ToString());
                db.SaveChanges();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHANVIEN nv = db.NHANVIENs.Where(p => p.MANV.ToString() == txtMaNV.Text).FirstOrDefault();
                db.NHANVIENs.Remove(nv);
                db.SaveChanges();
            }
        }
    }
}

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
    public partial class frm_QLKH : Form
    {
        public frm_QLKH()
        {
            InitializeComponent();
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvDSKH.CurrentRow.Cells["makh"].Value.ToString();
            txtTenKH.Text = dgvDSKH.CurrentRow.Cells["tenkh"].Value.ToString();
            txtSDT.Text = dgvDSKH.CurrentRow.Cells["sdt"].Value.ToString();
            txtDiemTichLuy.Text = dgvDSKH.CurrentRow.Cells["diemtichluy"].Value.ToString();
        }
         void loadDL()
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                List<KHACHHANG> ds_kh = db.KHACHHANGs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("makh");
                dt.Columns.Add("tenkh");
                dt.Columns.Add("sdt");
                dt.Columns.Add("diemtichluy");
                foreach (KHACHHANG item in ds_kh)
                {
                    dt.Rows.Add(item.MAKH, item.TENKH, item.SDT, item.DIEMTICHLUY);                               
                }
                dgvDSKH.DataSource = dt;
            }
        }
        private void frm_QLKH_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        void reset()
        {
            txtMaKH.Text = null;
            txtTenKH.Text = null;
            txtSDT.Text = null;
            txtDiemTichLuy.Text = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TENKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.DIEMTICHLUY = 0;
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
            }
            loadDL();
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                KHACHHANG kh = db.KHACHHANGs.Where(p=>p.MAKH.ToString() == txtMaKH.Text).FirstOrDefault();
                kh.TENKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.DIEMTICHLUY = int.Parse(txtDiemTichLuy.Text);
                db.SaveChanges();
            }
            loadDL();
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                KHACHHANG kh = db.KHACHHANGs.Where(p => p.MAKH.ToString() == txtMaKH.Text).FirstOrDefault();
                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();
            }
            loadDL();
        }
    }
}

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
    public partial class frm_QLNCC : Form
    {
        public frm_QLNCC()
        {
            InitializeComponent();
        }

        void loadDL()
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                List<NHACUNGCAP> ds_ncc = db.NHACUNGCAPs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("mancc");
                dt.Columns.Add("tenncc");
                dt.Columns.Add("sdt");
                dt.Columns.Add("diachi");
                dt.Columns.Add("gmail");
                foreach (NHACUNGCAP item in ds_ncc)
                {
                    dt.Rows.Add(item.MANCC, item.TENNCC, item.SDT, item.DIACHI, item.GMAIL);
                }
                dgvDSNCC.DataSource = dt;
            }
        }
        private void frm_QLNCC_Load(object sender, EventArgs e)
        {
            loadDL();
        }

     
        private void btnThem_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDT = txtSDT.Text;
                ncc.GMAIL = txtGmail.Text;
                ncc.DIACHI = txtDiaChi.Text;
                db.NHACUNGCAPs.Add(ncc);
                db.SaveChanges();
            }
            loadDL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHACUNGCAP ncc = db.NHACUNGCAPs.Where(p => p.MANCC.ToString() == txtMaNCC.Text).FirstOrDefault();
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDT = txtSDT.Text;
                ncc.GMAIL = txtGmail.Text;
                ncc.DIACHI = txtDiaChi.Text;
                db.SaveChanges();
            }
            loadDL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                NHACUNGCAP ncc = db.NHACUNGCAPs.Where(p => p.MANCC.ToString() == txtMaNCC.Text).FirstOrDefault();
                db.NHACUNGCAPs.Remove(ncc);
                db.SaveChanges();
            }
            loadDL();
        }

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNCC.Text = dgvDSNCC.CurrentRow.Cells["tenncc"].Value.ToString();
            txtGmail.Text = dgvDSNCC.CurrentRow.Cells["gmail"].Value.ToString();
            txtSDT.Text = dgvDSNCC.CurrentRow.Cells["sdt"].Value.ToString();
            txtMaNCC.Text = dgvDSNCC.CurrentRow.Cells["mancc"].Value.ToString();
            txtDiaChi.Text = dgvDSNCC.CurrentRow.Cells["diachi"].Value.ToString();
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            frm_GuiMailNCC f = new frm_GuiMailNCC();
            f.Visible = true;
        }
    }
}

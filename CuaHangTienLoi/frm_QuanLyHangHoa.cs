using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTienLoi
{
    public partial class frm_QuanLyHangHoa : Form
    {
        string imgSP ="";
        public frm_QuanLyHangHoa()
        {
            InitializeComponent();
        }

        void loadDL()
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                cbLoaiSP.DataSource = db.LOAISPs.ToList();
                cbLoaiSP.DisplayMember = "TENLOAI";
                cbLoaiSP.ValueMember = "MALOAI";
                List<DGVHANGHOA_Result> ds_hanghoa = db.DGVHANGHOA().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("mahang");
                dt.Columns.Add("tenhang");
                dt.Columns.Add("hsd");
                dt.Columns.Add("donvitinh");
                dt.Columns.Add("soluong");
                dt.Columns.Add("loaihang");
                dt.Columns.Add("hinh");
                dt.Columns.Add("giaban");
                foreach(DGVHANGHOA_Result item in ds_hanghoa)
                {
                    DateTime hsd =(DateTime) item.HSD;
                    dt.Rows.Add(item.MAHANG,item.TENHANG, hsd.ToString("yyyy-MM-dd"), item.DONVITINH, item.SOLUONG, item.TENLOAI, item.Hinh, item.GIABAN);
                }
                
                dgvHangHoa.DataSource = dt;
                
            }
        }
        private void frm_QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            loadDL();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgSP, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                HANGHOA hh = db.HANGHOAs.FirstOrDefault(p => p.MAHANG.ToString() == txtMaHang.Text);
                hh.TENHANG = txtTenhang.Text;
                hh.SOLUONG = int.Parse(txtSL.Text);
                hh.HSD = DateTime.Parse(txtHSD.Text);
                hh.Hinh = img;
                hh.MALOAI = int.Parse(cbLoaiSP.SelectedValue.ToString());
                hh.DONVITINH = txtDVT.Text;
                hh.GIABAN = decimal.Parse(txtGiaBan.Text);
                db.SaveChanges();
            }
            loadDL();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình hàng hoá";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgSP = openFileDialog.FileName.ToString();
                picSP.ImageLocation = imgSP;
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["mahang"].Value.ToString();
            txtTenhang.Text = dgvHangHoa.CurrentRow.Cells["tenhang"].Value.ToString();
            txtSL.Text = dgvHangHoa.CurrentRow.Cells["soluong"].Value.ToString();
            txtHSD.Text = dgvHangHoa.CurrentRow.Cells["hsd"].Value.ToString();
            txtGiaBan.Text = dgvHangHoa.CurrentRow.Cells["giaban"].Value.ToString();
            txtDVT.Text = dgvHangHoa.CurrentRow.Cells["donvitinh"].Value.ToString();
            cbLoaiSP.Text = dgvHangHoa.CurrentRow.Cells["loaihang"].Value.ToString();
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                DGVHANGHOA_Result s = db.DGVHANGHOA().Where(p=> p.MAHANG == int.Parse(txtMaHang.Text)).FirstOrDefault();
                if (s == null || s.Hinh == null) picSP.Image = null;
                else
                {
                    MemoryStream stream = new MemoryStream(s.Hinh.ToArray());
                    Image im = Image.FromStream(stream);
                    if (im == null) return;
                    else
                    {
                        picSP.Image = im;
                    }
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            frm_NhapHang nhaphang = new frm_NhapHang();
            nhaphang.Visible = true;
            loadDL();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                HANGHOA hh = db.HANGHOAs.FirstOrDefault(p => p.MAHANG.ToString() == txtMaHang.Text);
                db.HANGHOAs.Remove(hh);
                db.SaveChanges();
            }
            loadDL();
        }
    }
}

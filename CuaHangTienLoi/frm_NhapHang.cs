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
    public partial class frm_NhapHang : Form
    {
        string imgSP = "";
        public frm_NhapHang()
        {
            InitializeComponent();
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                cbLoaiSP.DataSource = db.LOAISPs.ToList();
                cbLoaiSP.DisplayMember = "TENLOAI";
                cbLoaiSP.ValueMember = "MALOAI";
                cbNCC.DataSource = db.NHACUNGCAPs.ToList();
                cbNCC.DisplayMember = "TENNCC";
                cbNCC.ValueMember = "MANCC";
                string macv = db.CHUCVUs.Where(p => p.TENCV == "Quản lý hàng").FirstOrDefault().MACV.ToString();
                cbNV.DataSource = db.NHANVIENs.Where(c => c.MACV.ToString() == macv).ToList();
                cbNV.DisplayMember = "TENNV";
                cbNV.ValueMember = "MANV";
            }
        }
        
        
        private void dtpHSD_ValueChanged(object sender, EventArgs e)
        {
            DateTime hsd = DateTime.Parse(dtpHSD.Text);
            txtHSD.Text = hsd.ToString("yyyy-MM-dd");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgSP, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                HANGHOA hh = new HANGHOA();
                PHIEUNHAP pn = new PHIEUNHAP();
                CTPHIEUNHAP ctpn = new CTPHIEUNHAP();
                hh.TENHANG = txtTenhang.Text;
                hh.HSD = DateTime.Parse(txtHSD.Text);
                hh.Hinh = img;
                hh.MALOAI = int.Parse(cbLoaiSP.SelectedValue.ToString());
                hh.DONVITINH = txtDVT.Text;
                hh.SOLUONG = 0;
                hh.GIABAN = 0;
                db.HANGHOAs.Add(hh);
                pn.MANCC = int.Parse(cbNCC.SelectedValue.ToString());
                pn.MANV = int.Parse(cbNV.SelectedValue.ToString());
                DateTime ngaynhap = DateTime.Now;
                pn.NGAYNHAP = DateTime.Parse(ngaynhap.ToString("yyyy-MM-dd"));
                db.PHIEUNHAPs.Add(pn);
                db.SaveChanges();
                string mapn = db.LAYMAPN().FirstOrDefault().ToString();
                string mahang = db.LAYMAHANG().FirstOrDefault().ToString();
                ctpn.MAHANG = int.Parse(mahang);
                ctpn.MAPN = int.Parse(mapn);
                ctpn.GIANHAP = decimal.Parse(txtGiaNhap.Text);
                ctpn.SLNHAP = int.Parse(txtSL.Text);
                db.CTPHIEUNHAPs.Add(ctpn);
                db.SaveChanges();
            }
            this.Hide();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

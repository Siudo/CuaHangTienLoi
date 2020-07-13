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
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }
        void loadDL()
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                chSLBANnam.DataSource = db.SLHH_Nam1().ToList();
                chSLBANnam.Series["Số lượng"].XValueMember = "Thoigian";
                chSLBANnam.Series["Số lượng"].YValueMembers = "Soluong";
                chSLhethan.DataSource = db.SLHH_hethan1().ToList();
                chSLhethan.Series["Số lượng"].XValueMember = "TENHANG";
                chSLhethan.Series["Số lượng"].YValueMembers = "Soluong";
                chTongTienTrongNam.DataSource = db.TONGTIENTHUDC().ToList();
                chTongTienTrongNam.Series["VND"].XValueMember = "thoigian";
                chTongTienTrongNam.Series["VND"].YValueMembers = "tongtien";
                lbDoanhThu.Text = db.Doanhthu().FirstOrDefault().ToString();
                lbSLBan.Text = db.SLbanduoc_TK().FirstOrDefault().ToString();
                lbSLHETHAN.Text = db.SLhethan_TK().FirstOrDefault().ToString();
                lbSLNHAP.Text = db.SLNhap_TK().FirstOrDefault().soluongnhap.ToString();
                lbThoiGian.Text = db.SLNhap_TK().FirstOrDefault().thoigian.ToString();
                
            }
        }
        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            loadDL();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chSLBANnam_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

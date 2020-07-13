using Guna.UI2.WinForms;
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
    public partial class frm_Menu : Form
    {
        public string ten = "";
        public string CV = "";
        private string quyen = "";
        private string manv;
        private Guna2Button btn;
        public frm_Menu(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public string Manv { get => manv; set => manv = value; }
        private void ActivateButton(Object SenderBtn, Color color)
        {
            if (SenderBtn != null)
            {
                DisableButton();
                btn = (Guna2Button)SenderBtn;
                btn.FillColor = Color.Black;
                btn.ForeColor = color;
            }
        }
        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Show();
        }
        private void DisableButton()
        {
            if (btn != null)
            {
                btn.FillColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }
        private void btnQLHH_Click(object sender, EventArgs e)
        {
            if (quyen.Contains("Q1") )
            {
                
                ActivateButton(sender, Color.White);
                loadform(new frm_QuanLyHangHoa());
            }
            else if (quyen.Contains("Q2"))
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_QuanLyHangHoa());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!");
                return;
            }
           
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            if (quyen.Contains("Q1") )
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_QLNV());
            } else if (quyen.Contains("Q3"))
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_QLNV());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!");
                return;
            }
            
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            if (quyen.Contains("Q1"))
            {

                ActivateButton(sender, Color.White);
                loadform(new frm_QLKH());
            }
            else if (quyen.Contains("Q4"))
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_QLKH());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!");
                return;
            }
            
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            if (quyen.Contains("Q1"))
            {

                ActivateButton(sender, Color.White);
                loadform(new frm_QLNCC());
            }
            else if (quyen.Contains("Q2"))
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_QLNCC());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!");
                return;
            }
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            loadform(new frm_ThongKe());
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                string macv = db.NHANVIENs.Where(p => p.MANV.ToString() == manv).FirstOrDefault().MACV.ToString();
                List<chitietquyen_Result> ds_quyen = db.chitietquyen().Where(p => p.MACV.ToString() == macv).ToList();
                foreach (chitietquyen_Result item in ds_quyen)
                {
                    quyen += item.MAQUYEN.Trim() + " ";
                }
                string tennv = db.NHANVIENs.Where(p => p.MANV.ToString() == manv).FirstOrDefault().TENNV.ToString();
                label1.Text = "Xin chào " + tennv;

            }
            loadform(new frm_Logo());
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (quyen.Contains("Q1"))
            {

                ActivateButton(sender, Color.White);
                loadform(new frm_HoaDon());
            }
            else if (quyen.Contains("Q4"))
            {
                ActivateButton(sender, Color.White);
                loadform(new frm_HoaDon());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!");
                return;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            loadform(new frm_Logo());
        }
        int x = 1, y = 1;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            this.Hide();
            f.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, y, 1, 1);
            x++;
            if (x >= 754)
            {
                x = 1;
            }
        }
    }
}

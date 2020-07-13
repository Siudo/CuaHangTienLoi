using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTienLoi
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
              using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(p => p.TENTK == txtUser.Text && p.MK == txtPass.Text).FirstOrDefault();
                if (tk != null)
                {
                    string manv = db.NHANVIENs.FirstOrDefault(p => p.MATK == tk.MATK).MANV.ToString();
                    frm_Menu f = new frm_Menu(manv);
                    this.Hide();
                    f.Visible = true;
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản rồi");
                }
            }
        }
        Random randomma = new Random();
        int maxn = 0;
        private void btnGui_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
               
                if (string.IsNullOrEmpty(txtMaXN.Text))
                {
                    if(db.NHANVIENs.Where(p=>p.GMAIL == txtGmail.Text).FirstOrDefault() != null)
                    {
                        String txttendangnhap = "cuahangtienloipdt@gmail.com";
                        String txtmk = "123456cuahang";

                        string email = txtGmail.Text;
                        maxn = randomma.Next(1000, 9999);
                        MailMessage mail = new MailMessage(txttendangnhap, email, "Mã xác nhận", maxn.ToString()); //
                        mail.IsBodyHtml = true;
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        client.Host = "smtp.gmail.com";
                        client.UseDefaultCredentials = false;
                        client.Port = 587;
                        client.Credentials = new System.Net.NetworkCredential(txttendangnhap, txtmk);
                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                    else
                    {
                        MessageBox.Show("Không có tài khoản này");
                        return;
                    }
                   
                }
                else
                {
                   if(txtMaXN.Text == maxn.ToString())
                    {
                        pnDoiMK.Visible = true;
                       

                    }
                    else
                    {
                        MessageBox.Show("Sai mã xác nhận rồi");
                        txtMaXN.Text = "";
                    }
                }
                
            }
           

           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pnQuenMK.Hide();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(txtPasswordMoi.Text == "" || txtPasswordMoi2.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ");
                return;
            }
            if (txtPasswordMoi.Text != txtPasswordMoi2.Text )
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
                return;
            }
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                string matk = db.NHANVIENs.Where(p => p.GMAIL == txtGmail.Text).FirstOrDefault().MATK.ToString();
                TAIKHOAN tk = db.TAIKHOANs.Where(p => p.MATK.ToString() == matk.ToString()).FirstOrDefault();
                tk.MK = txtPasswordMoi2.Text;
                db.SaveChanges();

            }
            pnDoiMK.Visible = false;
            pnQuenMK.Visible = false;
        }

        private void txtPasswordMoi2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnQuenMK.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

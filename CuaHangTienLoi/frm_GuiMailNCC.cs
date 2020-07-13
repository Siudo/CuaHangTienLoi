using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangTienLoi
{
    public partial class frm_GuiMailNCC : Form
    {
        public frm_GuiMailNCC()
        {
            InitializeComponent();
        }

        private void frm_GuiMailNCC_Load(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                cbNCC.DataSource = db.NHACUNGCAPs.ToList();
                cbNCC.DisplayMember = "TENNCC";
                cbNCC.ValueMember = "GMAIL";
            }
        }
       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String txttendangnhap = "cuahangtienloipdt@gmail.com";
            String txtmk = "123456cuahang";
            String txtSubject = txtTieuDe.Text;
            String email = cbNCC.SelectedValue.ToString();
            String text = txtText.Text;
            Thread thread = new Thread(() =>
            {
                MailMessage mail = new MailMessage(txttendangnhap, email, txtSubject, text); //
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587; 
                client.Credentials = new System.Net.NetworkCredential(txttendangnhap, txtmk);
                client.EnableSsl = true; 
                client.Send(mail);
                
            }) ;
            thread.Start();
            MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
            this.Hide();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

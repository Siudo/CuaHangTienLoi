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
                if(db.TAIKHOANs.Where(p=> p.TENTK == txtUser.Text && p.MK == txtPass.Text).FirstOrDefault() != null)
                {
                    frm_Menu f = new frm_Menu();
                    this.Hide();
                    f.Visible = true;
                }
                else
                {
                    MessageBox.Show("Nhập sai tài khoản rồi");
                }
            }
        }
    }
}

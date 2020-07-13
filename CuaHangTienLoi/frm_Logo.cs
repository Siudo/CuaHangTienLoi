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
    public partial class frm_Logo : Form
    {
        public frm_Logo()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbGio.Text = date.Hour.ToString();
            lbPhut.Text = date.Minute.ToString();
            lbGiay.Text = date.Second.ToString();
        }
    }
}

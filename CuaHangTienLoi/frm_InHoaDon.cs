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
    public partial class frm_InHoaDon : Form
    {
        public frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {

                rpt_Hoadon1BindingSource.DataSource = db.rpt_Hoadon_final().ToList();
                //reportViewer1.LocalReport.DataSources = 
            }
                this.reportViewer1.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

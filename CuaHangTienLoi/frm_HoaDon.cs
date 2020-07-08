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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }
        void loadDL()
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                var ds_nvbh = from c in db.NHANVIENs
                              where c.MACV == 5
                              select c;
                cbTenNV.DataSource = ds_nvbh.ToList();
                cbTenNV.DisplayMember = "TENNV";
                cbTenNV.ValueMember = "MANV";
                List<DANHSACHHOADON_Result> ds_hd = db.DANHSACHHOADON().ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("mahd");
                dt.Columns.Add("ngayhd");
                dt.Columns.Add("tongtien");
                dt.Columns.Add("tennv");
                dt.Columns.Add("makh");
                foreach(DANHSACHHOADON_Result item in ds_hd)
                {
                    DateTime ngayhd = (DateTime)item.NGAYHD;
                    dt.Rows.Add(item.MAHD, ngayhd.ToString("yyyy-MM-dd"), item.TONGTIEN, item.TENNV, item.MAKH);
                }
                dgvHoaDon.DataSource = dt;
            }
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            loadDL();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    if(db.HOADONs.Where( p => p.MAHD.ToString() == txtMaHD.Text).FirstOrDefault()!= null){
                        var ds_nvbh = from c in db.DANHSACHHOADON()
                                      where c.MAHD.Equals(int.Parse(txtMaHD.Text))
                                      select c;

                        dgvHoaDon.DataSource = ds_nvbh.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không tim thấy");
                        loadDL();
                    }
                    
                    
                    
                }else if (string.IsNullOrEmpty(txtMaHD.Text))
                {
                    if(db.KHACHHANGs.Where(p => p.TENKH.Contains(txtTenKH.Text)).FirstOrDefault() != null)
                    {
                        var ds_nvbh = from c in db.DANHSACHHOADON()
                                      where c.MAKH == db.KHACHHANGs.Where(p => p.TENKH.Contains(txtTenKH.Text)).FirstOrDefault().MAKH
                                      select c;
                        dgvHoaDon.DataSource = ds_nvbh.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không tim thấy");
                        loadDL();
                    }
                    
                }
              

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadDL();
        }
    }
}

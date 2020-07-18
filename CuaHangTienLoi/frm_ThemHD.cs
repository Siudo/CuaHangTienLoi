using Microsoft.VisualBasic;
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
    public partial class frm_ThemHD : Form
    {
        public frm_ThemHD()
        {
            InitializeComponent();
        }

        private void frm_ThemHD_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        void loadDL()
        {
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                var ds_nvbh = from c in db.NHANVIENs
                              where c.MACV == 5
                              select c;
                cbTenNV.DataSource = ds_nvbh.ToList();
                cbTenNV.DisplayMember = "TENNV";
                cbTenNV.ValueMember = "MANV";
                List<danhsachhanghoa_Result> ds_hh = db.danhsachhanghoa().ToList();
                foreach (danhsachhanghoa_Result item in ds_hh)
                {
                    ListViewItem it = new ListViewItem();
                    it.Text = item.TENHANG.ToString();
                    DateTime hsd = (DateTime)item.HSD;
                    it.SubItems.Add(hsd.ToString("yyyy-MM-dd"));
                    it.SubItems.Add(item.DONVITINH.ToString());
                    it.SubItems.Add(((int)item.GIABAN) + "  VND");
                    it.SubItems.Add("     ");
                    lvSP.Items.Add(it);
                }

            }
        }
        private void lvSP_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == false)
                return;
            else if(e.Item.Checked == true)
            {
                string myvalue;
                
                myvalue = Interaction.InputBox("Nhập số lượng mua: ", "Thông báo", "");
                if (myvalue == "")
                {
                    e.Item.Checked = false;
                    return;
                }
                try
                {
                    int i = int.Parse(myvalue);
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai kiểu dữ liệu. Vui lòng nhập lại!! (Kiểu dữ liệu số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Item.Checked = false;
                    return;
                }
                e.Item.SubItems[4].Text = myvalue;
            }
           
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                HOADON hd = new HOADON();
                
                DateTime ngayhd = DateTime.Now;
                hd.NGAYHD = DateTime.Parse(ngayhd.ToString("yyyy-MM-dd"));
                hd.MANV = int.Parse(cbTenNV.SelectedValue.ToString());
                if (db.KHACHHANGs.Where(p=>p.SDT == txtSDT.Text).FirstOrDefault() != null)
                {
                    int makh = db.KHACHHANGs.Where(p => p.SDT == txtSDT.Text).FirstOrDefault().MAKH;
                    hd.MAKH = makh;
                }
                hd.TONGTIEN = 0;
                db.HOADONs.Add(hd);
                db.SaveChanges();
                foreach (ListViewItem item in lvSP.Items)
                {
                    if (item.Checked)
                    {
                        string tenhang = item.SubItems[0].Text.ToString();
                        int mahang = db.danhsachhanghoa().Where(p => p.TENHANG.Contains(tenhang)).FirstOrDefault().MAHANG;
                        CTHOADON cthd = new CTHOADON();
                        cthd.MAHANG = mahang;
                        cthd.SLBAN = int.Parse(item.SubItems[4].Text);
                        cthd.MAHD = int.Parse(db.LAYMAHD().FirstOrDefault().ToString());
                        db.CTHOADONs.Add(cthd);
                        db.SaveChanges();
                        
                    }
                }
                MessageBox.Show("Thêm hoá đơn thành công");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
             using(CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {
                if (db.KHACHHANGs.Where(p => p.SDT == txtSDT.Text).FirstOrDefault() != null)
                {
                    string tenkh = db.KHACHHANGs.Where(p => p.SDT == txtSDT.Text).FirstOrDefault().TENKH;
                    MessageBox.Show(tenkh);
                }
                else
                {
                    MessageBox.Show("Không có khách hàng này");
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frm_InHoaDon inhoadon = new frm_InHoaDon();
            inhoadon.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTKTENSP_Click(object sender, EventArgs e)
        {

        }
        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                           "đ","é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị",
                                           "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                           "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                           "d","e","e","e","e","e","e","e","e","e","e","e","i","i","i","i","i",
                                           "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                           "u","u","u","u","u","u","u","u","u","u","u","y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTenSP.Text == "")
                loadDL();
            lvSP.Items.Clear();
           
            using (CUAHANGTIENLOI db = new CUAHANGTIENLOI())
            {

                List<danhsachhanghoa_Result> ds_hh = db.danhsachhanghoa().ToList();
                foreach (danhsachhanghoa_Result item in ds_hh)
                {
                    if (RemoveUnicode(item.TENHANG.ToLower()).Contains(RemoveUnicode(txtTenSP.Text.ToLower())))
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = item.TENHANG.ToString();
                        DateTime hsd = (DateTime)item.HSD;
                        it.SubItems.Add(hsd.ToString("yyyy-MM-dd"));
                        it.SubItems.Add(item.DONVITINH.ToString());
                        it.SubItems.Add(((int)item.GIABAN) + "  VND");
                        it.SubItems.Add("     ");
                        lvSP.Items.Add(it);
                    }

                }

            }
        }
    }
}

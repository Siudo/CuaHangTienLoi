namespace CuaHangTienLoi
{
    partial class frm_QuanLyHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.txtTenhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHSD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDVT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChonHinh = new Guna.UI2.WinForms.Guna2Button();
            this.ofdChonHinh = new System.Windows.Forms.OpenFileDialog();
            this.dgvHangHoa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 15;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Black;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(521, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(137, 45);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 15;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Black;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(686, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(137, 45);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(864, 270);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(137, 45);
            this.guna2Button3.TabIndex = 3;
            this.guna2Button3.Text = "Xoá";
            // 
            // picSP
            // 
            this.picSP.Location = new System.Drawing.Point(12, 12);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(330, 303);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 4;
            this.picSP.TabStop = false;
            // 
            // txtTenhang
            // 
            this.txtTenhang.BorderRadius = 20;
            this.txtTenhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenhang.DefaultText = "";
            this.txtTenhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhang.DisabledState.Parent = this.txtTenhang;
            this.txtTenhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhang.FocusedState.Parent = this.txtTenhang;
            this.txtTenhang.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTenhang.ForeColor = System.Drawing.Color.Black;
            this.txtTenhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhang.HoverState.Parent = this.txtTenhang;
            this.txtTenhang.Location = new System.Drawing.Point(438, 63);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.PasswordChar = '\0';
            this.txtTenhang.PlaceholderText = "";
            this.txtTenhang.SelectedText = "";
            this.txtTenhang.ShadowDecoration.Parent = this.txtTenhang;
            this.txtTenhang.Size = new System.Drawing.Size(175, 40);
            this.txtTenhang.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hạn sử dụng :";
            // 
            // txtHSD
            // 
            this.txtHSD.BorderRadius = 20;
            this.txtHSD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHSD.DefaultText = "";
            this.txtHSD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHSD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHSD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHSD.DisabledState.Parent = this.txtHSD;
            this.txtHSD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHSD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHSD.FocusedState.Parent = this.txtHSD;
            this.txtHSD.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtHSD.ForeColor = System.Drawing.Color.Black;
            this.txtHSD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHSD.HoverState.Parent = this.txtHSD;
            this.txtHSD.Location = new System.Drawing.Point(438, 121);
            this.txtHSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.PasswordChar = '\0';
            this.txtHSD.PlaceholderText = "";
            this.txtHSD.SelectedText = "";
            this.txtHSD.ShadowDecoration.Parent = this.txtHSD;
            this.txtHSD.Size = new System.Drawing.Size(175, 40);
            this.txtHSD.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị tính :";
            // 
            // txtDVT
            // 
            this.txtDVT.BorderRadius = 20;
            this.txtDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDVT.DefaultText = "";
            this.txtDVT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDVT.DisabledState.Parent = this.txtDVT;
            this.txtDVT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDVT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDVT.FocusedState.Parent = this.txtDVT;
            this.txtDVT.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDVT.ForeColor = System.Drawing.Color.Black;
            this.txtDVT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDVT.HoverState.Parent = this.txtDVT;
            this.txtDVT.Location = new System.Drawing.Point(438, 181);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.PasswordChar = '\0';
            this.txtDVT.PlaceholderText = "";
            this.txtDVT.SelectedText = "";
            this.txtDVT.ShadowDecoration.Parent = this.txtDVT;
            this.txtDVT.Size = new System.Drawing.Size(175, 40);
            this.txtDVT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng hàng :";
            // 
            // txtSL
            // 
            this.txtSL.BorderRadius = 20;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.Parent = this.txtSL;
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedState.Parent = this.txtSL;
            this.txtSL.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.HoverState.Parent = this.txtSL;
            this.txtSL.Location = new System.Drawing.Point(770, 63);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.ShadowDecoration.Parent = this.txtSL;
            this.txtSL.Size = new System.Drawing.Size(175, 40);
            this.txtSL.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá bán :";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderRadius = 20;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.Parent = this.txtGiaBan;
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.FocusedState.Parent = this.txtGiaBan;
            this.txtGiaBan.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.HoverState.Parent = this.txtGiaBan;
            this.txtGiaBan.Location = new System.Drawing.Point(770, 123);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.ShadowDecoration.Parent = this.txtGiaBan;
            this.txtGiaBan.Size = new System.Drawing.Size(175, 40);
            this.txtGiaBan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại hàng :";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiSP.BorderRadius = 20;
            this.cbLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiSP.FocusedState.Parent = this.cbLoaiSP;
            this.cbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiSP.HoverState.Parent = this.cbLoaiSP;
            this.cbLoaiSP.ItemHeight = 30;
            this.cbLoaiSP.ItemsAppearance.Parent = this.cbLoaiSP;
            this.cbLoaiSP.Location = new System.Drawing.Point(770, 181);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.ShadowDecoration.Parent = this.cbLoaiSP;
            this.cbLoaiSP.Size = new System.Drawing.Size(175, 36);
            this.cbLoaiSP.TabIndex = 16;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.BorderRadius = 15;
            this.btnChonHinh.CheckedState.Parent = this.btnChonHinh;
            this.btnChonHinh.CustomImages.Parent = this.btnChonHinh;
            this.btnChonHinh.FillColor = System.Drawing.Color.Black;
            this.btnChonHinh.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnChonHinh.ForeColor = System.Drawing.Color.White;
            this.btnChonHinh.HoverState.Parent = this.btnChonHinh;
            this.btnChonHinh.Location = new System.Drawing.Point(361, 270);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.ShadowDecoration.Parent = this.btnChonHinh;
            this.btnChonHinh.Size = new System.Drawing.Size(137, 45);
            this.btnChonHinh.TabIndex = 17;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // ofdChonHinh
            // 
            this.ofdChonHinh.FileName = "openFileDialog1";
            // 
            // dgvHangHoa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvHangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhang,
            this.hsd,
            this.donvitinh,
            this.soluong,
            this.loaihang,
            this.hinh,
            this.giaban});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangHoa.EnableHeadersVisualStyles = false;
            this.dgvHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 321);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(1081, 324);
            this.dgvHangHoa.TabIndex = 18;
            this.dgvHangHoa.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangHoa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvHangHoa.ThemeStyle.ReadOnly = false;
            this.dgvHangHoa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvHangHoa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHangHoa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHangHoa.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHangHoa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.Name = "tenhang";
            // 
            // hsd
            // 
            this.hsd.DataPropertyName = "hsd";
            this.hsd.HeaderText = "Hạn sử dụng";
            this.hsd.Name = "hsd";
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.Name = "donvitinh";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // loaihang
            // 
            this.loaihang.DataPropertyName = "loaihang";
            this.loaihang.HeaderText = "Loại hàng";
            this.loaihang.Name = "loaihang";
            // 
            // hinh
            // 
            this.hinh.DataPropertyName = "hinh";
            this.hinh.HeaderText = "Hình";
            this.hinh.Name = "hinh";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            // 
            // frm_QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 645);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHSD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLyHangHoa";
            this.Text = "frm_QuanLyHangHoa";
            this.Load += new System.EventHandler(this.frm_QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.PictureBox picSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtHSD;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDVT;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnChonHinh;
        private System.Windows.Forms.OpenFileDialog ofdChonHinh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
    }
}
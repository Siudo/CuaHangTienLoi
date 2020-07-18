namespace CuaHangTienLoi
{
    partial class frm_GuiMailNCC
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
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.cbNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTieuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 20;
            this.btnGui.CheckedState.Parent = this.btnGui;
            this.btnGui.CustomImages.Parent = this.btnGui;
            this.btnGui.FillColor = System.Drawing.Color.Black;
            this.btnGui.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.HoverState.Parent = this.btnGui;
            this.btnGui.Location = new System.Drawing.Point(114, 510);
            this.btnGui.Name = "btnGui";
            this.btnGui.ShadowDecoration.Parent = this.btnGui;
            this.btnGui.Size = new System.Drawing.Size(180, 45);
            this.btnGui.TabIndex = 0;
            this.btnGui.Text = "GỬI";
            this.btnGui.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(395, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Location = new System.Drawing.Point(114, 200);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(461, 289);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            // 
            // cbNCC
            // 
            this.cbNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbNCC.BorderRadius = 20;
            this.cbNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNCC.FocusedState.Parent = this.cbNCC;
            this.cbNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNCC.HoverState.Parent = this.cbNCC;
            this.cbNCC.ItemHeight = 30;
            this.cbNCC.ItemsAppearance.Parent = this.cbNCC;
            this.cbNCC.Location = new System.Drawing.Point(114, 34);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.ShadowDecoration.Parent = this.cbNCC;
            this.cbNCC.Size = new System.Drawing.Size(461, 36);
            this.cbNCC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn nhà cung cấp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Viết nội dung :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiêu đề  :";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Animated = true;
            this.txtTieuDe.BorderColor = System.Drawing.Color.Black;
            this.txtTieuDe.BorderRadius = 20;
            this.txtTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTieuDe.DefaultText = "";
            this.txtTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTieuDe.DisabledState.Parent = this.txtTieuDe;
            this.txtTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTieuDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTieuDe.FocusedState.Parent = this.txtTieuDe;
            this.txtTieuDe.ForeColor = System.Drawing.Color.Black;
            this.txtTieuDe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTieuDe.HoverState.Parent = this.txtTieuDe;
            this.txtTieuDe.Location = new System.Drawing.Point(114, 118);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.PasswordChar = '\0';
            this.txtTieuDe.PlaceholderText = "";
            this.txtTieuDe.SelectedText = "";
            this.txtTieuDe.ShadowDecoration.Parent = this.txtTieuDe;
            this.txtTieuDe.Size = new System.Drawing.Size(461, 36);
            this.txtTieuDe.TabIndex = 7;
            // 
            // frm_GuiMailNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 567);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_GuiMailNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_GuiMailNCC";
            this.Load += new System.EventHandler(this.frm_GuiMailNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.RichTextBox txtText;
        private Guna.UI2.WinForms.Guna2ComboBox cbNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTieuDe;
    }
}
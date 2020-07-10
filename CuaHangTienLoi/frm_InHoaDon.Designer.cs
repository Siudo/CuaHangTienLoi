namespace CuaHangTienLoi
{
    partial class frm_InHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataHoaDon = new CuaHangTienLoi.DataHoaDon();
            this.rpt_Hoadon1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpt_Hoadon1TableAdapter = new CuaHangTienLoi.DataHoaDonTableAdapters.rpt_Hoadon1TableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_Hoadon1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataHoaDonrpt";
            reportDataSource2.Value = this.rpt_Hoadon1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuaHangTienLoi.report_HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataHoaDon
            // 
            this.DataHoaDon.DataSetName = "DataHoaDon";
            this.DataHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpt_Hoadon1BindingSource
            // 
            this.rpt_Hoadon1BindingSource.DataMember = "rpt_Hoadon1";
            this.rpt_Hoadon1BindingSource.DataSource = this.DataHoaDon;
            // 
            // rpt_Hoadon1TableAdapter
            // 
            this.rpt_Hoadon1TableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(49, 42);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "<";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 605);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InHoaDon";
            this.Text = "frm_InHoaDon";
            this.Load += new System.EventHandler(this.frm_InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_Hoadon1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rpt_Hoadon1BindingSource;
        private DataHoaDon DataHoaDon;
        private DataHoaDonTableAdapters.rpt_Hoadon1TableAdapter rpt_Hoadon1TableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
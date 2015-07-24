namespace QLTV.Reports
{
    partial class frmDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DocGia_DTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLap = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.reportViewerDocGia = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DocGia_DTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocGia_DTOBindingSource
            // 
            this.DocGia_DTOBindingSource.DataSource = typeof(QLTV.DTO.DocGia_DTO);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLap);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 20);
            this.txtName.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(88, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Người Lập Báo Cáo";
            // 
            // btnLap
            // 
            this.btnLap.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLap.Appearance.Options.UseFont = true;
            this.btnLap.Location = new System.Drawing.Point(688, 8);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(84, 27);
            this.btnLap.TabIndex = 6;
            this.btnLap.Text = "Lập Báo Cáo";
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.reportViewerDocGia);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(860, 410);
            this.panelControl2.TabIndex = 7;
            // 
            // reportViewerDocGia
            // 
            this.reportViewerDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSDocGia";
            reportDataSource1.Value = this.DocGia_DTOBindingSource;
            this.reportViewerDocGia.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDocGia.LocalReport.ReportEmbeddedResource = "QLTV.Reports.rptDocGia.rdlc";
            this.reportViewerDocGia.Location = new System.Drawing.Point(3, 3);
            this.reportViewerDocGia.Name = "reportViewerDocGia";
            this.reportViewerDocGia.Size = new System.Drawing.Size(854, 404);
            this.reportViewerDocGia.TabIndex = 7;
            this.reportViewerDocGia.Load += new System.EventHandler(this.reportViewerDocGia_Load);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDocGia";
            this.Size = new System.Drawing.Size(860, 450);
            ((System.ComponentModel.ISupportInitialize)(this.DocGia_DTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DocGia_DTOBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLap;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDocGia;
    }
}

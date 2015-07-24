namespace QLTV.Reports
{
    partial class frmTraSach
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLap = new DevExpress.XtraEditors.SimpleButton();
            this.reportViewerTraSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TraSach_DTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraSach_DTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnLap);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.reportViewerTraSach);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(860, 400);
            this.panelControl2.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 20);
            this.txtName.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(88, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Người Lập Báo Cáo";
            // 
            // btnLap
            // 
            this.btnLap.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLap.Appearance.Options.UseFont = true;
            this.btnLap.Location = new System.Drawing.Point(688, 12);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(84, 27);
            this.btnLap.TabIndex = 9;
            this.btnLap.Text = "Lập Báo Cáo";
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // reportViewerTraSach
            // 
            this.reportViewerTraSach.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSTraSach";
            reportDataSource2.Value = this.TraSach_DTOBindingSource;
            this.reportViewerTraSach.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerTraSach.LocalReport.ReportEmbeddedResource = "QLTV.Reports.fptTraSach.rdlc";
            this.reportViewerTraSach.Location = new System.Drawing.Point(3, 3);
            this.reportViewerTraSach.Name = "reportViewerTraSach";
            this.reportViewerTraSach.Size = new System.Drawing.Size(854, 394);
            this.reportViewerTraSach.TabIndex = 0;
            this.reportViewerTraSach.Load += new System.EventHandler(this.reportViewerTraSach_Load);
            // 
            // TraSach_DTOBindingSource
            // 
            this.TraSach_DTOBindingSource.DataSource = typeof(QLTV.DTO.TraSach_DTO);
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTraSach";
            this.Size = new System.Drawing.Size(860, 450);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraSach_DTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLap;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTraSach;
        private System.Windows.Forms.BindingSource TraSach_DTOBindingSource;
    }
}

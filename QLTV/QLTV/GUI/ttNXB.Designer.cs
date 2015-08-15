namespace QLTV.Use_Control
{
    partial class ttNXB
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
            this.dgvNXB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNXB
            // 
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNXB.Location = new System.Drawing.Point(0, 0);
            this.dgvNXB.MainView = this.gridView1;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(860, 450);
            this.dgvNXB.TabIndex = 0;
            this.dgvNXB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChiNXB,
            this.DienThoaiNXB,
            this.Website});
            this.gridView1.GridControl = this.dgvNXB;
            this.gridView1.Name = "gridView1";
            // 
            // MaNXB
            // 
            this.MaNXB.Caption = "Mã Nhà XB";
            this.MaNXB.FieldName = "MaNXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Visible = true;
            this.MaNXB.VisibleIndex = 0;
            // 
            // TenNXB
            // 
            this.TenNXB.Caption = "Tên Nhà XB";
            this.TenNXB.FieldName = "TenNXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Visible = true;
            this.TenNXB.VisibleIndex = 1;
            // 
            // DiaChiNXB
            // 
            this.DiaChiNXB.Caption = "Địa Chỉ NXB";
            this.DiaChiNXB.FieldName = "DiaChiNXB";
            this.DiaChiNXB.Name = "DiaChiNXB";
            this.DiaChiNXB.Visible = true;
            this.DiaChiNXB.VisibleIndex = 2;
            // 
            // DienThoaiNXB
            // 
            this.DienThoaiNXB.Caption = "Điện Thoại NXB";
            this.DienThoaiNXB.FieldName = "DienThoaiNXB";
            this.DienThoaiNXB.Name = "DienThoaiNXB";
            this.DienThoaiNXB.Visible = true;
            this.DienThoaiNXB.VisibleIndex = 3;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.Name = "Website";
            this.Website.Visible = true;
            this.Website.VisibleIndex = 4;
            // 
            // ttNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvNXB);
            this.Name = "ttNXB";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvNXB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn TenNXB;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiNXB;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiNXB;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
    }
}

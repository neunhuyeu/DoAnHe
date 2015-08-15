namespace QLTV.Use_Control
{
    partial class ttTacGia
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
            this.dgvTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiTG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTacGia.Location = new System.Drawing.Point(0, 0);
            this.dgvTacGia.MainView = this.gridView1;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.Size = new System.Drawing.Size(860, 450);
            this.dgvTacGia.TabIndex = 0;
            this.dgvTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTG,
            this.TenTG,
            this.DiaChiTG,
            this.DienThoaiTG});
            this.gridView1.GridControl = this.dgvTacGia;
            this.gridView1.Name = "gridView1";
            // 
            // MaTG
            // 
            this.MaTG.Caption = "Mã Tác Giả";
            this.MaTG.FieldName = "MaTG";
            this.MaTG.Name = "MaTG";
            this.MaTG.Visible = true;
            this.MaTG.VisibleIndex = 0;
            // 
            // TenTG
            // 
            this.TenTG.Caption = "Tên Tác Giả";
            this.TenTG.FieldName = "HoTenTG";
            this.TenTG.Name = "TenTG";
            this.TenTG.Visible = true;
            this.TenTG.VisibleIndex = 1;
            // 
            // DiaChiTG
            // 
            this.DiaChiTG.Caption = "Địa Chỉ TG";
            this.DiaChiTG.FieldName = "DiaChiTG";
            this.DiaChiTG.Name = "DiaChiTG";
            this.DiaChiTG.Visible = true;
            this.DiaChiTG.VisibleIndex = 2;
            // 
            // DienThoaiTG
            // 
            this.DienThoaiTG.Caption = "Điện Thoại TG";
            this.DienThoaiTG.FieldName = "DienThoai";
            this.DienThoaiTG.Name = "DienThoaiTG";
            this.DienThoaiTG.Visible = true;
            this.DienThoaiTG.VisibleIndex = 3;
            // 
            // ttTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTacGia);
            this.Name = "ttTacGia";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTG;
        private DevExpress.XtraGrid.Columns.GridColumn TenTG;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiTG;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiTG;
    }
}

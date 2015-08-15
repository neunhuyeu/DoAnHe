namespace QLTV.Use_Control
{
    partial class ttSach
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
            this.dgvSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDungTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.MainView = this.gridView1;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(860, 450);
            this.dgvSach.TabIndex = 3;
            this.dgvSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.NoiDungTT,
            this.SoTrang,
            this.Gia,
            this.SoLuong,
            this.NgayNhap,
            this.MaNXB,
            this.MaTG,
            this.MaTL,
            this.TinhTrang});
            this.gridView1.GridControl = this.dgvSach;
            this.gridView1.Name = "gridView1";
            // 
            // MaSach
            // 
            this.MaSach.Caption = "Mã Sách";
            this.MaSach.FieldName = "MaSach";
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "TenSach";
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            // 
            // NoiDungTT
            // 
            this.NoiDungTT.Caption = "Nội dung tóm tắt";
            this.NoiDungTT.FieldName = "NoiDungTT";
            this.NoiDungTT.Name = "NoiDungTT";
            this.NoiDungTT.Visible = true;
            this.NoiDungTT.VisibleIndex = 2;
            // 
            // SoTrang
            // 
            this.SoTrang.Caption = "Số Trang";
            this.SoTrang.FieldName = "SoTrang";
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.Visible = true;
            this.SoTrang.VisibleIndex = 3;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá bìa";
            this.Gia.FieldName = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 4;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 6;
            // 
            // MaNXB
            // 
            this.MaNXB.Caption = "Mã NXB";
            this.MaNXB.FieldName = "MaNXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Visible = true;
            this.MaNXB.VisibleIndex = 7;
            // 
            // MaTG
            // 
            this.MaTG.Caption = "Mã TG";
            this.MaTG.FieldName = "MaTG";
            this.MaTG.Name = "MaTG";
            this.MaTG.Visible = true;
            this.MaTG.VisibleIndex = 8;
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã TL";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 9;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Tình Trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 10;
            // 
            // ttSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSach);
            this.Name = "ttSach";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungTT;
        private DevExpress.XtraGrid.Columns.GridColumn SoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn MaTG;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
    }
}

namespace QLTV.Use_Control
{
    partial class ttDocGia
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
            this.dgvDocGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLamThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(0, 0);
            this.dgvDocGia.MainView = this.gridView1;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(860, 450);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDG,
            this.TenDG,
            this.EmailDG,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChiDG,
            this.DienThoaiDG,
            this.NgayLamThe,
            this.NgayHetHan,
            this.HoatDong});
            this.gridView1.GridControl = this.dgvDocGia;
            this.gridView1.Name = "gridView1";
            // 
            // MaDG
            // 
            this.MaDG.Caption = "Mã ĐG";
            this.MaDG.FieldName = "MaDG";
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = true;
            this.MaDG.VisibleIndex = 0;
            // 
            // TenDG
            // 
            this.TenDG.Caption = "Tên ĐG";
            this.TenDG.FieldName = "HoTenDG";
            this.TenDG.Name = "TenDG";
            this.TenDG.Visible = true;
            this.TenDG.VisibleIndex = 1;
            // 
            // EmailDG
            // 
            this.EmailDG.Caption = "Email ĐG";
            this.EmailDG.FieldName = "EmailDG";
            this.EmailDG.Name = "EmailDG";
            this.EmailDG.Visible = true;
            this.EmailDG.VisibleIndex = 2;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinhDG";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinhDG";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 4;
            // 
            // DiaChiDG
            // 
            this.DiaChiDG.Caption = "Địa Chỉ ĐG";
            this.DiaChiDG.FieldName = "DiaChiDG";
            this.DiaChiDG.Name = "DiaChiDG";
            this.DiaChiDG.Visible = true;
            this.DiaChiDG.VisibleIndex = 5;
            // 
            // DienThoaiDG
            // 
            this.DienThoaiDG.Caption = "Điện Thoại ĐG";
            this.DienThoaiDG.FieldName = "DienThoaiDG";
            this.DienThoaiDG.Name = "DienThoaiDG";
            this.DienThoaiDG.Visible = true;
            this.DienThoaiDG.VisibleIndex = 6;
            // 
            // NgayLamThe
            // 
            this.NgayLamThe.Caption = "Ngày Làm Thẻ";
            this.NgayLamThe.FieldName = "NgayLamThe";
            this.NgayLamThe.Name = "NgayLamThe";
            this.NgayLamThe.Visible = true;
            this.NgayLamThe.VisibleIndex = 7;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.Caption = "Ngày Hết Hạn";
            this.NgayHetHan.FieldName = "NgayHetHan";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Visible = true;
            this.NgayHetHan.VisibleIndex = 8;
            // 
            // HoatDong
            // 
            this.HoatDong.Caption = "Hoạt Động";
            this.HoatDong.FieldName = "HoatDong";
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.Visible = true;
            this.HoatDong.VisibleIndex = 9;
            // 
            // ttDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocGia);
            this.Name = "ttDocGia";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDG;
        private DevExpress.XtraGrid.Columns.GridColumn TenDG;
        private DevExpress.XtraGrid.Columns.GridColumn EmailDG;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiDG;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiDG;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLamThe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn HoatDong;
    }
}

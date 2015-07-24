namespace QLTV.Use_Control
{
    partial class ttNhanVien
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
            this.dgvttNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoLam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyenHan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvttNhanVien
            // 
            this.dgvttNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvttNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvttNhanVien.MainView = this.gridView1;
            this.dgvttNhanVien.Name = "dgvttNhanVien";
            this.dgvttNhanVien.Size = new System.Drawing.Size(860, 450);
            this.dgvttNhanVien.TabIndex = 3;
            this.dgvttNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.GioiTinh,
            this.NgaySinhNV,
            this.DienThoaiNV,
            this.DiaChiNV,
            this.EmailNV,
            this.NgayVaoLam,
            this.QuyenHan});
            this.gridView1.GridControl = this.dgvttNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã NV";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 0;
            // 
            // HoTenNV
            // 
            this.HoTenNV.Caption = "Họ Tên NV";
            this.HoTenNV.FieldName = "HoTenNV";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Visible = true;
            this.HoTenNV.VisibleIndex = 1;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinhNV";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            // 
            // NgaySinhNV
            // 
            this.NgaySinhNV.Caption = "Ngày Sinh";
            this.NgaySinhNV.FieldName = "NgaySinhNV";
            this.NgaySinhNV.Name = "NgaySinhNV";
            this.NgaySinhNV.Visible = true;
            this.NgaySinhNV.VisibleIndex = 3;
            // 
            // DienThoaiNV
            // 
            this.DienThoaiNV.Caption = "Điện Thoại";
            this.DienThoaiNV.FieldName = "DienThoaiNV";
            this.DienThoaiNV.Name = "DienThoaiNV";
            this.DienThoaiNV.Visible = true;
            this.DienThoaiNV.VisibleIndex = 4;
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.Caption = "Địa Chỉ";
            this.DiaChiNV.FieldName = "DiaChiNV";
            this.DiaChiNV.Name = "DiaChiNV";
            this.DiaChiNV.Visible = true;
            this.DiaChiNV.VisibleIndex = 5;
            // 
            // EmailNV
            // 
            this.EmailNV.Caption = "EmailNV";
            this.EmailNV.FieldName = "EmailNV";
            this.EmailNV.Name = "EmailNV";
            this.EmailNV.Visible = true;
            this.EmailNV.VisibleIndex = 6;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.Caption = "Ngày Vào Làm";
            this.NgayVaoLam.FieldName = "NgayVaoLam";
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.Visible = true;
            this.NgayVaoLam.VisibleIndex = 7;
            // 
            // QuyenHan
            // 
            this.QuyenHan.Caption = "Quyền Hạn";
            this.QuyenHan.FieldName = "QuyenHan";
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.Visible = true;
            this.QuyenHan.VisibleIndex = 8;
            // 
            // ttNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvttNhanVien);
            this.Name = "ttNhanVien";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.ttNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvttNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvttNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiNV;
        private DevExpress.XtraGrid.Columns.GridColumn EmailNV;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoLam;
        private DevExpress.XtraGrid.Columns.GridColumn QuyenHan;

    }
}

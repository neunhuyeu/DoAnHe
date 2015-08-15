namespace QLTV.GUI
{
    partial class tkSach
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.cboTheLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.cboTacGia = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNXB = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.radTheLoai = new System.Windows.Forms.RadioButton();
            this.radTenTG = new System.Windows.Forms.RadioButton();
            this.radTenNXB = new System.Windows.Forms.RadioButton();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radMaSach = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDanhSach = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.cboTheLoai);
            this.groupControl1.Controls.Add(this.cboTacGia);
            this.groupControl1.Controls.Add(this.cboNXB);
            this.groupControl1.Controls.Add(this.txtTenSach);
            this.groupControl1.Controls.Add(this.txtMaSach);
            this.groupControl1.Controls.Add(this.radTheLoai);
            this.groupControl1.Controls.Add(this.radTenTG);
            this.groupControl1.Controls.Add(this.radTenNXB);
            this.groupControl1.Controls.Add(this.radTenSach);
            this.groupControl1.Controls.Add(this.radMaSach);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(860, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Nhập các thông tin";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Appearance.Options.UseFont = true;
            this.btnHienThi.Image = global::QLTV.Properties.Resources.find;
            this.btnHienThi.Location = new System.Drawing.Point(699, 76);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(126, 36);
            this.btnHienThi.TabIndex = 41;
            this.btnHienThi.Text = "Hiển thị Tất cả";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Location = new System.Drawing.Point(369, 146);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTheLoai.Size = new System.Drawing.Size(250, 20);
            this.cboTheLoai.TabIndex = 40;
            // 
            // cboTacGia
            // 
            this.cboTacGia.Location = new System.Drawing.Point(369, 117);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTacGia.Size = new System.Drawing.Size(250, 20);
            this.cboTacGia.TabIndex = 39;
            // 
            // cboNXB
            // 
            this.cboNXB.Location = new System.Drawing.Point(369, 88);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNXB.Size = new System.Drawing.Size(250, 20);
            this.cboNXB.TabIndex = 38;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(369, 59);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(250, 20);
            this.txtTenSach.TabIndex = 37;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(369, 31);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(250, 20);
            this.txtMaSach.TabIndex = 36;
            // 
            // radTheLoai
            // 
            this.radTheLoai.AutoSize = true;
            this.radTheLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheLoai.Location = new System.Drawing.Point(216, 146);
            this.radTheLoai.Name = "radTheLoai";
            this.radTheLoai.Size = new System.Drawing.Size(72, 20);
            this.radTheLoai.TabIndex = 32;
            this.radTheLoai.TabStop = true;
            this.radTheLoai.Text = "Thể loại";
            this.radTheLoai.UseVisualStyleBackColor = true;
            this.radTheLoai.CheckedChanged += new System.EventHandler(this.radTheLoai_CheckedChanged);
            // 
            // radTenTG
            // 
            this.radTenTG.AutoSize = true;
            this.radTenTG.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenTG.Location = new System.Drawing.Point(216, 117);
            this.radTenTG.Name = "radTenTG";
            this.radTenTG.Size = new System.Drawing.Size(88, 20);
            this.radTenTG.TabIndex = 31;
            this.radTenTG.TabStop = true;
            this.radTenTG.Text = "Tên tác giả";
            this.radTenTG.UseVisualStyleBackColor = true;
            this.radTenTG.CheckedChanged += new System.EventHandler(this.radTenTG_CheckedChanged);
            // 
            // radTenNXB
            // 
            this.radTenNXB.AutoSize = true;
            this.radTenNXB.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenNXB.Location = new System.Drawing.Point(216, 88);
            this.radTenNXB.Name = "radTenNXB";
            this.radTenNXB.Size = new System.Drawing.Size(123, 20);
            this.radTenNXB.TabIndex = 30;
            this.radTenNXB.TabStop = true;
            this.radTenNXB.Text = "Tên nhà xuất bản";
            this.radTenNXB.UseVisualStyleBackColor = true;
            this.radTenNXB.CheckedChanged += new System.EventHandler(this.radTenNXB_CheckedChanged);
            // 
            // radTenSach
            // 
            this.radTenSach.AutoSize = true;
            this.radTenSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenSach.Location = new System.Drawing.Point(216, 59);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(75, 20);
            this.radTenSach.TabIndex = 29;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tên sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            this.radTenSach.CheckedChanged += new System.EventHandler(this.radTenSach_CheckedChanged);
            // 
            // radMaSach
            // 
            this.radMaSach.AutoSize = true;
            this.radMaSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaSach.Location = new System.Drawing.Point(216, 31);
            this.radMaSach.Name = "radMaSach";
            this.radMaSach.Size = new System.Drawing.Size(73, 20);
            this.radMaSach.TabIndex = 28;
            this.radMaSach.TabStop = true;
            this.radMaSach.Text = "Mã sách";
            this.radMaSach.UseVisualStyleBackColor = true;
            this.radMaSach.CheckedChanged += new System.EventHandler(this.radMaSach_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(163, 15);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tìm kiếm thông tin sách theo:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QLTV.Properties.Resources.cen2;
            this.btnHuy.Location = new System.Drawing.Point(699, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Image = global::QLTV.Properties.Resources.search;
            this.btnTim.Location = new System.Drawing.Point(699, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(126, 36);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 185);
            this.dgvDanhSach.MainView = this.gridView1;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(860, 265);
            this.dgvDanhSach.TabIndex = 4;
            this.dgvDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.dgvDanhSach;
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
            // tkSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.groupControl1);
            this.Name = "tkSach";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.tkSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.RadioButton radTheLoai;
        private System.Windows.Forms.RadioButton radTenTG;
        private System.Windows.Forms.RadioButton radTenNXB;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radMaSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.LookUpEdit cboTheLoai;
        private DevExpress.XtraEditors.LookUpEdit cboTacGia;
        private DevExpress.XtraEditors.LookUpEdit cboNXB;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private DevExpress.XtraGrid.GridControl dgvDanhSach;
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

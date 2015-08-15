namespace QLTV.Use_Control
{
    partial class cnTacGia
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSdt = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTG = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTG = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dgvTacGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSdt);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtTenTG);
            this.groupControl1.Controls.Add(this.txtMaTG);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(156, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(704, 143);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Điền các Thông tin";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QLTV.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(589, 98);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 26);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QLTV.Properties.Resources.apply;
            this.btnLuu.Location = new System.Drawing.Point(422, 98);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 26);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(96, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(96, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(34, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "(*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(54, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(174, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = ": Vui lòng nhập đầy đủ các Thông tin";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(459, 72);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(210, 20);
            this.txtSdt.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(459, 30);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(143, 72);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(210, 20);
            this.txtTenTG.TabIndex = 13;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Location = new System.Drawing.Point(143, 30);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(210, 20);
            this.txtMaTG.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Tác Giả";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tên Tác Giả";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(376, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Địa Chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(376, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Số Điện Thoại";
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTacGia.Location = new System.Drawing.Point(0, 149);
            this.dgvTacGia.MainView = this.gridView1;
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.Size = new System.Drawing.Size(860, 301);
            this.dgvTacGia.TabIndex = 8;
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
            this.MaTG.Caption = "Mã TG";
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
            this.DienThoaiTG.FieldName = "DienThoaiTG";
            this.DienThoaiTG.Name = "DienThoaiTG";
            this.DienThoaiTG.Visible = true;
            this.DienThoaiTG.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(150, 143);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::QLTV.Properties.Resources.del;
            this.btnXoa.Location = new System.Drawing.Point(35, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 26);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::QLTV.Properties.Resources.update;
            this.btnSua.Location = new System.Drawing.Point(35, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 26);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = global::QLTV.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(35, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cnTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.groupControl1);
            this.Name = "cnTacGia";
            this.Size = new System.Drawing.Size(860, 450);
            this.Load += new System.EventHandler(this.cnTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion 

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSdt;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenTG;
        private DevExpress.XtraEditors.TextEdit txtMaTG;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl dgvTacGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTG;
        private DevExpress.XtraGrid.Columns.GridColumn TenTG;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiTG;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiTG;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}

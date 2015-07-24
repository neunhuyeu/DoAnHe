using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using QLTV.BLL;
using QLTV.DTO;


namespace QLTV
{
    public partial class TrangChu : RibbonForm
    {
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd(); 
        DangNhap dn = null;
        NhanVien_BLL nvBUS = new NhanVien_BLL();

        public TrangChu()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        #region "Code cho nut Close xtraTabControl"
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {// Đóng tab đang focus trên TAb Cha
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }
        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {// Khi add vào thì Focus tới ngay Tab vừa Add
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
        #endregion

        #region Các hàm xử lý login và phân quyền

        public void AnMenu(bool logged, int QuyenHan = 1)
        { 
        //Mac dinh la dang nhap thanh cong bat het cac Menu

            //
            btnttBanThan.Enabled = logged;
            btnDoiMatKhau.Enabled = logged;
            btndsNhanVien.Enabled = logged;
            btnDangNhap.Enabled = !logged;
            btnDangXuat.Enabled = logged;
            //
            btnttCaNhan.Enabled = logged;
            btnDoiMK.Enabled = logged;
            btnqlNhanVien.Enabled = logged;
            btnqlDocGia.Enabled = logged;
            btnqlSach.Enabled = logged;
            btnqlTheLoai.Enabled = logged;
            btnqlTacGia.Enabled = logged;
            btnqlNXB.Enabled = logged;
            //
            btnPhieuMuon.Enabled = logged;
            btnPhieuTra.Enabled = logged;
            btnPhieuNopPhat.Enabled = logged;
            btnQH.Enabled = logged;
            btnSachChuaDuocMuon.Enabled = logged;
            //
            btnbcSach.Enabled = logged;
            btnDocGia.Enabled = logged;

            switch (QuyenHan)
            {
                case 1: break;
                case 0: HienThiNhanVien(); break;
            }
        }

        //Hiển thị Menu với nhóm "Nhân Viên"
        private void HienThiNhanVien()
        {
            btnqlNhanVien.Enabled = false;
        }

        #endregion

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsAddTab.AddTab(xtraTabControl1, "", "About", new Use_Control.About());
        }

        private void btnttBanThan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Bản Thân")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Bản Thân", new GUI.ttBanThan());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Thông tin Bản thân";
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Cập nhật Mật khẩu")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Cập nhật Mật khẩu", new GUI.cnMatKhau());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Đổi Mật khẩu";
        }

        private void btndsNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Thông Tin Nhân Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Nhân Viên", new Use_Control.ttNhanVien());
            }
            siInfo.Caption ="Nhân Viên : "+Utilities.user.MaNV+ " || Bạn đang xem tab Thông tin Nhân Viên";
        }

        private void btnHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Khởi tạo lại biến user dùng chung
            NhanVien_DTO user = new NhanVien_DTO();
            // Gọi lại Ẩn menu
            AnMenu(false);
            //Đóng tất cả các tab đang mở 
            xtraTabControl1.TabPages.Clear();
            //Mở lại form đăng nhập
            btnDangNhap_ItemClick(sender, e);
        }

        private void btnttCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnttBanThan_ItemClick(sender, e);
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnDoiMatKhau_ItemClick(sender, e);
        }

        private void btnqlNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý TT Nhân Viên")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý TT Nhân Viên", new Use_Control.cnNhanVien());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản Lý TT Nhân Viên";
        }

        private void btnqlDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Độc Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Độc Giả", new Use_Control.cnDocGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản Lý Độc Giả";
        }

        private void btnqlSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản Lý Sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản Lý Sách", new Use_Control.cnSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản Lý Sách";
        }

        private void btnqlTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý TT Tác Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý TT Tác Giả", new Use_Control.cnTacGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản lý TT Tác Giả";
        }

        private void btnqlTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý TT Thể Loại")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý TT Thể Loại", new Use_Control.cnTheLoai());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản lý TT Thể Loại";
        }

        private void btnqlNXB_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Quản lý TT NXB")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Quản lý TT NXB", new Use_Control.cnNXB());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Quản lý TT NXB";
        }

        private void btnPhieuMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phiếu Mượn")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Phiếu Mượn", new Use_Control.MuonSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Phiếu Mượn";
        }

        private void btnPhieuTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Phiếu Trả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Phiếu Trả", new GUI.cnTraSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Phiếu Trả";
        }

        private void btnSachChuaDuocMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Sách Chưa Được Mượn")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Sách Chưa Được Mượn", new GUI.ttSachChuaDuocMuon());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Sách Chưa Được Mượn";
        }

        private void btnPhieuNopPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Lượt Mượn")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Lượt Mượn", new GUI.ttLuotMuon());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Lượt Mượn";
        }

        private void btnQH_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Mượn Quá Hạn")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Mượn Quá Hạn", new GUI.ttMuonQuaHan());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Mượn Quá Hạn";
        }

        private void btnttSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Sách", new Use_Control.ttSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tra cứu Thông Tin Sách";
        }

        private void btnttTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Tác Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Tác Giả", new Use_Control.ttTacGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tra cứu Thông Tin Tác Giả";
        }

        private void btnttTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Thể Loại")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Thể Loại", new Use_Control.ttTheLoai());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tra cứu Thông Tin Thể Loại";
        }

        private void btnttNXB_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Nhà Xuất Bản")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Nhà Xuất Bản", new Use_Control.ttNXB());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tra cứu Thông Tin Nhà Xuất Bản";
        }

        private void btnttDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Thông Tin Độc Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Thông Tin Độc Giả", new Use_Control.ttDocGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tra cứu Thông Tin Độc Giả";
        }

        private void btntkSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm Sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm Sách", new GUI.tkSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tìm kiếm Thông Tin Sách";
        }

        private void btntkDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Tìm kiếm Độc Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Tìm kiếm Độc Giả", new GUI.tkDocGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tìm kiếm Thông Tin Độc Giả";
        }

        private void btnbcSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Trả Sách")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Trả Sách", new Reports.frmTraSach());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tìm kiếm Báo Cáo Sách";
        }

        private void btnDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "Báo Cáo Độc Giả")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "Báo Cáo Độc Giả", new Reports.frmDocGia());
            }
            siInfo.Caption = "Nhân Viên : " + Utilities.user.MaNV + " || Bạn đang xem tab Tìm kiếm Báo Cáo Độc Giả";
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
            {
                if (tab.Text == "About")
                {
                    xtraTabControl1.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                clsAddTab.AddTab(xtraTabControl1, "", "About", new Use_Control.About());
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Khởi tạo biến Continue
        Cont:
            //Kiểm tra xem form DangNhap được mở hay đóng, nếu đóng thì tạo mới
            if (dn == null || dn.IsDisposed)
                dn = new DangNhap();
            if (dn.ShowDialog() == DialogResult.OK)
            {
                string MaNV = dn.txtTenDN.Text;
                string matkhau = dn.txtMatKhau.Text;

                // Trước tiên ta nên kiểm tra username và password có hợp lệ hay không?
                if (MaNV.Equals(""))
                {
                    // Gán thông báo cho label Thông báo
                    dn.lblTrangThaiLogin.Text = "Bạn chưa nhập Tên đăng nhập !";
                    goto Cont;
                }
                if (MaNV.Equals(""))
                {
                    // Gán thông báo cho label Thông báo
                    dn.lblTrangThaiLogin.Text = "Bạn chưa nhập Mật khẩu !";
                    goto Cont;
                }

                //Lấy thông tin nhân viên
                Utilities.user = nvBUS.LayTTDangNhap(MaNV);
                //Trường hợp Mã NV không tồn tại
                if (Utilities.user.MaNV.Equals(""))
                {
                    // Gán thông báo cho label Thông báo
                    dn.lblTrangThaiLogin.Text = "Tên Đăng nhập không tồn tại!";
                    goto Cont;
                }
                //Trường hợp Mật khẩu không đúng
                if (Utilities.user.MatKhau != matkhau)
                {
                    dn.lblTrangThaiLogin.Text = " Mật khẩu không đúng !";
                    goto Cont;
                }
                //Trường hợp đăng nhập thành công
                //Set lại menu theo quyền  
                AnMenu(true, Utilities.user.QuyenHan);
            }

        }
    }
}
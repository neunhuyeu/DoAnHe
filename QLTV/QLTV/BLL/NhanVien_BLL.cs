using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLTV.DAL;
using QLTV.DTO;

namespace QLTV.BLL
{
    public class NhanVien_BLL
    {

        NhanVien_DAL nhanvien_dal = new NhanVien_DAL();
        //Hàm lấy tất cả danh sách Nhân Viên để hiển thị
        public DataTable LayDanhSachNhanVien()
        {

            return nhanvien_dal.LayDanhSachNhanVien();
        }

        //Hàm Xem danh sách Nhân Viên (Không hiển thị mật khẩu)
        public DataTable XemDanhSachNhanVien()
        {
            return nhanvien_dal.XemDanhSachNhanVien();
        }

        //Hàm lấy thông tin bản thân
        public NhanVien_DTO LayThongTinBanThan(string MaNV)
        {
            return nhanvien_dal.LayThongTinBanThan(MaNV);
        }

        //Lấy thông tin Nhân Viên cho Đăng nhập
        public NhanVien_DTO LayTTDangNhap(string MaNV)
        {
            return nhanvien_dal.LayTTDangNhap(MaNV);
        }

        //Đổi mật khẩu
        public bool DoiMatKhau(string matkhau)
        {
            return nhanvien_dal.DoiMatKhau(matkhau);
        }

        // Lấy danh sách NV cho load sang ComboBox PM
        public DataTable LayDSNV()
        {
            return nhanvien_dal.LayDSNV();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NhanVien_DTO nv)
        {
            return nhanvien_dal.KiemTraTruocKhiLuu(nv);
        }

        //Thêm Nhân Viên vào CSDL
        public bool ThemNV(NhanVien_DTO nv)
        {
            return nhanvien_dal.ThemNV(nv);
        }

        //Sửa Nhân Viên vào CSDL
        public bool SuaNV(NhanVien_DTO nv)
        {
            return nhanvien_dal.SuaNV(nv);
        }

        //Xóa Nhân Viên trong CSDL
        public bool XoaNV(string MaNV)
        {
            return nhanvien_dal.XoaNV(MaNV);
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return nhanvien_dal.NextID();
        }
    }
}

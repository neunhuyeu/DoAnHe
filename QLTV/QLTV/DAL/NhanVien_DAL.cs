using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class NhanVien_DAL
    {
        ConnectDB connect = new ConnectDB();
        //Hàm lấy tất cả danh sách Nhân Viên để hiển thị
        public DataTable LayDanhSachNhanVien()
        {
            return connect.LoadData("sp_LayDanhSachNhanVien");
        }
        //Hàm Xem danh sách Nhân Viên (Không hiển thị mật khẩu)
        public DataTable XemDanhSachNhanVien()
        {
            return connect.LoadData("sp_XemDanhSachNhanVien");
        }
        //Hàm lấy thông tin bản thân
        public NhanVien_DTO LayThongTinBanThan(string MaNV)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNV"; value[0] = MaNV;
            DataTable dt = connect.LoadData("sp_LayThongTinBanThan", name, value, param);
            NhanVien_DTO ttnv = new NhanVien_DTO();
            DataRow rowTTNV = dt.Rows[0];
            ttnv.MaNV = rowTTNV["MaNV"].ToString();
            ttnv.HoTenNV = rowTTNV["HoTenNV"].ToString();
            ttnv.GioiTinhNV = (rowTTNV["GioiTinhNV"].ToString() == "True") ? 1 : 0;
            ttnv.NgaySinhNV = Convert.ToDateTime(rowTTNV["NgaySinhNV"].ToString());
            ttnv.DienThoaiNV = rowTTNV["DienThoaiNV"].ToString();
            ttnv.DiaChiNV = rowTTNV["DiaChiNV"].ToString();
            ttnv.EmailNV = rowTTNV["EmailNV"].ToString();
            ttnv.NgayVaoLam = Convert.ToDateTime(rowTTNV["NgayVaoLam"].ToString());
            ttnv.QuyenHan = (rowTTNV["QuyenHan"].ToString() == "True") ? 1 : 0;
            return ttnv;
        }
        //Lấy thông tin Nhân Viên cho Đăng nhập
        public NhanVien_DTO LayTTDangNhap(string MaNV)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNV"; value[0] = MaNV;
            DataTable tbUser = connect.LoadData("sp_LayTTDangNhap", name, value, param);
            NhanVien_DTO user = new NhanVien_DTO();
            if (tbUser.Rows.Count > 0)
            {
                DataRow rowUser = tbUser.Rows[0];
                user.MaNV = rowUser["MaNV"].ToString();
                user.MatKhau = rowUser["MatKhau"].ToString();
                user.QuyenHan = (rowUser["QuyenHan"].ToString() == "True") ? 1 : 0;
            }
            else
            {
                user.MaNV = "";
                user.MatKhau = "";
                user.QuyenHan = 2;
            }
            return user;
        }
        //Đổi mật khẩu
        public bool DoiMatKhau(string matkhau)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MatKhau"; value[0] = matkhau;
            name[1] = "MaNV"; value[1] = Utilities.user.MaNV;

            if (connect.Update("sp_DoiMatKhau", name, value, param) > 0)
                return true;
            return false;
        }
        // Lấy danh sách NV cho load sang ComboBox PM
        public DataTable LayDSNV()
        {
            return connect.LoadData("sp_LayDSNV");
        }
        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NhanVien_DTO nv)
        {
            if (nv.HoTenNV.Equals(""))
            {
                MessageBox.Show("Tên Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.NgaySinhNV.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.NgayVaoLam.Equals(""))
            {
                MessageBox.Show("Ngày Vào Làm Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (nv.QuyenHan.Equals(""))
            {
                MessageBox.Show("Quền hạn không hợp lệ ! ");
                return false;
            }
            return true;
        }
        //Thêm Nhân Viên vào CSDL
        public bool ThemNV(NhanVien_DTO nv)
        {
            int param = 10;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNV"; value[0] = nv.MaNV;
            name[1] = "HoTenNV"; value[1] = nv.HoTenNV;
            name[2] = "GioiTinhNV"; value[2] = nv.GioiTinhNV;
            name[3] = "NgaySinhNV"; value[3] = nv.NgaySinhNV;
            name[4] = "DienThoaiNV"; value[4] = nv.DienThoaiNV;
            name[5] = "DiaChiNV"; value[5] = nv.DiaChiNV;
            name[6] = "EmailNV"; value[6] = nv.EmailNV;
            name[7] = "NgayVaoLam"; value[7] = nv.NgayVaoLam;
            name[8] = "MatKhau"; value[8] = nv.MatKhau;
            name[9] = "QuyenHan"; value[9] = nv.QuyenHan;

            if (KiemTraTruocKhiLuu(nv))
            {
                if (connect.Update("sp_ThemNV", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Nhân Viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Sửa Nhân Viên vào CSDL
        public bool SuaNV(NhanVien_DTO nv)
        {
            int param = 10;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNV"; value[0] = nv.MaNV;
            name[1] = "HoTenNV"; value[1] = nv.HoTenNV;
            name[2] = "GioiTinhNV"; value[2] = nv.GioiTinhNV;
            name[3] = "NgaySinhNV"; value[3] = nv.NgaySinhNV;
            name[4] = "DienThoaiNV"; value[4] = nv.DienThoaiNV;
            name[5] = "DiaChiNV"; value[5] = nv.DiaChiNV;
            name[6] = "EmailNV"; value[6] = nv.EmailNV;
            name[7] = "NgayVaoLam"; value[7] = nv.NgayVaoLam;
            name[8] = "MatKhau"; value[8] = nv.MatKhau;
            name[9] = "QuyenHan"; value[9] = nv.QuyenHan;

            if (KiemTraTruocKhiLuu(nv))
            {
                if (connect.Update("sp_SuaNV", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa Nhân Viên thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Xóa Nhân Viên trong CSDL
        public bool XoaNV(string MaNV)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNV"; value[0] = MaNV;
            if (connect.Update("sp_XoaNV", name, value, param) > 0)
            {
                MessageBox.Show("Xóa Nhân Viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("NHANVIEN", "MaNV"), "NV");
        }
    }
}

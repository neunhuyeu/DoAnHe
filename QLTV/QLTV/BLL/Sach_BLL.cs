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
    class Sach_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Sách để hiển thị
        public DataTable LayDanhSachSach()
        {
            string sql = " SELECT MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, (CASE TinhTrang WHEN 'true' THEN N'Sách Mới' ELSE N'Sách Cũ' END) AS TinhTrang FROM SACH";
            return connData.getdata(sql);
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSSReport()
        {
            string sql = " SELECT MaSach, TenSach, SoTrang, Gia, SoLuong, NgayNhap, TinhTrang FROM SACH";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sách load lên Combobox
        public DataTable LayDSSach()
        {
            string sql = "SELECT MaSach, TenSach FROM SACH";
            return connData.getdata(sql);
        }

        // Lấy danh sách Sách theo PM
        public DataTable LayDSSachTheoPM(string MaPhieu)
        {
            string sql = "SELECT MaPhieu, MaSach FROM CT_PHIEUMUON WHERE MaPhieu='" + MaPhieu + "'";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(Sach_DTO s)
        {
            if (s.TenSach.Equals(""))
            {
                MessageBox.Show("Tên Sách không hợp lệ ! ");
                return false;
            }
            if (s.NgayNhap.Equals(""))
            {
                MessageBox.Show("Ngày nhập Sách không hợp lệ ! ");
                return false;
            }
            if (s.MaNXB.Equals(""))
            {
                MessageBox.Show("Mã Nhà xuất bản không hợp lệ ! ");
                return false;
            }
            if (s.MaTG.Equals(""))
            {
                MessageBox.Show("Mã Tác Giả không hợp lệ ! ");
                return false;
            }
            if (s.MaTL.Equals(""))
            {
                MessageBox.Show("Mã Thể loại không hợp lệ ! ");
                return false;
            }
            if (s.TinhTrang.Equals(""))
            {
                MessageBox.Show("Tình trạng không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Sách vào CSDL
        public bool ThemSach(Sach_DTO s)
        {
            if (KiemTraTruocKhiLuu(s))
            {
                string sql = string.Format("INSERT INTO SACH (MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, TinhTrang)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}','{9}', {10})",
                    s.MaSach, s.TenSach, s.NoiDungTT, s.SoTrang, s.Gia, s.SoLuong, s.NgayNhap, s.MaNXB, s.MaTG, s.MaTL, s.TinhTrang);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Sách thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Sách vào CSDL
        public bool SuaSach(Sach_DTO s)
        {
            if (KiemTraTruocKhiLuu(s))
            {
                string sql = string.Format("UPDATE SACH SET TenSach=N'{1}', NoiDungTT=N'{2}', SoTrang='{3}', Gia='{4}', SoLuong='{5}', NgayNhap='{6}', MaNXB='{7}', MaTG='{8}', MaTL='{9}', TinhTrang={10} WHERE MaSach='{0}'",
                    s.MaSach, s.TenSach, s.NoiDungTT, s.SoTrang, s.Gia, s.SoLuong, s.NgayNhap, s.MaNXB, s.MaTG, s.MaTL, s.TinhTrang);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Sách trong CSDL
        public bool XoaSach(string MaSach)
        {
            string sql = "DELETE FROM SACH WHERE MaSach='" + MaSach + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("SACH", "MaSach"), "MS");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemSach(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaSach, TenSach, NoiDungTT, SoTrang, Gia, SoLuong, NgayNhap, MaNXB, MaTG, MaTL, (CASE TinhTrang WHEN 'true' THEN N'Sách Mới' ELSE N'Sách Cũ' END) AS TinhTrang FROM SACH WHERE "+DieuKien+" LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}

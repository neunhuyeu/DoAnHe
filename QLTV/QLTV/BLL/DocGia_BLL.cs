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
    class DocGia_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Độc giả để hiển thị
        public DataTable LayDanhSachDocGia()
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM DOCGIA";
            return connData.getdata(sql);
        }

        //Lấy Danh sách Độc giả load sang Reports Độc giả
        public DataTable Laydsdocgia()
        {
            string sql = "SELECT MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong FROM DOCGIA ";
            return connData.getdata(sql);
        }

        // Lấy danh sách DG cho load sang ComboBox PM
        public DataTable LayDSDG()
        {
            string sql = "SELECT MaDG, HoTenDG FROM DOCGIA";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(DocGia_DTO dg)
        {
            if (dg.HoTenDG.Equals(""))
            {
                MessageBox.Show("Tên Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgaySinhDG.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayLamThe.Equals(""))
            {
                MessageBox.Show("Ngày Làm thẻ Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayHetHan.Equals(""))
            {
                MessageBox.Show("Ngày Hết hạn thẻ không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Độc Giả vào CSDL
        public bool ThemDG(DocGia_DTO dg)
        {
            if (KiemTraTruocKhiLuu(dg))
            {
                string sql = string.Format("INSERT INTO DOCGIA (MaDG, HoTenDG, EmailDG, GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, HoatDong)"
                    + " VALUES ('{0}', N'{1}', N'{2}', '{3}',N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}')", dg.MaDG, dg.HoTenDG, dg.EmailDG, dg.GioiTinhDG, dg.NgaySinhDG, dg.DiaChiDG, dg.DienThoaiDG, dg.NgayLamThe, dg.NgayHetHan, dg.HoatDong);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Độc Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Độc Giả vào CSDL
        public bool SuaDG(DocGia_DTO dg)
        {
            if (KiemTraTruocKhiLuu(dg))
            {
                string sql = string.Format("UPDATE DOCGIA SET HoTenDG=N'{1}', EmailDG=N'{2}', GioiTinhDG={3}, NgaySinhDG=N'{4}', DiaChiDG=N'{5}', DienThoaiDG=N'{6}', NgayLamThe=N'{7}', NgayHetHan=N'{8}', HoatDong={9} WHERE MaDG=N'{0}'",
                    dg.MaDG, dg.HoTenDG, dg.EmailDG, dg.GioiTinhDG, dg.NgaySinhDG, dg.DiaChiDG, dg.DienThoaiDG, dg.NgayLamThe, dg.NgayHetHan, dg.HoatDong);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Độc Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Độc Giả trong CSDL
        public bool XoaDG(string MaDG)
        {
            string sql = "DELETE FROM DOCGIA WHERE MaDG='" + MaDG + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Độc Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("DOCGIA", "MaDG"), "DG");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemDG(string DieuKien, string TieuChi)
        {
            string sql = " SELECT MaDG, HoTenDG, EmailDG, (CASE GioiTinhDG WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinhDG, NgaySinhDG, DiaChiDG, DienThoaiDG, NgayLamThe, NgayHetHan, (CASE HoatDong WHEN 'true' THEN N'Đang Hoạt động' ELSE N'Đã Hết hạn' END) AS HoatDong FROM DOCGIA WHERE " + DieuKien + " LIKE N'%" + TieuChi + "%'";
            return connData.getdata(sql);
        }
    }
}

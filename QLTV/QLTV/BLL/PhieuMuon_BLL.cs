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
    class PhieuMuon_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Phiếu mượn để hiển thị
        public DataTable LayDanhSachPM()
        {
            string sql = " SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON";
            return connData.getdata(sql);
        }

        // Lấy danh sách PM cho load sang ComboBox 
        public DataTable LayDSPM()
        {
            string sql = "SELECT MaPhieu, MaDG, NgayMuon, MaNV FROM PHIEUMUON";
            return connData.getdata(sql);
        }

        //Lấy danh sách số lượt mượn
        public DataTable LayDSLuotMuon()
        {
            string sql = "SELECT CT_PHIEUMUON.MaSach, SACH.TenSach, SACH.Gia, SACH.SoLuong, THELOAI.TenTL, TACGIA.HoTenTG, COUNT(CT_PHIEUMUON.MaSach) AS TongLuotMuon FROM CT_PHIEUMUON INNER JOIN PHIEUMUON ON CT_PHIEUMUON.MaPhieu = PHIEUMUON.MaPhieu INNER JOIN SACH ON CT_PHIEUMUON.MaSach = SACH.MaSach INNER JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG WHERE (SACH.MaSach IN (SELECT MaSach FROM CT_PHIEUMUON AS CT_PHIEUMUON_1)) GROUP BY CT_PHIEUMUON.MaSach, SACH.TenSach, SACH.Gia, SACH.SoLuong, THELOAI.TenTL, TACGIA.HoTenTG";
            return connData.getdata(sql);
        }

        //Lấy danh sách số lượt mượn Quá hạn
        public DataTable LayDSMuonQuaHan()
        {
            string sql = "SELECT PHIEUMUON.MaPhieu, CT_PHIEUMUON.MaSach, SACH.TenSach, TACGIA.HoTenTG, DOCGIA.MaDG, DOCGIA.HoTenDG, DOCGIA.DiaChiDG, PHIEUMUON.NgayMuon, CT_PHIEUMUON.HanTra, TRASACH.NgayTra, DATEDIFF(day, TRASACH.NgayTra, CT_PHIEUMUON.HanTra) AS SONGAYQUAHAN FROM PHIEUMUON INNER JOIN  CT_PHIEUMUON ON PHIEUMUON.MaPhieu = CT_PHIEUMUON.MaPhieu INNER JOIN DOCGIA ON PHIEUMUON.MaDG = DOCGIA.MaDG INNER JOIN SACH ON CT_PHIEUMUON.MaSach = SACH.MaSach INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG INNER JOIN TRASACH ON PHIEUMUON.MaPhieu = TRASACH.MaPhieu AND SACH.MaSach = TRASACH.MaSach WHERE (TRASACH.NgayTra - CT_PHIEUMUON.HanTra > 0) OR (GETDATE() - CT_PHIEUMUON.HanTra > 0) AND (TRASACH.NgayTra IS NULL) ORDER BY PHIEUMUON.MaPhieu, CT_PHIEUMUON.MaSach, SACH.TenSach, TACGIA.HoTenTG, DOCGIA.MaDG, DOCGIA.HoTenDG, DOCGIA.DiaChiDG, PHIEUMUON.NgayMuon, CT_PHIEUMUON.HanTra, TRASACH.NgayTra";
            return connData.getdata(sql);
        }

        //Lấy danh sách sách chưa được mượn
        public DataTable LayDSSachChuaDuocMuon()
        {
            string sql = "SELECT  SACH.MaSach, SACH.TenSach, TACGIA.HoTenTG, THELOAI.TenTL, NHAXUATBAN.TenNXB, SACH.SoTrang, SACH.Gia, SACH.SoLuong, SACH.NgayNhap FROM SACH INNER JOIN TACGIA ON SACH.MaTG = TACGIA.MaTG INNER JOIN THELOAI ON SACH.MaTL = THELOAI.MaTL INNER JOIN NHAXUATBAN ON SACH.MaNXB = NHAXUATBAN.MaNXB WHERE (SACH.MaSach NOT IN (SELECT MaSach FROM CT_PHIEUMUON))";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuMuon_DTO pm)
        {
            if (pm.MaPhieu.Equals(""))
            {
                MessageBox.Show("Mã Phiếu không hợp lệ ! ");
                return false;
            }
            if (pm.NgayMuon.Equals(""))
            {
                MessageBox.Show("Ngày mượn Sách không hợp lệ ! ");
                return false;
            }
            if (pm.MaNV.Equals(""))
            {
                MessageBox.Show("Mã Nhân Viên không hợp lệ ! ");
                return false;
            }
            return true;
        }

        public bool KiemTra(string maphieu)
        {
            if (connData.KiemTraTonTai("CT_PHIEUMUON", "MaPhieu", maphieu))
                return true;
            return false;
        }

        //Thêm Phiếu mượn vào CSDL
        public bool ThemPM(PhieuMuon_DTO pm)
        {
            if (KiemTraTruocKhiLuu(pm))
            {
                string sql = string.Format("INSERT INTO PHIEUMUON (MaPhieu, MaDG, NgayMuon, MaNV)"
                    + " VALUES ('{0}', '{1}', '{2}', '{3}')",
                    pm.MaPhieu, pm.MaDG, pm.NgayMuon, pm.MaNV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Phiếu mượn thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Phiếu mượn vào CSDL
        public bool SuaPM(PhieuMuon_DTO pm)
        {
            if (KiemTraTruocKhiLuu(pm))
            {
                string sql = string.Format("UPDATE PHIEUMUON SET MaDG='{1}', NgayMuon=N'{2}', MaNV='{3}' WHERE MaPhieu='{0}'",
                    pm.MaPhieu, pm.MaDG, pm.NgayMuon, pm.MaNV);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Phiếu mượn trong CSDL
        public bool XoaPM(string MaPhieu)
        {
            string sql = "DELETE FROM PHIEUMUON WHERE MaPhieu='" + MaPhieu + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Phiếu mượn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("PHIEUMUON", "MaPhieu"), "PM");
        }
    }
}

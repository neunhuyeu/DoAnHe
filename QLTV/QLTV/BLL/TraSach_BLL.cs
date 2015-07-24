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
    class TraSach_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách trả sách
        public DataTable LayDanhSachTRASACH()
        {
            string sql = "SELECT MaPhieu, MaSach, MaNV, NgayTra, PhatHuHong, PhatQuaHan FROM TRASACH";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TraSach_DTO ts)
        {
            if (ts.MaSach.Equals(""))
            {
                MessageBox.Show("Mã Sách không hợp lệ ! ");
                return false;
            }
            if (ts.MaNV.Equals(""))
            {
                MessageBox.Show("Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (ts.NgayTra.Equals(""))
            {
                MessageBox.Show("Ngày Trả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Phiếu trả vào CSDL
        public bool ThemPT(TraSach_DTO ts)
        {
            if (KiemTraTruocKhiLuu(ts))
            {
                string sql = string.Format("INSERT INTO TRASACH (MaPhieu, MaSach, MaNV, NgayTra, PhatHuHong, PhatQuaHan)"
                    + " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
                    ts.MaPhieu, ts.MaSach, ts.MaNV, ts.NgayTra, ts.PhatHuHong, ts.PhatQuaHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Phiếu Trả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Phiếu Trả vào CSDL
        public bool SuaPT(TraSach_DTO ts)
        {
            if (KiemTraTruocKhiLuu(ts))
            {
                string sql = string.Format("UPDATE TRASACH SET MaSach=N'{1}', MaNV=N'{2}', NgayTra=N'{3}', PhatHuHong=N'{4}', PhatQuaHan=N'{5}' WHERE MaPhieu=N'{0}'", ts.MaPhieu, ts.MaSach, ts.MaNV, ts.NgayTra, ts.PhatHuHong, ts.PhatQuaHan);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Phiếu trả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Phiếu trả trong CSDL
        public bool XoaPT(string MaSach)
        {
            string sql = "DELETE FROM TRASACH WHERE MaSach='" + MaSach + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Phiếu trả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}

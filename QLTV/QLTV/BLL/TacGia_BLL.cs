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
    class TacGia_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public  DataTable LayDanhSachTacGia()
        {
            string sql = "SELECT * FROM TACGIA";
            return connData.getdata(sql);
        }

        // Lấy danh sách Tác Giả
        public DataTable LayDSTG()
        {
            string sql = "SELECT MaTG, HoTenTG FROM TACGIA";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TacGia_DTO tg)
        {
            if (tg.MaTG.Equals(""))
            {
                MessageBox.Show("Mã Tác Giả không hợp lệ ! ");
                return false;
            }
            if (tg.HoTenTG.Equals(""))
            {
                MessageBox.Show("Tên Tác giả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra sự tồn tại của Mã TG trong bảng sách
        public bool KiemTra(string matg)
        {
            if (connData.KiemTraTonTai("SACH", "MaTG", matg))
                return true;
            return false;
        }

        //Thêm Tác Giả vào CSDL
        public bool ThemTG(TacGia_DTO tg)
        {
            if (KiemTraTruocKhiLuu(tg))
            {
                string sql = string.Format("INSERT INTO TACGIA (MaTG, HoTenTG, DiaChiTG, DienThoaiTG)" 
                    + " VALUES ('{0}', N'{1}', N'{2}', N'{3}')", tg.MaTG, tg.HoTenTG, tg.DiaChiTG, tg.DienThoaiTG);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Tác Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Tác Giả vào CSDL
        public bool SuaTG(TacGia_DTO tg)
        {
            if (KiemTraTruocKhiLuu(tg))
            {
                string sql = string.Format("UPDATE TACGIA SET HoTenTG=N'{1}', DiaChiTG=N'{2}', DienThoaiTG=N'{3}' WHERE MaTG=N'{0}'", tg.MaTG, tg.HoTenTG, tg.DiaChiTG, tg.DienThoaiTG);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Tác Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Tác Giả trong CSDL
        public bool XoaTG(string MaTG)
        {
            string sql = "DELETE FROM TACGIA WHERE MaTG='" + MaTG + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Tác Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("TACGIA", "MaTG"), "TG");
        }
    }
}

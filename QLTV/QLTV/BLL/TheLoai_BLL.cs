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
    class TheLoai_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTheLoai()
        {
            string sql = "SELECT MaTL, TenTL, GhiChu FROM THELOAI";
            return connData.getdata(sql);
        }

        // Lấy danh sách TL cho load sang ComboBox Sach
        public DataTable LayDSTL()
        {
            string sql = "SELECT MaTL, TenTL FROM THELOAI";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TheLoai_DTO tl)
        {
            if (tl.TenTL.Equals(""))
            {
                MessageBox.Show("Tên Thể Loại không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã sách
        public bool KiemTra(string matl)
        {
            if (connData.KiemTraTonTai("SACH", "MaTL", matl))
                return true;
            return false;
        }

        //Thêm Thể loại vào CSDL
        public bool ThemTL(TheLoai_DTO tl)
        {
            if (KiemTraTruocKhiLuu(tl))
            {
                string sql = string.Format("INSERT INTO THELOAI (MaTL, TenTL, GhiChu)" 
                    + " VALUES ('{0}', N'{1}', N'{2}')", tl.MaTL, tl.TenTL, tl.GhiChu);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        //Sửa Thể Loại vào CSDL
        public bool SuaTL(TheLoai_DTO tl)
        {
            if (KiemTraTruocKhiLuu(tl))
            {
                string sql = string.Format("UPDATE THELOAI SET TenTL=N'{0}', GhiChu=N'{1}' WHERE MaTL='{2}'", tl.TenTL, tl.GhiChu, tl.MaTL);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Thể Loại thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Thể loại trong CSDL
        public bool XoaTL(string MaTL)
        {
            string sql = "DELETE FROM THELOAI WHERE MaTL='"+MaTL+"'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Thể Loại thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("THELOAI", "MaTL"), "TL");
        }

        //public string matl { get; set; }
    }
}

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
    public class TheLoai_BLL
    {
        TheLoai_DAL theloai_dal = new TheLoai_DAL();
        

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTheLoai()
        {
            return theloai_dal.LayDanhSachTheLoai();
        }

        // Lấy danh sách TL cho load sang ComboBox Sach
        public DataTable LayDSTL()
        {
            return theloai_dal.LayDSTL();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TheLoai_DTO tl)
        {
            return theloai_dal.KiemTraTruocKhiLuu(tl);
        }

        //Kiểm tra tồn tại của Mã sách
        public bool KiemTra(string matl)
        {
            return theloai_dal.KiemTra(matl);
        }

        //Thêm Thể loại vào CSDL
        public bool ThemTL(TheLoai_DTO tl)
        {
            return theloai_dal.ThemTL(tl);
        }


        //Sửa Thể Loại vào CSDL
        public bool SuaTL(TheLoai_DTO tl)
        {
            return theloai_dal.SuaTL(tl);
        }

        //Xóa Thể loại trong CSDL
        public bool XoaTL(string MaTL)
        {
            return theloai_dal.XoaTL(MaTL);
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return theloai_dal.NextID();
        }

    }
}

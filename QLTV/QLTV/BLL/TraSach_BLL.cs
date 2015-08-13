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
    public class TraSach_BLL
    {
        TraSach_DAL trasach_dal = new TraSach_DAL();

        //Hàm lấy tất cả danh sách trả sách
        public DataTable LayDanhSachTRASACH()
        {
            return trasach_dal.LayDanhSachTRASACH();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TraSach_DTO ts)
        {
            return trasach_dal.KiemTraTruocKhiLuu(ts);
        }

        //Thêm Phiếu trả vào CSDL
        public bool ThemPT(TraSach_DTO ts)
        {
            return trasach_dal.ThemPT(ts);
        }


        //Sửa Phiếu Trả vào CSDL
        public bool SuaPT(TraSach_DTO ts)
        {
            return trasach_dal.SuaPT(ts);
        }

        //Xóa Phiếu trả trong CSDL
        public bool XoaPT(string MaSach)
        {
            return trasach_dal.XoaPT(MaSach);
        }
    }
}

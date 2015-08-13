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
    public class TacGia_BLL
    {
        TacGia_DAL tacgia_dal = new TacGia_DAL();
        

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public  DataTable LayDanhSachTacGia()
        {
            return tacgia_dal.LayDanhSachTacGia();
        }

        // Lấy danh sách Tác Giả
        public DataTable LayDSTG()
        {
            return tacgia_dal.LayDSTG();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TacGia_DTO tg)
        {
            return tacgia_dal.KiemTraTruocKhiLuu(tg);
        }

        //Kiểm tra sự tồn tại của Mã TG trong bảng sách
        public bool KiemTra(string matg)
        {
            return tacgia_dal.KiemTra(matg);
        }

        //Thêm Tác Giả vào CSDL
        public bool ThemTG(TacGia_DTO tg)
        {
            return tacgia_dal.ThemTG(tg);
        }


        //Sửa Tác Giả vào CSDL
        public bool SuaTG(TacGia_DTO tg)
        {
            return tacgia_dal.SuaTG(tg);
        }

        //Xóa Tác Giả trong CSDL
        public bool XoaTG(string MaTG)
        {
            return tacgia_dal.XoaTG(MaTG);
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return tacgia_dal.NextID();
        }
    }
}

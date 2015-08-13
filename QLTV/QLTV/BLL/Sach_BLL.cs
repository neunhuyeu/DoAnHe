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
    public class Sach_BLL
    {
        Sach_DAL sach_dal = new Sach_DAL();

        //Hàm lấy tất cả danh sách Sách để hiển thị
        public DataTable LayDanhSachSach()
        {
            return sach_dal.LayDanhSachSach();
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSSReport()
        {
            return sach_dal.LayDSSReport();
        }

        // Lấy danh sách Sách load lên Combobox
        public DataTable LayDSSach()
        {
            return sach_dal.LayDSSach();
        }

        // Lấy danh sách Sách theo PM
        public DataTable LayDSSachTheoPM(string MaPhieu)
        {
            return sach_dal.LayDSSachTheoPM(MaPhieu);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(Sach_DTO s)
        {
            return sach_dal.KiemTraTruocKhiLuu(s);
        }

        //Thêm Sách vào CSDL
        public bool ThemSach(Sach_DTO s)
        {
            return sach_dal.ThemSach(s);
        }

        //Sửa Sách vào CSDL
        public bool SuaSach(Sach_DTO s)
        {
            return sach_dal.SuaSach(s);
        }

        //Xóa Sách trong CSDL
        public bool XoaSach(string MaSach)
        {
            return sach_dal.XoaSach(MaSach);
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return sach_dal.NextID();
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemSach(string DieuKien, string TieuChi)
        {
            return sach_dal.TimKiemSach(DieuKien, TieuChi);
        }
    }
}

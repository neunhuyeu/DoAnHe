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
    public class DocGia_BLL
    {
        //ConnectDB connData = new ConnectDB();
        DocGia_DAL docgia_dal = new DocGia_DAL();
        //Hàm lấy tất cả danh sách Độc giả để hiển thị
        public DataTable LayDanhSachDocGia()
        {
            return docgia_dal.LayDanhSachDocGia();
        }

        //Lấy Danh sách Độc giả load sang Reports Độc giả
        public DataTable Laydsdocgia()
        {
            return docgia_dal.Laydsdocgia();
        }

        // Lấy danh sách DG cho load sang ComboBox PM
        public DataTable LayDSDG()
        {
            return docgia_dal.LayDSDG();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(DocGia_DTO dg)
        {
            return docgia_dal.KiemTraTruocKhiLuu(dg);
        }

        //Thêm Độc Giả vào CSDL
        public int ThemDG(DocGia_DTO dg)
        {
            return docgia_dal.ThemDG(dg);
        }

        //Sửa Độc Giả vào CSDL
        public bool SuaDG(DocGia_DTO dg)
        {
            return docgia_dal.SuaDG(dg);
        }

        //Xóa Độc Giả trong CSDL
        public bool XoaDG(string MaDG)
        {
            return docgia_dal.XoaDG(MaDG);
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return docgia_dal.NextID();
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemDG(string DieuKien, string TieuChi)
        {
            return docgia_dal.TimKiemDG(DieuKien, TieuChi);
        }
    }
}

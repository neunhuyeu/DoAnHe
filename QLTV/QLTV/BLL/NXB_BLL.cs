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
    public class NXB_BLL
    {
        NXB_DAL nxb_dal = new NXB_DAL();

        //Hàm lấy tất cả danh sách NXB để hiển thị
        public DataTable LayDanhSachNXB()
        {
            return nxb_dal.LayDanhSachNXB();
        }

        // Lấy danh sách NXB load sang Combobox
        public DataTable LayDSNXB()
        {
            return nxb_dal.LayDSNXB();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NXB_DTO nxb)
        {
            return nxb_dal.KiemTraTruocKhiLuu(nxb);
        }

        //Kiểm tra tồn tại của Mã NXB
        public bool KiemTra(string manxb)
        {
            return nxb_dal.KiemTra(manxb);
        }

        //Thêm Nhà Xuất Bản vào CSDL
        public bool ThemNXB(NXB_DTO nxb)
        {
            return nxb_dal.ThemNXB(nxb);
        }

        //Sửa Nhà Xuất Bản vào CSDL
        public bool SuaNXB(NXB_DTO nxb)
        {
            return nxb_dal.SuaNXB(nxb);
        }

        //Xóa Nhà Xuất Bản trong CSDL
        public bool XoaNXB(string MaNXB)
        {
            return nxb_dal.XoaNXB(MaNXB);
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return nxb_dal.NextID();
        }
    }
}

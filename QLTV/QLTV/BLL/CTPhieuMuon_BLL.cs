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
    public class CTPhieuMuon_BLL
    {
        
        CTPhieuMuon_DAL ctpm_dal = new CTPhieuMuon_DAL();
        //Hàm lấy tất cả danh sách Phiếu mượn để hiển thị
        public DataTable LayDanhSachCTPM()
        {
            return ctpm_dal.LayDanhSachCTPM();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(CTPhieuMuon_DTO ctpm)
        {
            return ctpm_dal.KiemTraTruocKhiLuu(ctpm);
        }

        //Thêm CT Phiếu mượn vào CSDL
        public bool ThemCTPM(CTPhieuMuon_DTO ctpm)
        {
            return ctpm_dal.ThemCTPM(ctpm);
        }

        //Sửa CT Phiếu mượn vào CSDL
        public bool SuaCTPM(CTPhieuMuon_DTO ctpm)
        {
            return ctpm_dal.SuaCTPM(ctpm);
        }

        //Xóa CT Phiếu mượn trong CSDL
        public bool XoaCTPM(string MaPhieu)
        {
            return ctpm_dal.XoaCTPM(MaPhieu);
        }
    }
}

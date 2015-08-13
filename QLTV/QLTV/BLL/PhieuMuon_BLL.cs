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
    public class PhieuMuon_BLL
    {
        PhieuMuon_DAL phieumuon_dal = new PhieuMuon_DAL();

        //Hàm lấy tất cả danh sách Phiếu mượn để hiển thị
        public DataTable LayDanhSachPM()
        {
            return phieumuon_dal.LayDanhSachPM();
        }

        // Lấy danh sách PM cho load sang ComboBox 
        public DataTable LayDSPM()
        {
            return phieumuon_dal.LayDSPM();
        }

        //Lấy danh sách số lượt mượn
        public DataTable LayDSLuotMuon()
        {
            return phieumuon_dal.LayDSLuotMuon();
        }

        //Lấy danh sách số lượt mượn Quá hạn
        public DataTable LayDSMuonQuaHan()
        {
            return phieumuon_dal.LayDSMuonQuaHan();
        }

        //Lấy danh sách sách chưa được mượn
        public DataTable LayDSSachChuaDuocMuon()
        {
            return phieumuon_dal.LayDSSachChuaDuocMuon();
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuMuon_DTO pm)
        {
            return phieumuon_dal.KiemTraTruocKhiLuu(pm);
        }

        public bool KiemTra(string maphieu)
        {
            return phieumuon_dal.KiemTra(maphieu);
        }

        //Thêm Phiếu mượn vào CSDL
        public bool ThemPM(PhieuMuon_DTO pm)
        {
            return phieumuon_dal.ThemPM(pm);
        }

        //Sửa Phiếu mượn vào CSDL
        public bool SuaPM(PhieuMuon_DTO pm)
        {
            return phieumuon_dal.SuaPM(pm);
        }

        //Xóa Phiếu mượn trong CSDL
        public bool XoaPM(string MaPhieu)
        {
            return phieumuon_dal.XoaPM(MaPhieu);
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return phieumuon_dal.NextID();
        }
    }
}

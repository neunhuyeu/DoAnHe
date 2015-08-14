using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class PhieuMuon_DAL
    {
        ConnectDB connect = new ConnectDB();
        //Hàm lấy tất cả danh sách Phiếu mượn để hiển thị
        public DataTable LayDanhSachPM()
        {
            return connect.LoadData("sp_LayDanhSachPM");
        }
        // Lấy danh sách PM cho load sang ComboBox 
        public DataTable LayDSPM()
        {
            return connect.LoadData("sp_LayDSPM");
        }

        //Lấy danh sách số lượt mượn
        public DataTable LayDSLuotMuon()
        {
            return connect.LoadData("sp_LayDSLuotMuon");
        }

        //Lấy danh sách số lượt mượn Quá hạn
        public DataTable LayDSMuonQuaHan()
        {
            return connect.LoadData("sp_LayDSMuonQuaHan");
        }

        //Lấy danh sách sách chưa được mượn
        public DataTable LayDSSachChuaDuocMuon()
        {
            return connect.LoadData("sp_LayDSSachChuaDuocMuon");
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(PhieuMuon_DTO pm)
        {
            if (pm.MaPhieu.Equals(""))
            {
                MessageBox.Show("Mã Phiếu không hợp lệ ! ");
                return false;
            }
            if (pm.NgayMuon.Equals(""))
            {
                MessageBox.Show("Ngày mượn Sách không hợp lệ ! ");
                return false;
            }
            if (pm.MaNV.Equals(""))
            {
                MessageBox.Show("Mã Nhân Viên không hợp lệ ! ");
                return false;
            }
            return true;
        }

        public bool KiemTra(string maphieu)
        {
            if (connect.KiemTraTonTai("CT_PHIEUMUON", "MaPhieu", maphieu))
                return true;
            return false;
        }

        //Thêm Phiếu mượn vào CSDL
        public bool ThemPM(PhieuMuon_DTO pm)
        {
            int param = 4;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = pm.MaPhieu;
            name[1] = "MaDG"; value[1] = pm.MaDG;
            name[2] = "NgayMuon"; value[2] = pm.NgayMuon;
            name[3] = "MaNV"; value[3] = pm.MaNV;
            
            if (KiemTraTruocKhiLuu(pm))
            {
                if (connect.Update("sp_ThemPM", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Phiếu mượn thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Sửa Phiếu mượn vào CSDL
        public bool SuaPM(PhieuMuon_DTO pm)
        {
            int param = 4;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = pm.MaPhieu;
            name[1] = "MaDG"; value[1] = pm.MaDG;
            name[2] = "NgayMuon"; value[2] = pm.NgayMuon;
            name[3] = "MaNV"; value[3] = pm.MaNV;

            if (KiemTraTruocKhiLuu(pm))
            {
                if (connect.Update("sp_SuaPM", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa thông tin Phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Phiếu mượn trong CSDL
        public bool XoaPM(string MaPhieu)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = MaPhieu;

            if (connect.Update("sp_XoaPM", name, value, param) > 0)
            {
                MessageBox.Show("Xóa thông tin Phiếu mượn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("PHIEUMUON", "MaPhieu"), "PM");
        }
    }
}

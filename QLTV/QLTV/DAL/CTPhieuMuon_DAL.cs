using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class CTPhieuMuon_DAL
    {
        ConnectDB connect = new ConnectDB();
        public DataTable LayDanhSachCTPM()
        {
            return connect.LoadData("sp_LayDanhSachCTPM");
        }
        public bool KiemTraTruocKhiLuu(CTPhieuMuon_DTO ctpm)
        {
            if (ctpm.MaPhieu.Equals(""))
            {
                MessageBox.Show("Mã Phiếu không hợp lệ ! ");
                return false;
            }
            if (ctpm.MaSach.Equals(""))
            {
                MessageBox.Show("Mã Sách không hợp lệ ! ");
                return false;
            }
            if (ctpm.HanTra.Equals(""))
            {
                MessageBox.Show("Hạn trả không hợp lệ ! ");
                return false;
            }
            return true;
        }
        //Thêm CT Phiếu mượn vào CSDL
        public int ThemCTPM(CTPhieuMuon_DTO ctpm)
        {
            int param = 3;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "maphieu"; value[0] = ctpm.MaPhieu;
            name[1] = "masach"; value[1] = ctpm.MaSach;
            name[2] = "hantra"; value[2] = ctpm.HanTra;

            return connect.Update("sp_ThemCTPM", name, value, param);
           
        }

        public int SuaCTPM(CTPhieuMuon_DTO ctpm)
        {
            int param = 3;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "maphieu"; value[0] = ctpm.MaPhieu;
            name[1] = "masach"; value[1] = ctpm.MaSach;
            name[2] = "hantra"; value[2] = ctpm.HanTra;
            
            if (KiemTraTruocKhiLuu(ctpm))
            {
                return connect.Update("sp_SuaCTPM", name, value, param);
            }
            return 0;
        }
        //Xóa CT Phiếu mượn trong CSDL
        public int XoaCTPM(string MaPhieu)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "maphieu"; value[0] = MaPhieu;
            return connect.Update("sp_XoaCTPM", name, value, param);
            
        }
    }
}

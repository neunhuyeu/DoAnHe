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
        ConnectDB connData = new ConnectDB();
        public DataTable LayDanhSachCTPM()
        {
            string sql = " SELECT MaPhieu, MaSach, HanTra FROM CT_PHIEUMUON";
            return connData.getdata(sql);
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
        public bool ThemCTPM(CTPhieuMuon_DTO ctpm)
        {
            if (KiemTraTruocKhiLuu(ctpm))
            {
                string sql = string.Format("INSERT INTO CT_PHIEUMUON (MaPhieu, MaSach, HanTra)"
                    + " VALUES ('{0}', '{1}', '{2}')",
                    ctpm.MaPhieu, ctpm.MaSach, ctpm.HanTra);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Chi tiết Phiếu mượn thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool SuaCTPM(CTPhieuMuon_DTO ctpm)
        {
            if (KiemTraTruocKhiLuu(ctpm))
            {
                string sql = string.Format("UPDATE CT_PHIEUMUON SET MaSach='{1}', HanTra='{2}' WHERE MaPhieu='{0}'",
                    ctpm.MaPhieu, ctpm.MaSach, ctpm.HanTra);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Chi tiết Phiếu mượn thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xóa CT Phiếu mượn trong CSDL
        public bool XoaCTPM(string MaPhieu)
        {
            string sql = "DELETE FROM CT_PHIEUMUON WHERE MaPhieu='" + MaPhieu + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Chi tiết Phiếu mượn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}

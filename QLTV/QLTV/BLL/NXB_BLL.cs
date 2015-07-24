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
    class NXB_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách NXB để hiển thị
        public DataTable LayDanhSachNXB()
        {
            string sql = "SELECT MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website FROM NHAXUATBAN";
            return connData.getdata(sql);
        }

        // Lấy danh sách NXB load sang Combobox
        public DataTable LayDSNXB()
        {
            string sql = "SELECT MaNXB, TenNXB FROM NHAXUATBAN";
            return connData.getdata(sql);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(NXB_DTO nxb)
        {
            if (nxb.MaNXB.Equals(""))
            {
                MessageBox.Show("Mã Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            if (nxb.TenNXB.Equals(""))
            {
                MessageBox.Show("Tên Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            if (nxb.DiaChiNXB.Equals(""))
            {
                MessageBox.Show("Địa chỉ Nhà Xuất bản không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã NXB
        public bool KiemTra(string manxb)
        {
            if (connData.KiemTraTonTai("SACH", "MaNXB", manxb))
                return true;
            return false;
        }

        //Thêm Nhà Xuất Bản vào CSDL
        public bool ThemNXB(NXB_DTO nxb)
        {
            if (KiemTraTruocKhiLuu(nxb))
            {
                string sql = string.Format("INSERT INTO NHAXUATBAN (MaNXB, TenNXB, DiaChiNXB, DienThoaiNXB, Website)"
                    + " VALUES ('{0}', N'{1}', N'{2}', N'{3}',N'{4}')", nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Thêm Nhà Xuất Bản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Sửa Nhà Xuất Bản vào CSDL
        public bool SuaNXB(NXB_DTO nxb)
        {
            if (KiemTraTruocKhiLuu(nxb))
            {
                string sql = string.Format("UPDATE NHAXUATBAN SET TenNXB=N'{1}', DiaChiNXB=N'{2}', DienThoaiNXB=N'{3}', Website=N'{4}' WHERE MaNXB=N'{0}'", nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
                if (connData.ThucThiSQL(sql))
                {
                    MessageBox.Show("Sửa Nhà Xuất Bản thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa Nhà Xuất Bản trong CSDL
        public bool XoaNXB(string MaNXB)
        {
            string sql = "DELETE FROM NHAXUATBAN WHERE MaNXB='" + MaNXB + "'";
            if (connData.ThucThiSQL(sql))
            {
                MessageBox.Show("Xóa Nhà Xuất Bản thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("NHAXUATBAN", "MaNXB"), "NXB");
        }
    }
}

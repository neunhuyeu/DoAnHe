using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class NXB_DAL
    {
        ConnectDB connect = new ConnectDB();
        //Hàm lấy tất cả danh sách NXB để hiển thị
        public DataTable LayDanhSachNXB()
        {
            return connect.LoadData("sp_LayDanhSachNXB");
        }
        // Lấy danh sách NXB load sang Combobox
        public DataTable LayDSNXB()
        {
            return connect.LoadData("sp_LayDSNXB");
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
            if (connect.KiemTraTonTai("SACH", "MaNXB", manxb))
                return true;
            return false;
        }
        //Thêm Nhà Xuất Bản vào CSDL
        public bool ThemNXB(NXB_DTO nxb)
        {
            int param = 5;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNXB"; value[0] = nxb.MaNXB;
            name[1] = "TenNXB"; value[1] = nxb.TenNXB;
            name[2] = "DiaChiNXB"; value[2] = nxb.DiaChiNXB;
            name[3] = "DienThoaiNXB"; value[3] = nxb.DienThoaiNXB;
            name[4] = "Website"; value[4] = nxb.Website;
            if (KiemTraTruocKhiLuu(nxb))
            {
                if (connect.Update("sp_ThemNXB", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Nhà Xuất Bản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Sửa Nhà Xuất Bản vào CSDL
        public bool SuaNXB(NXB_DTO nxb)
        {
            int param = 5;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNXB"; value[0] = nxb.MaNXB;
            name[1] = "TenNXB"; value[1] = nxb.TenNXB;
            name[2] = "DiaChiNXB"; value[2] = nxb.DiaChiNXB;
            name[3] = "DienThoaiNXB"; value[3] = nxb.DienThoaiNXB;
            name[4] = "Website"; value[4] = nxb.Website;

            if (KiemTraTruocKhiLuu(nxb))
            {
                if (connect.Update("sp_SuaNXB", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa Nhà Xuất Bản thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Xóa Nhà Xuất Bản trong CSDL
        public bool XoaNXB(string MaNXB)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaNXB"; value[0] = MaNXB;

            if (connect.Update("sp_XoaNXB", name, value, param) > 0)
            {
                MessageBox.Show("Xóa Nhà Xuất Bản thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("NHAXUATBAN", "MaNXB"), "NXB");
        }
    }
}

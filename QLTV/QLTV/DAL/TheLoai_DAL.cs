using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class TheLoai_DAL
    {
        ConnectDB connect = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTheLoai()
        {
            return connect.LoadData("sp_LayDanhSachTheLoai");
        }

        // Lấy danh sách TL cho load sang ComboBox Sach
        public DataTable LayDSTL()
        {
            return connect.LoadData("sp_LayDSTL");
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TheLoai_DTO tl)
        {
            if (tl.TenTL.Equals(""))
            {
                MessageBox.Show("Tên Thể Loại không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra tồn tại của Mã sách
        public bool KiemTra(string matl)
        {
            if (connect.KiemTraTonTai("SACH", "MaTL", matl))
                return true;
            return false;
        }

        //Thêm Thể loại vào CSDL
        public bool ThemTL(TheLoai_DTO tl)
        {
            int param = 3;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTL"; value[0] = tl.MaTL;
            name[1] = "TenTL"; value[1] = tl.TenTL;
            name[2] = "GhiChu"; value[2] = tl.GhiChu;

            if (KiemTraTruocKhiLuu(tl))
            {
                if (connect.Update("sp_ThemTL", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }


        //Sửa Thể Loại vào CSDL
        public bool SuaTL(TheLoai_DTO tl)
        {
            int param = 3;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTL"; value[0] = tl.MaTL;
            name[1] = "TenTL"; value[1] = tl.TenTL;
            name[2] = "GhiChu"; value[2] = tl.GhiChu;

            if (KiemTraTruocKhiLuu(tl))
            {
                if (connect.Update("sp_SuaTL", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa Thể Loại thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Xóa Thể loại trong CSDL
        public bool XoaTL(string MaTL)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTL"; value[0] = MaTL;

            if (connect.Update("sp_XoaTL", name, value, param) > 0)
            {
                MessageBox.Show("Xóa Thể Loại thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("THELOAI", "MaTL"), "TL");
        }
    }
}

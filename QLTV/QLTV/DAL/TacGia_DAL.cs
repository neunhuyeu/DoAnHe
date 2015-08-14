using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class TacGia_DAL
    {
        ConnectDB connect = new ConnectDB();

        //Hàm lấy tất cả danh sách Thể loại để hiển thị
        public DataTable LayDanhSachTacGia()
        {
            return connect.LoadData("sp_LayDanhSachTacGia");
        }

        // Lấy danh sách Tác Giả
        public DataTable LayDSTG()
        {
            return connect.LoadData("sp_LayDSTG");
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TacGia_DTO tg)
        {
            if (tg.MaTG.Equals(""))
            {
                MessageBox.Show("Mã Tác Giả không hợp lệ ! ");
                return false;
            }
            if (tg.HoTenTG.Equals(""))
            {
                MessageBox.Show("Tên Tác giả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Kiểm tra sự tồn tại của Mã TG trong bảng sách
        public bool KiemTra(string matg)
        {
            if (connect.KiemTraTonTai("SACH", "MaTG", matg))
                return true;
            return false;
        }

        //Thêm Tác Giả vào CSDL
        public bool ThemTG(TacGia_DTO tg)
        {
            int param = 4;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTG"; value[0] = tg.MaTG;
            name[1] = "HoTenTG"; value[1] = tg.HoTenTG;
            name[2] = "DiaChiTG"; value[2] = tg.DiaChiTG;
            name[3] = "DienThoaiTG"; value[3] = tg.DienThoaiTG;

            if (KiemTraTruocKhiLuu(tg))
            {
                if (connect.Update("sp_ThemTG", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Tác Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }


        //Sửa Tác Giả vào CSDL
        public bool SuaTG(TacGia_DTO tg)
        {
            int param = 4;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTG"; value[0] = tg.MaTG;
            name[1] = "HoTenTG"; value[1] = tg.HoTenTG;
            name[2] = "DiaChiTG"; value[2] = tg.DiaChiTG;
            name[3] = "DienThoaiTG"; value[3] = tg.DienThoaiTG;

            if (KiemTraTruocKhiLuu(tg))
            {
                if (connect.Update("sp_SuaTG", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa Tác Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Xóa Tác Giả trong CSDL
        public bool XoaTG(string MaTG)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaTG"; value[0] = MaTG;

            if (connect.Update("sp_XoaTG", name, value, param) > 0)
            {
                MessageBox.Show("Xóa Tác Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã TG kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("TACGIA", "MaTG"), "TG");
        }
    }
}

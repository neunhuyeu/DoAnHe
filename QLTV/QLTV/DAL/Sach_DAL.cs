using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class Sach_DAL
    {
        ConnectDB connect = new ConnectDB();

        //Hàm lấy tất cả danh sách Sách để hiển thị
        public DataTable LayDanhSachSach()
        {
            return connect.LoadData("sp_LayDanhSachSach");
        }

        //Hàm lấy tất cả danh sách Sách để hiển thị cho Reports
        public DataTable LayDSSReport()
        {
            return connect.LoadData("sp_LayDSSReport");
        }

        // Lấy danh sách Sách load lên Combobox
        public DataTable LayDSSach()
        {
            return connect.LoadData("sp_LayDSSach");
        }

        // Lấy danh sách Sách theo PM
        public DataTable LayDSSachTheoPM(string MaPhieu)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = MaPhieu;

            return connect.LoadData("sp_LayDSSachTheoPM", name, value, param);
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(Sach_DTO s)
        {
            if (s.TenSach.Equals(""))
            {
                MessageBox.Show("Tên Sách không hợp lệ ! ");
                return false;
            }
            if (s.NgayNhap.Equals(""))
            {
                MessageBox.Show("Ngày nhập Sách không hợp lệ ! ");
                return false;
            }
            if (s.MaNXB.Equals(""))
            {
                MessageBox.Show("Mã Nhà xuất bản không hợp lệ ! ");
                return false;
            }
            if (s.MaTG.Equals(""))
            {
                MessageBox.Show("Mã Tác Giả không hợp lệ ! ");
                return false;
            }
            if (s.MaTL.Equals(""))
            {
                MessageBox.Show("Mã Thể loại không hợp lệ ! ");
                return false;
            }
            if (s.TinhTrang.Equals(""))
            {
                MessageBox.Show("Tình trạng không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Sách vào CSDL
        public bool ThemSach(Sach_DTO s)
        {
            int param = 11;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaSach"; value[0] = s.MaSach;
            name[1] = "TenSach"; value[1] = s.TenSach;
            name[2] = "NoiDungTT"; value[2] = s.NoiDungTT;
            name[3] = "SoTrang"; value[3] = s.SoTrang;
            name[4] = "Gia"; value[4] = s.Gia;
            name[5] = "SoLuong"; value[5] = s.SoLuong;
            name[6] = "NgayNhap"; value[6] = s.NgayNhap;
            name[7] = "MaNXB"; value[7] = s.MaNXB;
            name[8] = "MaTG"; value[8] = s.MaTG;
            name[9] = "MaTL"; value[9] = s.MaTL;
            name[10] = "TinhTrang"; value[10] = s.TinhTrang;

            if (KiemTraTruocKhiLuu(s))
            {
                if (connect.Update("sp_ThemSach", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Sách thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Sửa Sách vào CSDL
        public bool SuaSach(Sach_DTO s)
        {
            int param = 11;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaSach"; value[0] = s.MaSach;
            name[1] = "TenSach"; value[1] = s.TenSach;
            name[2] = "NoiDungTT"; value[2] = s.NoiDungTT;
            name[3] = "SoTrang"; value[3] = s.SoTrang;
            name[4] = "Gia"; value[4] = s.Gia;
            name[5] = "SoLuong"; value[5] = s.SoLuong;
            name[6] = "NgayNhap"; value[6] = s.NgayNhap;
            name[7] = "MaNXB"; value[7] = s.MaNXB;
            name[8] = "MaTG"; value[8] = s.MaTG;
            name[9] = "MaTL"; value[9] = s.MaTL;
            name[10] = "TinhTrang"; value[10] = s.TinhTrang;
            if (KiemTraTruocKhiLuu(s))
            {
                if (connect.Update("sp_ThemSach", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa thông tin Sách thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Xóa Sách trong CSDL
        public bool XoaSach(string MaSach)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaSach"; value[0] = MaSach;

            if (connect.Update("sp_XoaSach", name, value, param) > 0)
            {
                MessageBox.Show("Xóa thông tin Sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("SACH", "MaSach"), "MS");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemSach(string DieuKien, string TieuChi)
        {
            int param = 2;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "DieuKien"; value[0] = DieuKien;
            name[1] = "TieuChi"; value[1] = TieuChi;
            return connect.LoadData("sp_TimKiemSach", name, value, param);
        }
    }
}

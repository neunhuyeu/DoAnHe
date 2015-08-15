using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class TraSach_DAL
    {
        ConnectDB connect = new ConnectDB();

        //Hàm lấy tất cả danh sách trả sách
        public DataTable LayDanhSachTRASACH()
        {
            return connect.LoadData("sp_LayDanhSachTRASACH");
        }

        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(TraSach_DTO ts)
        {
            if (ts.MaSach.Equals(""))
            {
                MessageBox.Show("Mã Sách không hợp lệ ! ");
                return false;
            }
            if (ts.MaNV.Equals(""))
            {
                MessageBox.Show("Nhân Viên không hợp lệ ! ");
                return false;
            }
            if (ts.NgayTra.Equals(""))
            {
                MessageBox.Show("Ngày Trả không hợp lệ ! ");
                return false;
            }
            return true;
        }

        //Thêm Phiếu trả vào CSDL
        public bool ThemPT(TraSach_DTO ts)
        {
            int param = 6;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = ts.MaPhieu;
            name[1] = "MaSach"; value[1] = ts.MaSach;
            name[2] = "MaNV"; value[2] = ts.MaNV;
            name[3] = "NgayTra"; value[3] = ts.NgayTra;
            name[4] = "PhatHuHong"; value[4] = ts.PhatHuHong;
            name[5] = "PhatQuaHan"; value[5] = ts.PhatQuaHan;

            if (KiemTraTruocKhiLuu(ts))
            {
                if (connect.Update("sp_ThemPT", name, value, param) > 0)
                {
                    MessageBox.Show("Thêm Phiếu Trả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }


        //Sửa Phiếu Trả vào CSDL
        public bool SuaPT(TraSach_DTO ts)
        {
            int param = 6;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaPhieu"; value[0] = ts.MaPhieu;
            name[1] = "MaSach"; value[1] = ts.MaSach;
            name[2] = "MaNV"; value[2] = ts.MaNV;
            name[3] = "NgayTra"; value[3] = ts.NgayTra;
            name[4] = "PhatHuHong"; value[4] = ts.PhatHuHong;
            name[5] = "PhatQuaHan"; value[5] = ts.PhatQuaHan;

            if (KiemTraTruocKhiLuu(ts))
            {
                if (connect.Update("sp_SuaPT", name, value, param) > 0)
                {
                    MessageBox.Show("Sửa Phiếu trả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }

        //Xóa Phiếu trả trong CSDL
        public bool XoaPT(string MaSach)
        {
            int param = 6;
            string[] name = new string[param];
            object[] value = new object[param];
            name[0] = "MaSach"; value[0] = MaSach;
            
            if (connect.Update("sp_SuaPT", name, value, param) > 0)
            {
                MessageBox.Show("Xóa Phiếu trả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}

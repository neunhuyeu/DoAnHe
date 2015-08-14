using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.DAL
{
    public class DocGia_DAL
    {
        ConnectDB connect = new ConnectDB();
        //Hàm lấy tất cả danh sách Độc giả để hiển thị
        public DataTable LayDanhSachDocGia()
        {
            return connect.LoadData("sp_LayDanhSachDocGia");
        }
        //Lấy Danh sách Độc giả load sang Reports Độc giả
        public DataTable Laydsdocgia()
        {
            return connect.LoadData("sp_Laydsdocgia");
        }
        // Lấy danh sách DG cho load sang ComboBox PM
        public DataTable LayDSDG()
        {
            return connect.LoadData("sp_LayDSDG");
        }
        
        //Kiểm tra trước khi lưu
        public bool KiemTraTruocKhiLuu(DocGia_DTO dg)
        {
            if (dg.HoTenDG.Equals(""))
            {
                MessageBox.Show("Tên Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgaySinhDG.Equals(""))
            {
                MessageBox.Show("Ngày Sinh Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayLamThe.Equals(""))
            {
                MessageBox.Show("Ngày Làm thẻ Độc Giả không hợp lệ ! ");
                return false;
            }
            if (dg.NgayHetHan.Equals(""))
            {
                MessageBox.Show("Ngày Hết hạn thẻ không hợp lệ ! ");
                return false;
            }
            return true;
        }
        //Thêm Độc Giả vào CSDL
        public bool ThemDG(DocGia_DTO dg)
        {
            int param = 10;
            string[] name = new string[param];
            object[] value = new object[param];
            
            name[0] = "MaDG"; value[0] = dg.MaDG;
            name[1] = "HoTenDG"; value[1] = dg.HoTenDG;
            name[2] = "EmailDG"; value[2] = dg.EmailDG;
            name[3] = "GioiTinhDG"; value[3] = dg.GioiTinhDG;
            name[4] = "NgaySinhDG"; value[4] = dg.NgaySinhDG;
            name[5] = "DiaChiDG"; value[5] = dg.DiaChiDG;
            name[6] = "DienThoaiDG"; value[6] = dg.DienThoaiDG;
            name[7] = "NgayLamThe"; value[7] = dg.NgayLamThe;
            name[8] = "NgayHetHan"; value[8] = dg.NgayHetHan;
            name[9] = "HoatDong"; value[9] = dg.HoatDong;
            if (KiemTraTruocKhiLuu(dg))
            {
                if (connect.Update("sp_ThemDG", name, value, param)>0)
                {
                    MessageBox.Show("Thêm Độc Giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Sửa Độc Giả vào CSDL
        public bool SuaDG(DocGia_DTO dg)
        {
            int param = 10;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaDG"; value[0] = dg.MaDG;
            name[1] = "HoTenDG"; value[1] = dg.HoTenDG;
            name[2] = "EmailDG"; value[2] = dg.EmailDG;
            name[3] = "GioiTinhDG"; value[3] = dg.GioiTinhDG;
            name[4] = "NgaySinhDG"; value[4] = dg.NgaySinhDG;
            name[5] = "DiaChiDG"; value[5] = dg.DiaChiDG;
            name[6] = "DienThoaiDG"; value[6] = dg.DienThoaiDG;
            name[7] = "NgayLamThe"; value[7] = dg.NgayLamThe;
            name[8] = "NgayHetHan"; value[8] = dg.NgayHetHan;
            name[9] = "HoatDong"; value[9] = dg.HoatDong;
            if (KiemTraTruocKhiLuu(dg))
            {
                if (connect.Update("sp_SuaDG", name, value, param)>0)
                {
                    MessageBox.Show("Sửa Độc Giả thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            return false;
        }
        //Xóa Độc Giả trong CSDL
        public bool XoaDG(string MaDG)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "MaDG"; value[0] = MaDG;
            
            if (connect.Update("sp_XoaDG", name, value, param)>0)
            {
                MessageBox.Show("Xóa Độc Giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connect.GetLastID("DOCGIA", "MaDG"), "DG");
        }

        //Tim kiem sach theo Tieu Chi
        public DataTable TimKiemDG(string DieuKien, string TieuChi)
        {
            return connect.LoadData("sp_TimKiemDG");
        }
    }
}

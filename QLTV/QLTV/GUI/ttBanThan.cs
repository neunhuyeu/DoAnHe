using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.GUI
{
    public partial class ttBanThan : UserControl
    {
        NhanVien_BLL nvBUS = new NhanVien_BLL();
        public ttBanThan()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            Utilities.user= nvBUS.LayThongTinBanThan(Utilities.user.MaNV);
            txtMaNV.Text = Utilities.user.MaNV;
            txtHoTenNV.Text = Utilities.user.HoTenNV;
            if (Convert.ToString(Utilities.user.GioiTinhNV) == "0")
            {
                txtGioiTinh.Text = "Nam";
            }
            else txtGioiTinh.Text = "Nữ";
            dateNgaySinh.Text = Convert.ToString(Utilities.user.NgaySinhNV);
            txtSdt.Text = Utilities.user.DienThoaiNV;
            txtDiaChi.Text = Utilities.user.DiaChiNV;
            txtEmail.Text = Utilities.user.EmailNV;
            dateNgayVaoLam.Text = Convert.ToString(Utilities.user.NgayVaoLam);
            if (Convert.ToString(Utilities.user.QuyenHan)=="0")
            {
                txtQuyenHan.Text = "Quản Lý";
            }
            else txtQuyenHan.Text = "Nhân Viên";           
        }

    }
}

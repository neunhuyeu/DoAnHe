using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;

namespace QLTV.GUI
{
    public partial class cnMatKhau : UserControl
    {
        NhanVien_BLL nvBUS = new NhanVien_BLL();

        //Reset textbox
        public void cleantxt()
        {
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtReNewPass.Text = "";
        }
        public cnMatKhau()
        {
            InitializeComponent();
        }

        private void cnMatKhau_Load(object sender, EventArgs e)
        {
            txtOldPass.Focus();
        }

        //Kiểm tra Mật khẩu
        public bool KiemTra()
        {
            Cont:
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string reNewPass = txtReNewPass.Text;
            //Kiểm tra thông tin nhập trên Form đày đủ chưa
            if (oldPass == "" || newPass == "" || reNewPass == "")
            {
                lblThongBao.Text = "Bạn chưa điền đầy đủ các thông tin !";
                return false;
                goto Cont;
            }
            if (newPass != reNewPass)
            {
                lblThongBao.Text = "Mật khẩu mới không khớp nhau !";
                return false;
                goto Cont;
            }

            //Kiểm tra mật khẩu cũ có khớp không
            if (Utilities.user.MatKhau != oldPass)
            {
                lblThongBao.Text = "Mật khẩu cũ không đúng !";
                return false;
                goto Cont;
            }
            return true;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                nvBUS.DoiMatKhau(txtNewPass.Text);
                MessageBox.Show("Đổi mật khẩu thành công !");
                lblThongBao.Text = "Đã đổi mật khẩu thành công !";
                cleantxt();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cleantxt();
        }
    }
}

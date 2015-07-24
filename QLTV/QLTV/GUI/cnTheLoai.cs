using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.Use_Control
{
    public partial class cnTheLoai : UserControl
    {
        private TheLoai_BLL tlBUS=new TheLoai_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTL.Text = "";
            txtGhiChu.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", dgvTheLoai.DataSource, "MaTL");
            txtTenTL.DataBindings.Clear();
            txtTenTL.DataBindings.Add("Text", dgvTheLoai.DataSource, "TenTL");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvTheLoai.DataSource, "GhiChu");
        }

        //Lấy Thông tin Thể loại
        private TheLoai_DTO LayTTTL()
        {
            TheLoai_DTO tl = new TheLoai_DTO();
            tl.MaTL = txtMaTL.Text;
            tl.TenTL = txtTenTL.Text;
            tl.GhiChu = txtGhiChu.Text;
            return tl;
        }

        public cnTheLoai()
        {
            InitializeComponent();
        }

        private void cnTheLoai_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvTheLoai.DataSource = tlBUS.LayDanhSachTheLoai();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaTL.Text = tlBUS.NextID();
            cleantxt();
            txtMaTL.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtMaTL.Enabled = false;
            txtTenTL.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Thể loại: " + txtTenTL.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tlBUS.KiemTra(txtMaTL.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại sách có mã TG '"+txtMaTL.Text+"' trong bảng Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tlBUS.XoaTL(txtMaTL.Text);
                    cnTheLoai_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TheLoai_DTO tl = LayTTTL();
            if (update)
            {
                tlBUS.SuaTL(tl);
                cnTheLoai_Load(sender, e);
            }
            if (add)
            {
                tlBUS.ThemTL(tl);
                cnTheLoai_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnTheLoai_Load(sender, e);
        }
    }
}

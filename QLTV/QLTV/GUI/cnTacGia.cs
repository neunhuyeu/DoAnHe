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
    public partial class cnTacGia : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTG.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", dgvTacGia.DataSource, "MaTG");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", dgvTacGia.DataSource, "HoTenTG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvTacGia.DataSource, "DiaChiTG");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvTacGia.DataSource, "DienThoaiTG");
        }

        //Lấy Thông tin Tác Giả
        private TacGia_DTO LayTTTG()
        {
            TacGia_DTO tg = new TacGia_DTO();
            tg.MaTG = txtMaTG.Text;
            tg.HoTenTG = txtTenTG.Text;
            tg.DiaChiTG = txtDiaChi.Text;
            tg.DienThoaiTG = txtSdt.Text;
            return tg;
        }

        public cnTacGia()
        {
            InitializeComponent();
        }

        private void cnTacGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvTacGia.DataSource = tgBUS.LayDanhSachTacGia();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaTG.Text = tgBUS.NextID();
            cleantxt();
            txtTenTG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtMaTG.Enabled = false;
            txtTenTG.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Tác Giả: " + txtTenTG.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tgBUS.KiemTra(txtMaTG.Text))
                {
                    MessageBox.Show("Bạn phải xóa những loại sách có mã TG '" + txtMaTG.Text + "' trong bảng Sách trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tgBUS.XoaTG(txtMaTG.Text);
                    cnTacGia_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TacGia_DTO tg = LayTTTG();
            if (add)
            {
                tgBUS.ThemTG(tg);
                cnTacGia_Load(sender, e);
            }
            if (update)
                tgBUS.SuaTG(tg);
            cnTacGia_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnTacGia_Load(sender, e);
        }
    }
}

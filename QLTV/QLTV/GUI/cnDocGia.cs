using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.Use_Control
{
    public partial class cnDocGia : UserControl
    {

        private DocGia_BLL dgBUS = new DocGia_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        private void cleantxt()
        {
            txtTenDG.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            dateEdit1.Text = "";
            dateEdit3.Text = "";
            dateEdit2.Text = "";
        }

        private void binding()
        {
            txtMaDG.DataBindings.Clear();
            txtMaDG.DataBindings.Add("Text", dgvDocGia.DataSource, "MaDG");
            txtTenDG.DataBindings.Clear();
            txtTenDG.DataBindings.Add("Text", dgvDocGia.DataSource, "HoTenDG");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDocGia.DataSource, "EmailDG");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text",dgvDocGia.DataSource,"GioiTinhDG");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text",dgvDocGia.DataSource,"NgaySinhDG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text",dgvDocGia.DataSource,"DiaChiDG");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text",dgvDocGia.DataSource,"DienThoaiDG");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text",dgvDocGia.DataSource,"NgayLamThe");
            dateEdit3.DataBindings.Clear();
            dateEdit3.DataBindings.Add("Text", dgvDocGia.DataSource, "NgayHetHan");
            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("Text",dgvDocGia.DataSource,"HoatDong");
        }

        //Lấy Thông tin Độc giả
        private DocGia_DTO LayTTDG()
        {
            DocGia_DTO dg = new DocGia_DTO();
            dg.MaDG = txtMaDG.Text;
            dg.HoTenDG = txtTenDG.Text;
            dg.EmailDG = txtEmail.Text;
            dg.GioiTinhDG = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            dg.NgaySinhDG = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            dg.DiaChiDG = txtDiaChi.Text;
            dg.DienThoaiDG = txtSdt.Text;
            dg.NgayLamThe = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            dg.NgayHetHan = Convert.ToDateTime(dateEdit3.EditValue.ToString());
            dg.HoatDong = (cboTinhTrang.Text == "Đang Hoạt Động") ? 1 : 0;
            return dg;
        }

        public cnDocGia()
        {
            InitializeComponent();
        }

        private void cnDocGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvDocGia.DataSource = dgBUS.LayDanhSachDocGia();
            groupControl1.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl1.Enabled = true;
            // Load NextID len textbox MaSV
            txtMaDG.Text = dgBUS.NextID();
            cleantxt();
            txtTenDG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl1.Enabled = true;
            txtTenDG.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Độc Giả: " + txtTenDG.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgBUS.XoaDG(txtMaDG.Text);
                cnDocGia_Load(sender, e);
            }
        }

        private void btnLuulai_Click(object sender, EventArgs e)
        {
            DocGia_DTO tg = LayTTDG();
            if (add)
            {
                dgBUS.ThemDG(tg);
                cnDocGia_Load(sender, e);
            }
            if (update)
                dgBUS.SuaDG(tg);
                cnDocGia_Load(sender, e);        
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            cnDocGia_Load(sender, e);   
        }
    }
}

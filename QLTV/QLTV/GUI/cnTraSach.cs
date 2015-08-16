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

namespace QLTV.GUI
{
    public partial class cnTraSach : UserControl
    {
        private TraSach_BLL ptBUS = new TraSach_BLL();
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        private Sach_BLL sBUS = new Sach_BLL();
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private bool add = false, update = false; 

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            cboMaPhieu.Text = "";
            cboMaNV.Text = "";
            cboMaSach.Text = "";
            txtPhatHong.Text = "";
            txtPhatQH.Text = "";
        }

        //Binding Dữ liệu lên textbox tương ứng
        public void binding()
        {
            cboMaPhieu.DataBindings.Clear();
            cboMaPhieu.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaPhieu");
            cboMaSach.DataBindings.Clear();
            cboMaSach.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaSach");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaNV");
            dateNgayTra.DataBindings.Clear();
            dateNgayTra.DataBindings.Add("Text", dgvTraSach.DataSource, "NgayTra");
            txtPhatHong.DataBindings.Clear();
            txtPhatHong.DataBindings.Add("Text", dgvTraSach.DataSource, "PhatHuHong");
            txtPhatQH.DataBindings.Clear();
            txtPhatQH.DataBindings.Add("Text", dgvTraSach.DataSource, "PhatQuaHan");
        }

        //Lấy Thông tin Trả Sách
        private TraSach_DTO LayTTTS()
        {
            TraSach_DTO ts = new TraSach_DTO();
            ts.MaPhieu = cboMaPhieu.EditValue.ToString();
            ts.MaNV = cboMaNV.EditValue.ToString();
            ts.MaSach = cboMaSach.EditValue.ToString();
            ts.NgayTra = Convert.ToDateTime(dateNgayTra.EditValue.ToString());  
            ts.PhatHuHong = Convert.ToInt32(txtPhatHong.Text);
            ts.PhatQuaHan = Convert.ToInt32(txtPhatQH.Text);
            return ts;
        }

        public cnTraSach()
        {
            InitializeComponent();
        }

        private void cnTraSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã Phiếu
            cboMaPhieu.Properties.DataSource = pmBUS.LayDSPM();
            cboMaPhieu.Properties.DisplayMember = "MaPhieu";
            cboMaPhieu.Properties.ValueMember = "MaPhieu";

            // Load combobox Mã NV
            cboMaNV.Properties.DataSource = nvBUS.LayDSNV();
            cboMaNV.Properties.DisplayMember = "HoTenNV";
            cboMaNV.Properties.ValueMember = "MaNV";

            //Load DataGrid
            dgvTraSach.DataSource = ptBUS.LayDanhSachTRASACH();
            groupControl2.Enabled = false;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            add = true; update = false;
            groupControl2.Enabled = true;
            cboMaPhieu.Enabled = true;
            cleantxt();
            cboMaPhieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            update = true; add = false;
            groupControl2.Enabled = true;
            cboMaPhieu.Enabled = false;
            cboMaSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Phiếu trả với loại Sách Mượn: " + cboMaSach.EditValue.ToString() + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ptBUS.XoaPT(cboMaSach.EditValue.ToString());
                cnTraSach_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TraSach_DTO ts = LayTTTS();
            if (add)
            {
                ptBUS.ThemPT(ts);
                cnTraSach_Load(sender, e);
            }
            if (update)
                ptBUS.SuaPT(ts);
            cnTraSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cnTraSach_Load(sender, e);
        }

        private void cboMaPhieu_TextChanged(object sender, EventArgs e)
        {
            //Load combobox Mã Sách Trả
            cboMaSach.Properties.DataSource = sBUS.LayDSSachTheoPM(cboMaPhieu.EditValue.ToString());
            cboMaSach.Properties.DisplayMember = "MaSach";
            cboMaSach.Properties.ValueMember = "MaSach";
        }

        //Chỉ cho phép nhập số vào 
        private void txtPhatHong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhatQH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhatQH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu_Click(sender, e);
        }

        private void txtPhatHong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu_Click(sender, e);
        }
    }
}

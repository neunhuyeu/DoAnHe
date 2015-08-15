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

namespace QLTV.Use_Control
{
    public partial class MuonSach : UserControl
    {
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        private DocGia_BLL dgBUS = new DocGia_BLL(); 
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private Sach_BLL sBUS = new Sach_BLL();
        private CTPhieuMuon_BLL ctpmBUS = new CTPhieuMuon_BLL();
        private bool addpm = false, updatepm = false, addctpm=false, updatectpm=false;

        private void cleantxtPM()
        {
            cboMaDG.Text = "";
            dateEdit1.Text = "";
            cboMaNV.Text = "";
        }
        private void cleantxtCTPM()
        {
            cboMaPhieu.Text = "";
            cboSach.Text = "";
            dateEdit2.Text = "";
        }

        private void bindingPM()
        {
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dgvPhieuMuon.DataSource, "MaPhieu");
            cboMaDG.DataBindings.Clear();
            cboMaDG.DataBindings.Add("EditValue", dgvPhieuMuon.DataSource, "MaDG");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvPhieuMuon.DataSource, "NgayMuon");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("EditValue", dgvPhieuMuon.DataSource, "MaNV");
        }
        private void bindingCTPM()
        {
            cboMaPhieu.DataBindings.Clear();
            cboMaPhieu.DataBindings.Add("EditValue", dgvCTPhieuMuon.DataSource, "MaPhieu");
            cboSach.DataBindings.Clear();
            cboSach.DataBindings.Add("EditValue", dgvCTPhieuMuon.DataSource, "MaSach");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text", dgvCTPhieuMuon.DataSource, "HanTra");
        }

        //Lấy Thông tin Phieu Muon
        private PhieuMuon_DTO LayTTPM()
        {
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            pm.MaPhieu = txtMaPhieu.Text; 
            pm.MaDG = cboMaDG.EditValue.ToString();
            pm.NgayMuon = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            pm.MaNV = cboMaNV.EditValue.ToString();
            return pm;
        }
        private CTPhieuMuon_DTO LayTTCTPM()
        {
            CTPhieuMuon_DTO ctpm = new CTPhieuMuon_DTO();
            ctpm.MaPhieu = cboMaPhieu.EditValue.ToString();
            ctpm.MaSach = cboSach.EditValue.ToString();
            ctpm.HanTra = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            return ctpm;
        }

        public MuonSach()
        {
            InitializeComponent();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã NXB
            cboMaDG.Properties.DataSource = dgBUS.LayDSDG();
            cboMaDG.Properties.DisplayMember = "HoTenDG";
            cboMaDG.Properties.ValueMember = "MaDG";

            // Load combobox Mã TG
            cboMaNV.Properties.DataSource = nvBUS.LayDSNV();
            cboMaNV.Properties.DisplayMember = "HoTenNV";
            cboMaNV.Properties.ValueMember = "MaNV";

            //Load ComboBox Mã Phiếu
            cboMaPhieu.Properties.DataSource = pmBUS.LayDSPM();
            cboMaPhieu.Properties.DisplayMember = "MaPhieu";
            cboMaPhieu.Properties.ValueMember = "MaPhieu";

            //Load ComboBox Mã Sách
            cboSach.Properties.DataSource = sBUS.LayDSSach();
            cboSach.Properties.DisplayMember = "TenSach";
            cboSach.Properties.ValueMember = "MaSach";

            //Load DataGrid
            dgvPhieuMuon.DataSource = pmBUS.LayDanhSachPM();
            dgvCTPhieuMuon.DataSource = ctpmBUS.LayDanhSachCTPM();
            groupControl2.Enabled = false;
            groupControl4.Enabled = false;
            bindingPM();
            bindingCTPM();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addpm = true;
            groupControl2.Enabled = true;
            // Load NextID len textbox MaPM
            txtMaPhieu.Text = pmBUS.NextID();
            cleantxtPM();
            cboMaDG.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updatepm = true;
            groupControl2.Enabled = true;
            cboMaDG.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTPhieuMuon_DTO ctpm = LayTTCTPM();
            if (MessageBox.Show("Bạn có muốn xóa Phiếu mượn : " + txtMaPhieu.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pmBUS.KiemTra(txtMaPhieu.Text))
                {
                    MessageBox.Show("Bạn phải xóa thông tin trong bảng Chi Tiết Phiếu Mượn trước !", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                pmBUS.XoaPM(txtMaPhieu.Text);
                MuonSach_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuMuon_DTO pm = LayTTPM();
            if (addpm)
            {
                pmBUS.ThemPM(pm);
                MuonSach_Load(sender, e);
            }
            if (updatepm)
                pmBUS.SuaPM(pm);
            MuonSach_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MuonSach_Load(sender, e);
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            addctpm = true;
            groupControl4.Enabled = true;
            // Load NextID len textbox MaPM
            cleantxtPM();
            cboMaPhieu.Focus();
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            updatepm = true;
            groupControl4.Enabled = true;
            cboMaPhieu.Enabled = false;
            cboSach.Focus();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Chi tiết Phiếu mượn : " + txtMaPhieu.Text + " không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctpmBUS.XoaCTPM(txtMaPhieu.Text);
                MuonSach_Load(sender, e);
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            CTPhieuMuon_DTO ctpm = LayTTCTPM();
            if (addctpm)
            {
                ctpmBUS.ThemCTPM(ctpm);
                MuonSach_Load(sender, e);
            }
            if (updatectpm)
                ctpmBUS.SuaCTPM(ctpm);
            MuonSach_Load(sender, e);
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            MuonSach_Load(sender, e);
        }
    }
}

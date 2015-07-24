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
    public partial class ttNhanVien : UserControl
    {
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        public ttNhanVien()
        {
            InitializeComponent();
        }

        private void ttNhanVien_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvttNhanVien.DataSource = nvBUS.XemDanhSachNhanVien();    
        }
    }
}

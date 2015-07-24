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
    public partial class ttDocGia : UserControl
    {
        private DocGia_BLL dgBUS = new DocGia_BLL();
        public ttDocGia()
        {
            InitializeComponent();
        }

        private void ttDocGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvDocGia.DataSource = dgBUS.LayDanhSachDocGia();
        }
    }
}

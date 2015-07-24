using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.DTO;
using QLTV.BLL;

namespace QLTV.Use_Control
{
    public partial class ttSach : UserControl
    {
        private Sach_BLL sBUS = new Sach_BLL();
        public ttSach()
        {
            InitializeComponent();
        }

        private void ttSach_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvSach.DataSource = sBUS.LayDanhSachSach();
        }
    }
}

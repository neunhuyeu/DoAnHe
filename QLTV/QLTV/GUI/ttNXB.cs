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
    public partial class ttNXB : UserControl
    {
        private NXB_BLL nxbBUS = new NXB_BLL();
        public ttNXB()
        {
            InitializeComponent();
        }

        private void ttNXB_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvNXB.DataSource = nxbBUS.LayDanhSachNXB();
        }
    }
}

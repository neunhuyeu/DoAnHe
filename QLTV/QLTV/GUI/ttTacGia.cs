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
    public partial class ttTacGia : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        public ttTacGia()
        {
            InitializeComponent();
        }

        private void ttTacGia_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvTacGia.DataSource = tgBUS.LayDanhSachTacGia();
        }
    }
}

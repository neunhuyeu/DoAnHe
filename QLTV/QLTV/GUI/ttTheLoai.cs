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
    public partial class ttTheLoai : UserControl
    {

        private TheLoai_BLL tlBUS = new TheLoai_BLL();

        public ttTheLoai()
        {
            InitializeComponent();
        }

        private void ttTheLoai_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvTheLoai.DataSource = tlBUS.LayDanhSachTheLoai();
        }
    }
}

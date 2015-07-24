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
    public partial class ttMuonQuaHan : UserControl
    {
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        public ttMuonQuaHan()
        {
            InitializeComponent();
        }

        private void ttMuonQuaHan_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = pmBUS.LayDSMuonQuaHan();
        }
    }
}

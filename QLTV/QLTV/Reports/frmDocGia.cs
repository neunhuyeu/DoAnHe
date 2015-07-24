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
using Microsoft.Reporting.WinForms;

namespace QLTV.Reports
{
    public partial class frmDocGia : UserControl
    {
        DocGia_BLL dgBUS = new DocGia_BLL();

        public frmDocGia()
        {
            InitializeComponent();
        }

        private void reportViewerDocGia_Load(object sender, EventArgs e)
        {
            //Gán datasource cho reports
            DocGia_DTOBindingSource.DataSource = dgBUS.Laydsdocgia();
            this.reportViewerDocGia.RefreshReport();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            string Nguoilap = txtName.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NguoiLap", Nguoilap));
            reportViewerDocGia.LocalReport.SetParameters(param);
            reportViewerDocGia.RefreshReport();
        }
    }
}

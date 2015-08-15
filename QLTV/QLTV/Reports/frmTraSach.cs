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
using System.IO;

namespace QLTV.Reports
{
    public partial class frmTraSach : UserControl
    {
        TraSach_BLL tsBUS = new TraSach_BLL();

        public frmTraSach()
        {
            InitializeComponent();
        }

        private void reportViewerTraSach_Load(object sender, EventArgs e)
        {
            //Gán datasource cho reports
            TraSach_DTOBindingSource.DataSource = tsBUS.LayDanhSachTRASACH();
            this.reportViewerTraSach.RefreshReport();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            string NguoiLap = txtName.Text;
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NguoiLap", NguoiLap));
            reportViewerTraSach.LocalReport.SetParameters(param);
            reportViewerTraSach.RefreshReport();
            Byte[] mybytes = reportViewerTraSach.LocalReport.Render("PDF");

            using (FileStream fs = File.Create(@"D:\ReportDocGia.pdf"))
            {
                fs.Write(mybytes, 0, mybytes.Length);
            }
        }
    }
}

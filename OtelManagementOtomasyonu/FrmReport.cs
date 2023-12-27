using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelManagementOtomasyonu
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

       

        private void FrmReport_Load_1(object sender, EventArgs e)
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            List<PersonelView> list = vt.PersonelViews.ToList();
            List<Musteriler> list2 = vt.Musterilers.ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OtelManagementOtomasyonu.Raporlama.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", list);
            ReportDataSource dataset2 = new ReportDataSource("DataSet2", list2);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.DataSources.Add(dataset2);
            reportViewer1.RefreshReport();
        }
    }
}

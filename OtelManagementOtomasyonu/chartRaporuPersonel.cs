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
    public partial class chartRaporuPersonel : Form
    {
        public chartRaporuPersonel()
        {
            InitializeComponent();
        }

        private void chartRaporuPersonel_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
           List<Musteriler> list1 = vt.Musterilers.ToList(); 
            List<Personel> list2 = vt.Personels.ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OtelManagementOtomasyonu.ReportaChart.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSet1", list2);
            ReportDataSource dataset1 = new ReportDataSource("DataSet2", list1);

            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.DataSources.Add(dataset1);

            reportViewer1.RefreshReport();
        }
    }
}

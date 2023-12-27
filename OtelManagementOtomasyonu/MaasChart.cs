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
    public partial class MaasChart : Form
    {
        public MaasChart()
        {
            InitializeComponent();
        }

        private void MaasChart_Load(object sender, EventArgs e)
        {
            cbGorevler.ValueMember = "GorevID";
            cbGorevler.DisplayMember = "GorevKodu";
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            cbGorevler.DataSource = vt.GorevTbls.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["maas"].Points.Clear();

            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();

            if (cbGorevler.SelectedItem is GorevTbl selectedGorev)
            {
                var maaslar = vt.Personels
                    .Where(p => p.GorevId == selectedGorev.GorevID)
                    .Select(p => new { GorevKodu = selectedGorev.GorevKodu, Maas = p.maas }) // Retrieve GorevKodu and maas
                    .ToList();

                chart1.Series["maas"].XValueMember = "GorevKodu";
                chart1.Series["maas"].YValueMembers = "maas";
                chart1.DataSource = maaslar;
                chart1.DataBind();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir öğe seçin.");
            }
        }
    }
}

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
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            cbKategoriler.ValueMember = "KategoriID";
            cbKategoriler.DisplayMember = "KategoriAd";
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            cbKategoriler.DataSource = vt.Kategoris.ToList();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Kategori"].Points.Clear();

            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();

            string selectedCategory = cbKategoriler.Text;

            var kategori = vt.Kategoris.FirstOrDefault(x => x.KategoriAd == selectedCategory);

            var uruns = vt.Uruns
                    .Where(p => p.KategoriId == kategori.KategoriID)
                    .Select(p => new { UrunAd = p.UrunAd, KategoriAd = kategori.KategoriAd, UrunMiktari = p.UrunMiktari })
                    .ToList();

            chart1.Series["Kategori"].XValueMember = "UrunAd";
            chart1.Series["Kategori"].YValueMembers = "UrunMiktari";
            chart1.DataSource = uruns;
            chart1.DataBind();
  
            
        }
    }
}

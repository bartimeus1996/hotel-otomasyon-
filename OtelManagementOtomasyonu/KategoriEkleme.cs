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
    public partial class KategoriEkleme : Form
    {
        public KategoriEkleme()
        {
            InitializeComponent();
        }

        private void btnKaegoriEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAd = txtKategoriAd.Text.Trim();
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            vt.Kategoris.Add(kategori);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                txtKategoriAd.Clear();
                TumKategorileriLsitele();
                MessageBox.Show("Kategori Eklendi!!");
            }
            else
                MessageBox.Show("Kategori Eklenemedi!!");
        }
        void TumKategorileriLsitele()
        {
            lslKategori.DisplayMember = "KategoriAd";
            lslKategori.ValueMember = "KategoriID";
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            lslKategori.DataSource = vt.Kategoris.ToList();
        }

        private void KategoriEkleme_Load(object sender, EventArgs e)
        {
            TumKategorileriLsitele();
        }
    }
}

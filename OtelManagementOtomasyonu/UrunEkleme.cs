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
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.KategoriId = Convert.ToInt32(cbUrunKategori.SelectedValue.ToString());
            urun.UrunAd = txtUrunAd.Text;
            urun.BarkodNo = txtBarkodNo.Text;
            urun.UrunMiktari = Convert.ToInt32(txtMiktari.Text);
            urun.UrunFiyati = Convert.ToInt32(txtFiyati.Text);
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            vt.Uruns.Add(urun);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                KontrolleriTemizle();
                TumUrunleriListele();
                MessageBox.Show("Ürün kaydedildi", "İşlem başarılı!!");
            }
            else
                MessageBox.Show("Ürün kaydedilemedi", "İşlem başarısız!!");
        }
         void  KontrolleriTemizle()
        {
            txtUrunAd.Clear();
            txtBarkodNo.Clear();
            txtMiktari.Clear();
            txtFiyati.Clear();
        }
        void TumUrunleriListele()
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            dataGridView1.DataSource=vt.UrunViews.ToList();
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
          
            cbUrunKategori.DisplayMember = "KategoriAd";
            cbUrunKategori.ValueMember = "KategoriID";
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            cbUrunKategori.DataSource = vt.Kategoris.ToList();
            TumUrunleriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}

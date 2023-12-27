using OtelManagementOtomasyonu.TCKimlikDogrulama;
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
    public partial class PersonelEkleme : Form
    {
        public PersonelEkleme()
        {
            InitializeComponent();
        }
          public event EventHandler IslemBasarili;

        private void btnSicilNoUret_Click(object sender, EventArgs e)
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            List<Personel> personelListesi = vt.Personels.OrderByDescending(p => p.SicilNo).ToList();
            if (personelListesi != null && personelListesi.Count > 0)
            {
                txtSicilNo.Text = (personelListesi[0].SicilNo + 1).ToString();
            }
            else
            {
                txtSicilNo.Text = 10000.ToString();
            }

            txtKullaniciSifre.Text = txtSicilNo.Text;
        }

            private void txtPersonelAd_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = txtPersonelAd.Text.Trim().ToLower() + "." + txtSoyad.Text.Trim().ToLower();

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = txtPersonelAd.Text.Trim().ToLower() + "." + txtSoyad.Text.Trim().ToLower();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel();
            pers.PersonelAd = txtPersonelAd.Text;
            pers.PersonelSoyad = txtSoyad.Text;
            pers.KullaniciAd = txtKullaniciAd.Text;
            pers.KullaniciSifre = txtKullaniciSifre.Text;
            pers.SicilNo = Convert.ToDecimal(txtSicilNo.Text);
            pers.GorevId =Convert.ToInt32(cbGorevler.SelectedValue.ToString());
            pers.maas = txtMaas.Text;
            pers.DogumYil = Convert.ToInt32(txtDogumYil.Text);
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            vt.Personels.Add(pers);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                TumKontrolleriTemizle();
             //   TumKayitlariListele();
                MessageBox.Show("Personel kayıt edildi", "İşlem başarılı!!");
               IslemBasarili(pers, null);

            }
            else
                MessageBox.Show("Personel kayıt edilemedi", "İşlem başarısız!!");
        }
        void TumKayitlariListele()
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
           // dataGridView1.DataSource = vt.PersonelViews.ToList();
        }

        void TumKontrolleriTemizle()
        {
            txtKullaniciAd.Clear();
            txtKullaniciSifre.Clear();
            txtPersonelAd.Clear();
            txtSoyad.Clear();
            txtSicilNo.Clear();
            txtMaas.Clear();
            txtDogumYil.Clear();
        }

        private void PersonelEkleme_Load(object sender, EventArgs e)
        {

            cbGorevler.ValueMember = "GorevID";
            cbGorevler.DisplayMember = "GorevAd";
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            cbGorevler.DataSource = vt.GorevTbls.ToList();

          //  dataGridView1.AutoGenerateColumns = false;
            TumKayitlariListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            long TcKimlikNo = Convert.ToInt64(txtTCNO.Text);
            string Ad = txtPersonelAd.Text.ToUpper();
            string Soyad = txtSoyad.Text.ToUpper();
            int DogumYili = Convert.ToInt32(txtDogumYil.Text);
            KPSPublicSoapClient servis = new KPSPublicSoapClient();
            bool sonuc = servis.TCKimlikNoDogrula(TcKimlikNo, Ad, Soyad, DogumYili);
            if (sonuc == true)
            {
                MessageBox.Show("Kullanıcı gerçek kişi", "Doğrulama başarılı!!");
                txtMaas.Enabled = true;
                txtSicilNo.Enabled = true;
                cbGorevler.Enabled = true;
                txtKullaniciSifre.Enabled = true;
                txtKullaniciAd.Enabled = true;

            }

            else
                MessageBox.Show("Kullanıcı yok", "Doğrulama başarısız!!");
        }
    }
}

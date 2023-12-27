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
    public partial class FormSifreDegistirme : Form
    {
        public FormSifreDegistirme()
        {
            InitializeComponent();
        }

        Personel loginOlanPersonel;
        public FormSifreDegistirme(Personel personel)
        {
            InitializeComponent();
            loginOlanPersonel = personel;
        }
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string mevcutSifre = txtMevcutSifre.Text;
            string yeniSifre = txtYeniSifre.Text;
            string yeniSifreTekrar = txtYeniSifreTekrar.Text;

            if (string.IsNullOrEmpty(mevcutSifre) || string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(yeniSifreTekrar))
                MessageBox.Show("Şifreler boş olamaz");
            else
            {
                if (yeniSifre != yeniSifreTekrar)
                    MessageBox.Show("Yeni şifre ve tekrarı aynı olmalı");
                else
                {
                    projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
                    Personel personel = vt.Personels.FirstOrDefault(p => p.KullaniciAd == loginOlanPersonel.KullaniciAd &&
                    p.KullaniciSifre == loginOlanPersonel.KullaniciSifre);
                    personel.KullaniciSifre = yeniSifre;
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Şifre Değiştirildi! Sisteme yeniden login olun");
                        Application.OpenForms["Home"].Show();
                        this.MdiParent.Hide();
                    }
                }
            }
        }
    }
}

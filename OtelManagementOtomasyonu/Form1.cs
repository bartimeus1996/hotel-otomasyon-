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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string kullaniciSifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(kullaniciSifre))
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");

           else
            {
                projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
                Personel personel = vt.Personels.FirstOrDefault(p => p.KullaniciAd == kullaniciAdi && p.KullaniciSifre == kullaniciSifre);
                if (personel != null)
                {
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                    Home home = new Home(personel);
                    home.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı ve şifre ile ilgili personel bulunamadı");
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

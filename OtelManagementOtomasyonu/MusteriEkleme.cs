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
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
            cbYataklar.SelectedIndexChanged += cbYataklar_SelectedIndexChanged;

        }
     //   public event EventHandler IslemBasarili;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriler musteriler = new Musteriler();
                musteriler.TCNO = txtTCNO.Text.Trim();
                musteriler.Ad = txtAd.Text.Trim().ToUpper();
                musteriler.Soyad = txtSoyad.Text.Trim().ToUpper();
                musteriler.Adress = txtAdress.Text.Trim().ToUpper();
                musteriler.DogumTarihi = Convert.ToInt32(txtDogumTarihi.Text);
                musteriler.Cinsiyet = rbKadin.Checked ? "KADIN" : "ERKEK";
                musteriler.TeleNum = txtTeleNum.Text.Trim().ToUpper();
                musteriler.Sifre = txtSifre.Text.Trim().ToUpper();
                musteriler.oda_numarasi = txtRoomNumber.Text.Trim();
                string selectedYatak = cbYataklar.SelectedItem.ToString();
                musteriler.yataklar = cbYataklar.SelectedItem.ToString();
                musteriler.fiyatlar = Convert.ToInt32(cbFiyatlar.SelectedItem.ToString());
                musteriler.checkinTarihi = dtCheckin.Value;
                musteriler.checkoutTarihi = dtCheckout.Value;
             
                projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
                    vt.Musterilers.Add(musteriler);
                    int saveResult = vt.SaveChanges();

                    if (saveResult > 0)
                    {
                        KontrolleriTemizle();
                        TumKayitlariListele();
                        MessageBox.Show("İşlem başarılı!", "Kayıt yapıldı!!");
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız!", "Kayıt yapılamadı!!");
                    }
                
               
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu!!", hata.Message);
            }
        }
        void KontrolleriTemizle()
        {
            LblMusteriNo.Text = "";
            txtTCNO.Clear();
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            txtAdress.Clear();
            txtTeleNum.Clear();
            txtSifre.Clear();   
            txtDogumTarihi.Clear();
            rbKadin.Checked = true;
            //cbFiyatlar.SelectedIndex = -1;
            //cbYataklar.SelectedIndex = -1;
            dtCheckin.Value = DateTime.Now;
            dtCheckout.Value = DateTime.Now;
            txtRoomNumber.Clear();
        }
        void TumKayitlariListele()
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            dataGridView1.DataSource = vt.Musterilers.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int guncellenecekID = Convert.ToInt32(LblMusteriNo.Text);
                projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
                Musteriler guncellenecekMusteri = vt.Musterilers.FirstOrDefault(p => p.Musteri_İd == guncellenecekID);
                guncellenecekMusteri.TCNO = txtTCNO.Text.Trim();
                guncellenecekMusteri.Ad = txtAd.Text.Trim().ToUpper();
                guncellenecekMusteri.Soyad = txtSoyad.Text.Trim().ToUpper();
                guncellenecekMusteri.Adress = txtAdress.Text.Trim().ToUpper();
                guncellenecekMusteri.TeleNum = txtTeleNum.Text.Trim();
                guncellenecekMusteri.Sifre = txtSifre.Text.Trim();
                guncellenecekMusteri.DogumTarihi = Convert.ToInt32(txtDogumTarihi.Text);
                guncellenecekMusteri.Cinsiyet = rbErkek.Checked ? "ERKEK" : "KADIN";
                guncellenecekMusteri.oda_numarasi = txtRoomNumber.Text.Trim();
                if (cbYataklar.SelectedItem != null && cbFiyatlar.SelectedItem != null)
                {
                    guncellenecekMusteri.yataklar = cbYataklar.SelectedItem.ToString();
                    guncellenecekMusteri.fiyatlar = Convert.ToInt32(cbFiyatlar.SelectedItem.ToString());

                }
                else
                {
                    MessageBox.Show("Lütfen bir yatak ve fiyat seçin!", "Eksik Bilgi");
                }
                guncellenecekMusteri.checkinTarihi = dtCheckin.Value;
                guncellenecekMusteri.checkoutTarihi = dtCheckout.Value;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    KontrolleriTemizle();
                    TumKayitlariListele();
                    MessageBox.Show("İşlem başarılı!", "Güncelleme yapıldı!!");
                }
                else
                    MessageBox.Show("İşlem başarısız!", "Güncelleme yapılamadı!!");
            }
                catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu!!", hata.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LblMusteriNo.Text = dataGridView1.CurrentRow.Cells["Musteri_İd"].Value.ToString();
            txtTCNO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "ERKEK")
                rbErkek.Checked = true;
            else 
                rbKadin.Checked = true;
            txtAdress.Text = dataGridView1.CurrentRow.Cells["Adress"].Value.ToString();
            txtTeleNum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dtCheckin.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells["checkinTarihi"].Value);
            dtCheckout.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["checkinTarihi"].Value);
            txtRoomNumber.Text = dataGridView1.CurrentRow.Cells["oda_numarasi"].Value.ToString();
            cbYataklar.SelectedItem = dataGridView1.CurrentRow.Cells[12].Value;
            cbFiyatlar.SelectedItem = dataGridView1.CurrentRow.Cells[13].Value;
            txtDogumTarihi.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DogumTarihi"].Value).ToString();
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {


                int silinecekID = Convert.ToInt32(LblMusteriNo.Text);
                projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
                Musteriler silinecekMusteri = vt.Musterilers.FirstOrDefault(p => p.Musteri_İd == silinecekID);
                vt.Musterilers.Remove(silinecekMusteri);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    TumKayitlariListele();
                    KontrolleriTemizle();
                    MessageBox.Show("İşlem başarılı!", "Kayıt silindi!!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız!", "Kayıt silinemedi!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu!!", ex.Message);
            }
        }

        private void cbYataklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBed = cbYataklar.SelectedItem.ToString();

            // Determine price based on the selected bed
            int price = 0;

            if (selectedBed == "Single")
            {
                price = 1000;
            }
            else if (selectedBed == "Double")
            {
                price = 2000;
            }
            else if (selectedBed == "Triple")
            {
                price = 3000;
            }

            // Find the index of the price in fiyatlarCombobox.Items
            int priceIndex = -1;
            for (int i = 0; i < cbFiyatlar.Items.Count; i++)
            {
                if (cbFiyatlar.Items[i].ToString() == price.ToString())
                {
                    priceIndex = i;
                    break;
                }
            }

            // Set the selected index in the fiyatlar combobox
            if (priceIndex != -1)
            {
                cbFiyatlar.SelectedIndex = priceIndex;
            }
            else
            {
                // Handle the case if the price index is not found
                // You can display an error message or handle it as per your requirement
            }

        }
       

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            TumKayitlariListele();
        }
    }
}

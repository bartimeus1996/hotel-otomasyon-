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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkleme personel = new PersonelEkleme();
            personel.IslemBasarili += Frm_IslemBasarili;
            personel.Show();
        }
        private void Frm_IslemBasarili(object sender, EventArgs e)
        {
            Personel islemYapilanKisi = (sender as Personel);
            List<Personel> mevcutListe = dataGridView1.DataSource as List<Personel>;
            mevcutListe.Add(islemYapilanKisi);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mevcutListe;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["GorevKodu"].Visible = false;

        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            TumKayitlariListele();
            
        }

        void TumKayitlariListele()
        {
            projeFinalOtomasyonuEntities1 vt = new projeFinalOtomasyonuEntities1();
            dataGridView1.DataSource = vt.Personels.ToList(); 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["GorevKodu"].Visible= false;
            dataGridView1.Columns["DogumYil"].Visible = false;
            dataGridView1.Columns["UrunSatis"].Visible = false;
            dataGridView1.Columns["GorevTbl"].Visible = false;
        }
    }
}

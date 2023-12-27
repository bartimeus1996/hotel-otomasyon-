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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           

        }
        public Personel personel;

        public Home(Personel LoginOlanPersonel)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            personel = LoginOlanPersonel;
            Hotel_Manager.Visible = false;
            Hotel_Sales_Manager.Visible = false;

            switch (personel.GorevId)
            {
                case 1:
                    Hotel_Manager.Visible = true;
                    break;
                case 2:
                    Hotel_Sales_Manager.Visible = true;
                    break;
            }
        }

        private void Personel_Ekle_toolMenu_Click(object sender, EventArgs e)
        {
            PersonelListesi personelListesi = new PersonelListesi();
            personelListesi.MdiParent = this;
            personelListesi.Show();
        }

        private void MüşteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleme frm1 = new MusteriEkleme();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Urun_Kategori_Ekle_toolStripMenu_Click(object sender, EventArgs e)
        {
            KategoriEkleme frm3 = new KategoriEkleme();
           frm3.MdiParent = this;
            frm3.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleme = new UrunEkleme();
            urunEkleme.MdiParent=this;
            urunEkleme.Show();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charts chart = new Charts();
            chart.MdiParent = this; 
            chart.Show();
        }

        private void maaslChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaasChart maasChart = new MaasChart();
            maasChart.MdiParent = this; 
            maasChart.Show();
        }

        private void kişiselİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void şifreDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSifreDegistirme formSifreDegistirme = new FormSifreDegistirme(personel);
            formSifreDegistirme.MdiParent = this;
            formSifreDegistirme.Show();
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSifreDegistirme formSifreDegistirme = new FormSifreDegistirme(personel);
            formSifreDegistirme.MdiParent = this;
            formSifreDegistirme.Show();
        }

        private void raporlamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void chartsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void lıstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunlerRaporlama urunlerRaporlama = new UrunlerRaporlama();
            urunlerRaporlama.MdiParent = this;
            urunlerRaporlama.Show();
        }

        private void chartsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chartRaporuPersonel frm8 = new chartRaporuPersonel();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void tablolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport frm4 = new FrmReport();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void çikişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personel = null;
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void çikişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personel = null;
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

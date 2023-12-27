namespace OtelManagementOtomasyonu
{
    partial class PersonelListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GorevKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Personel Listesi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 34);
            this.label9.TabIndex = 57;
            this.label9.Text = "Otel Yönetim Otomasyonu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEklemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 53);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(113, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelEklemeToolStripMenuItem
            // 
            this.personelEklemeToolStripMenuItem.Name = "personelEklemeToolStripMenuItem";
            this.personelEklemeToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.personelEklemeToolStripMenuItem.Text = "Personel Ekleme";
            this.personelEklemeToolStripMenuItem.Click += new System.EventHandler(this.personelEklemeToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SicilNo,
            this.PersonelAd,
            this.PersonelSoyad,
            this.GorevKodu,
            this.maas,
            this.DogumYil});
            this.dataGridView1.Location = new System.Drawing.Point(9, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 327);
            this.dataGridView1.TabIndex = 60;
            // 
            // SicilNo
            // 
            this.SicilNo.DataPropertyName = "SicilNo";
            this.SicilNo.HeaderText = "Sicil No";
            this.SicilNo.Name = "SicilNo";
            // 
            // PersonelAd
            // 
            this.PersonelAd.DataPropertyName = "PersonelAd";
            this.PersonelAd.HeaderText = "Personel Ad";
            this.PersonelAd.Name = "PersonelAd";
            // 
            // PersonelSoyad
            // 
            this.PersonelSoyad.DataPropertyName = "PersonelSoyad";
            this.PersonelSoyad.HeaderText = "Personel Soyad";
            this.PersonelSoyad.Name = "PersonelSoyad";
            // 
            // GorevKodu
            // 
            this.GorevKodu.DataPropertyName = "Gorev Kodu";
            this.GorevKodu.HeaderText = "Gorev Kodu";
            this.GorevKodu.Name = "GorevKodu";
            // 
            // maas
            // 
            this.maas.DataPropertyName = "maas";
            this.maas.HeaderText = "maas";
            this.maas.Name = "maas";
            // 
            // DogumYil
            // 
            this.DogumYil.DataPropertyName = "DogumYil";
            this.DogumYil.HeaderText = "DogumYil";
            this.DogumYil.Name = "DogumYil";
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonelListesi";
            this.Text = "PersonelListesi";
            this.Load += new System.EventHandler(this.PersonelListesi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYil;
    }
}
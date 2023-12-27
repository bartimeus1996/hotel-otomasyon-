namespace OtelManagementOtomasyonu
{
    partial class UrunEkleme
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUrunKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KategoriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Urun Ekleme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 34);
            this.label9.TabIndex = 57;
            this.label9.Text = "Otel Yönetim Otomasyonu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Tomato;
            this.btnKaydet.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(128, 302);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(189, 33);
            this.btnKaydet.TabIndex = 65;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(128, 171);
            this.txtBarkodNo.MaxLength = 6;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(189, 20);
            this.txtBarkodNo.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Barkod No:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(128, 132);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(189, 20);
            this.txtUrunAd.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ürün Ad:";
            // 
            // cbUrunKategori
            // 
            this.cbUrunKategori.FormattingEnabled = true;
            this.cbUrunKategori.Location = new System.Drawing.Point(128, 90);
            this.cbUrunKategori.Name = "cbUrunKategori";
            this.cbUrunKategori.Size = new System.Drawing.Size(189, 21);
            this.cbUrunKategori.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ürün Kategorisi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategoriAd,
            this.UrunAd,
            this.BarkodNo,
            this.UrunMiktari,
            this.UrunFiyati});
            this.dataGridView1.Location = new System.Drawing.Point(328, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 66;
            // 
            // KategoriAd
            // 
            this.KategoriAd.DataPropertyName = "KategoriAd";
            this.KategoriAd.HeaderText = "Kategori Ad";
            this.KategoriAd.Name = "KategoriAd";
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Urun Ad";
            this.UrunAd.Name = "UrunAd";
            // 
            // BarkodNo
            // 
            this.BarkodNo.DataPropertyName = "BarkodNo";
            this.BarkodNo.HeaderText = "Barkod No";
            this.BarkodNo.Name = "BarkodNo";
            // 
            // UrunMiktari
            // 
            this.UrunMiktari.DataPropertyName = "UrunMiktari";
            this.UrunMiktari.HeaderText = "Urun Miktari";
            this.UrunMiktari.Name = "UrunMiktari";
            // 
            // UrunFiyati
            // 
            this.UrunFiyati.DataPropertyName = "UrunFiyati";
            this.UrunFiyati.HeaderText = "Urun Fiyati";
            this.UrunFiyati.Name = "UrunFiyati";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(128, 213);
            this.txtMiktari.MaxLength = 6;
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(189, 20);
            this.txtMiktari.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "Urun Miktari";
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(128, 254);
            this.txtFiyati.MaxLength = 6;
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(189, 20);
            this.txtFiyati.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "Urun Fiyati";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 33);
            this.button1.TabIndex = 71;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUrunKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "UrunEkleme";
            this.Text = "UrunEkleme";
            this.Load += new System.EventHandler(this.UrunEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUrunKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunFiyati;
        private System.Windows.Forms.Button button1;
    }
}
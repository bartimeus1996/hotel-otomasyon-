namespace OtelManagementOtomasyonu
{
    partial class KategoriEkleme
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
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lslKategori = new System.Windows.Forms.ListBox();
            this.btnKaegoriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Kategori Ekleme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 34);
            this.label9.TabIndex = 55;
            this.label9.Text = "Otel Yönetim Otomasyonu";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(154, 117);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(134, 20);
            this.txtKategoriAd.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kategori : ";
            // 
            // lslKategori
            // 
            this.lslKategori.FormattingEnabled = true;
            this.lslKategori.Location = new System.Drawing.Point(15, 166);
            this.lslKategori.Name = "lslKategori";
            this.lslKategori.Size = new System.Drawing.Size(273, 160);
            this.lslKategori.TabIndex = 59;
            // 
            // btnKaegoriEkle
            // 
            this.btnKaegoriEkle.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaegoriEkle.Location = new System.Drawing.Point(337, 114);
            this.btnKaegoriEkle.Name = "btnKaegoriEkle";
            this.btnKaegoriEkle.Size = new System.Drawing.Size(100, 34);
            this.btnKaegoriEkle.TabIndex = 60;
            this.btnKaegoriEkle.Text = "Ekle";
            this.btnKaegoriEkle.UseVisualStyleBackColor = true;
            this.btnKaegoriEkle.Click += new System.EventHandler(this.btnKaegoriEkle_Click);
            // 
            // KategoriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaegoriEkle);
            this.Controls.Add(this.lslKategori);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "KategoriEkleme";
            this.Text = "KategoriEkleme";
            this.Load += new System.EventHandler(this.KategoriEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lslKategori;
        private System.Windows.Forms.Button btnKaegoriEkle;
    }
}
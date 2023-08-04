namespace ProjeTaslak
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.soyadTextbox = new System.Windows.Forms.TextBox();
            this.boyTextbox = new System.Windows.Forms.TextBox();
            this.kiloTextbox = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnFrmGecis = new System.Windows.Forms.Button();
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilo";
            // 
            // adTextbox
            // 
            this.adTextbox.Location = new System.Drawing.Point(89, 12);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(100, 20);
            this.adTextbox.TabIndex = 4;
            // 
            // soyadTextbox
            // 
            this.soyadTextbox.Location = new System.Drawing.Point(89, 54);
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(100, 20);
            this.soyadTextbox.TabIndex = 5;
            // 
            // boyTextbox
            // 
            this.boyTextbox.Location = new System.Drawing.Point(89, 98);
            this.boyTextbox.Name = "boyTextbox";
            this.boyTextbox.Size = new System.Drawing.Size(100, 20);
            this.boyTextbox.TabIndex = 6;
            // 
            // kiloTextbox
            // 
            this.kiloTextbox.Location = new System.Drawing.Point(89, 135);
            this.kiloTextbox.Name = "kiloTextbox";
            this.kiloTextbox.Size = new System.Drawing.Size(100, 20);
            this.kiloTextbox.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(15, 181);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 57);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Kitle Endexi Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 244);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 15);
            this.lblSonuc.TabIndex = 10;
            // 
            // btnFrmGecis
            // 
            this.btnFrmGecis.Image = global::ProjeTaslak.Properties.Resources.Healthy_Food_Calories_Calculator;
            this.btnFrmGecis.Location = new System.Drawing.Point(406, 192);
            this.btnFrmGecis.Name = "btnFrmGecis";
            this.btnFrmGecis.Size = new System.Drawing.Size(338, 64);
            this.btnFrmGecis.TabIndex = 14;
            this.btnFrmGecis.Text = "Kişiye Özel Günlük Kalori İhtiyacını Hesaplayıcı";
            this.btnFrmGecis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFrmGecis.UseVisualStyleBackColor = true;
            this.btnFrmGecis.Click += new System.EventHandler(this.btnFrmGecis_Click);
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 14;
            this.lstKullanicilar.Location = new System.Drawing.Point(246, 12);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(407, 144);
            this.lstKullanicilar.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::ProjeTaslak.Properties.Resources.Delete_Trash;
            this.btnSil.Location = new System.Drawing.Point(659, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 74);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Kişiyi Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Image = global::ProjeTaslak.Properties.Resources.List;
            this.btnListele.Location = new System.Drawing.Point(659, 98);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(96, 59);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Image = global::ProjeTaslak.Properties.Resources.Save;
            this.btnKaydet.Location = new System.Drawing.Point(121, 181);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 57);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjeTaslak.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(756, 268);
            this.Controls.Add(this.btnFrmGecis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lstKullanicilar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.kiloTextbox);
            this.Controls.Add(this.boyTextbox);
            this.Controls.Add(this.soyadTextbox);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VKI Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.TextBox soyadTextbox;
        private System.Windows.Forms.TextBox boyTextbox;
        private System.Windows.Forms.TextBox kiloTextbox;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFrmGecis;
        private System.Windows.Forms.ListBox lstKullanicilar;
        public System.Windows.Forms.Button btnKaydet;
    }
}


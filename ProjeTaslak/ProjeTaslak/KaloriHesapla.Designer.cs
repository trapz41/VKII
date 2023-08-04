namespace ProjeTaslak
{
    partial class KaloriHesapla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaloriHesapla));
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cmbAktiviteDuzeyi = new System.Windows.Forms.ComboBox();
            this.rbdKadin = new System.Windows.Forms.RadioButton();
            this.rbdErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(96, 64);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(100, 20);
            this.txtKilo.TabIndex = 0;
            this.txtKilo.TextChanged += new System.EventHandler(this.txtKilo_TextChanged);
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(96, 21);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 20);
            this.txtBoy.TabIndex = 1;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(96, 110);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 2;
            this.txtYas.TextChanged += new System.EventHandler(this.txtYas_TextChanged);
            // 
            // cmbAktiviteDuzeyi
            // 
            this.cmbAktiviteDuzeyi.FormattingEnabled = true;
            this.cmbAktiviteDuzeyi.Items.AddRange(new object[] {
            "CokAz",
            "Hafif",
            "Orta",
            "Yuksek",
            "CokYuksek"});
            this.cmbAktiviteDuzeyi.Location = new System.Drawing.Point(96, 152);
            this.cmbAktiviteDuzeyi.Name = "cmbAktiviteDuzeyi";
            this.cmbAktiviteDuzeyi.Size = new System.Drawing.Size(121, 21);
            this.cmbAktiviteDuzeyi.TabIndex = 3;
            // 
            // rbdKadin
            // 
            this.rbdKadin.AutoSize = true;
            this.rbdKadin.Location = new System.Drawing.Point(100, 198);
            this.rbdKadin.Name = "rbdKadin";
            this.rbdKadin.Size = new System.Drawing.Size(52, 17);
            this.rbdKadin.TabIndex = 4;
            this.rbdKadin.TabStop = true;
            this.rbdKadin.Text = "Kadın";
            this.rbdKadin.UseVisualStyleBackColor = true;
            // 
            // rbdErkek
            // 
            this.rbdErkek.AutoSize = true;
            this.rbdErkek.Location = new System.Drawing.Point(191, 198);
            this.rbdErkek.Name = "rbdErkek";
            this.rbdErkek.Size = new System.Drawing.Size(53, 17);
            this.rbdErkek.TabIndex = 5;
            this.rbdErkek.TabStop = true;
            this.rbdErkek.Text = "Erkek";
            this.rbdErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kilo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Boy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yaş";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aktivite Düzeyi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sonuç";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(91, 276);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 29);
            this.lblSonuc.TabIndex = 12;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(77, 237);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(197, 288);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(102, 41);
            this.btnProgram.TabIndex = 14;
            this.btnProgram.Text = "Program Hazırla";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // KaloriHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjeTaslak.Properties.Resources.faded;
            this.ClientSize = new System.Drawing.Size(311, 361);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbdErkek);
            this.Controls.Add(this.rbdKadin);
            this.Controls.Add(this.cmbAktiviteDuzeyi);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtKilo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KaloriHesapla";
            this.Text = "KaloriHesapla";
            this.Load += new System.EventHandler(this.KaloriHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cmbAktiviteDuzeyi;
        private System.Windows.Forms.RadioButton rbdKadin;
        private System.Windows.Forms.RadioButton rbdErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnProgram;
    }
}
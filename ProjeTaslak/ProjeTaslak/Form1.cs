using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeTaslak
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\emirh\OneDrive\Masaüstü\UğraşDur\ProjeTaslak\KullaniciBilgileri.accdb;Persist Security Info=False;";
        KullaniciDAL kullaniciDAL;
        public Form1()
        {

            InitializeComponent();
            kullaniciDAL = new KullaniciDAL();
        }

        public class ListBoxHeaderItem
        {
            public string HeaderText { get; private set; }

            public ListBoxHeaderItem(string headerText)
            {
                HeaderText = headerText;
            }

            public override string ToString()
            {
                return HeaderText;
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double boy = Convert.ToDouble(boyTextbox.Text) / 100;
                double kilo = Convert.ToDouble(kiloTextbox.Text);

                double vucutKitleEndeksi = kilo / (boy * boy);
                if (vucutKitleEndeksi < 18.5)
                {
                    lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00")+" Zayıf !";
                }
                else if (25<vucutKitleEndeksi&&vucutKitleEndeksi<29.9)
                {
                    lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00") + " Fazla Kilolu!!";
                }
                else if (30 < vucutKitleEndeksi && vucutKitleEndeksi < 34.9)
                {
                    lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00") + " Obez (Tip 1)";
                }
                else if (35 < vucutKitleEndeksi && vucutKitleEndeksi < 39.9)
                {
                    lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00") + "Obez (Tip2 )";
                    MessageBox.Show("Sağlık Açısından Tehlikeli", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ( 40 < vucutKitleEndeksi)
                {
                    lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00") + "Obez (Tip3)!!";
                    MessageBox.Show("Sağlık Açısından Aşırı Tehlikeli","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                lblSonuc.Text = "Vücut Kitle Endeksi: " + vucutKitleEndeksi.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen doğru değerler girin.");
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = adTextbox.Text;
                string soyad = soyadTextbox.Text;
                double boy = Convert.ToDouble(boyTextbox.Text);
                double kilo = Convert.ToDouble(kiloTextbox.Text);

                double vucutKitleEndeksi = kilo / ((boy / 100) * (boy / 100));

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO KullaniciBilgileri (Ad, Soyad, Boy, Kilo, VucutKitleEndeksi) VALUES (@Ad, @Soyad, @Boy, @Kilo, @VucutKitleEndeksi)";
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Boy", boy);
                        command.Parameters.AddWithValue("@Kilo", kilo);
                        command.Parameters.AddWithValue("@VucutKitleEndeksi", vucutKitleEndeksi);

                        command.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Bilgiler başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. Bilgileri doğru girdiğinizden emin olun.");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityLayer.KullaniciBilgileri> kullaniciListesi = kullaniciDAL.TumKullanicilariGetir();
            lstKullanicilar.Items.Clear();
            ListBoxHeaderItem headerItem = new ListBoxHeaderItem("Ad        Soyad       Boy        Kilo        VKİ");
            lstKullanicilar.Items.Add(headerItem);

            // Kullanıcıları liste kutusuna ekle
            foreach (var kullanici in kullaniciListesi)
            {
                lstKullanicilar.Items.Add(kullanici);
            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == 0)
            {
                MessageBox.Show("naptın la Başka Şey Seç");
                return;
            }
            if (lstKullanicilar.SelectedIndex != -1)
            {

                // Seçilen kişiyi sil
                int secilenIndex = lstKullanicilar.SelectedIndex;
                EntityLayer.KullaniciBilgileri secilenKullanici = (EntityLayer.KullaniciBilgileri)lstKullanicilar.SelectedItem;

                // Veritabanından da silme işlemini gerçekleştir
                kullaniciDAL.KullaniciSil(secilenKullanici.ID);

                // ListBox'tan da kişiyi kaldır
                lstKullanicilar.Items.RemoveAt(secilenIndex);
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFrmGecis_Click(object sender, EventArgs e)
        {
            KaloriHesapla kaloriHesapla = new KaloriHesapla();
            kaloriHesapla.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
        }
    }
}
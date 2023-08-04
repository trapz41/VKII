using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeTaslak
{
    public partial class KaloriHesapla : Form
    {
        private string apiKey = "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";
        private string apiUrl = "https://api.openai.com/v1/engines/text-davinci-003/completions";

        public KaloriHesapla()
        {
            InitializeComponent();
        }

        private void KaloriHesapla_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            lblSonuc.BackColor = Color.Transparent;
        }

        private double HesaplaKadin(double kilo, double boy, int yas, FizikselAktiviteDuzeyi fizikselAktiviteDuzeyi)
        {
            double bmr = 10 * kilo + 6.25 * boy - 5 * yas - 161;
            double kalori = bmr * AktiviteKatsayisi(fizikselAktiviteDuzeyi);
            return kalori;
        }

        private double HesaplaErkek(double kilo, double boy, int yas, FizikselAktiviteDuzeyi fizikselAktiviteDuzeyi)
        {
            double bmr = 10 * kilo + 6.25 * boy - 5 * yas + 5;
            double kalori = bmr * AktiviteKatsayisi(fizikselAktiviteDuzeyi);
            return kalori;
        }

        private double AktiviteKatsayisi(FizikselAktiviteDuzeyi fizikselAktiviteDuzeyi)
        {
            switch (fizikselAktiviteDuzeyi)
            {
                case FizikselAktiviteDuzeyi.CokAz:
                    return 1.2;
                case FizikselAktiviteDuzeyi.Hafif:
                    return 1.375;
                case FizikselAktiviteDuzeyi.Orta:
                    return 1.55;
                case FizikselAktiviteDuzeyi.Yuksek:
                    return 1.725;
                case FizikselAktiviteDuzeyi.CokYuksek:
                    return 1.9;
                default:
                    return 1.2;
            }
        }
        private string[] dusukKaloriProgramlar = new string[]
   {
    "Sabah: Yulaf ezmesi, süt\nÖğle: Tavuk salatası\nAkşam: Izgara balık, sebzeler",
    "Sabah: Yulaf ezmesi, yoğurt\nÖğle: Sebzeli omlet\nAkşam: Tavuk ızgara, brokoli",
    "Sabah: Peynir, zeytin, kepekli ekmek\nÖğle: Mercimek çorbası, ızgara sebzeler\nAkşam: Yoğurt, salata"
   };

        private string[] ortaKaloriProgramlar = new string[]
        {
    "Sabah: Peynir, zeytin, kepekli ekmek\nÖğle: Sebzeli tavuk sote\nAkşam: Izgara levrek, salata",
    "Sabah: Peynir, zeytin, kepekli ekmek\nÖğle: Bulgur pilavı, ızgara et, cacık\nAkşam: Tavuk, sebze sote",
    "Sabah: Süt, muz, fındık\nÖğle: Tavuklu makarna salatası\nAkşam: Izgara biftek, brokoli"
        };

        private string[] yuksekKaloriProgramlar = new string[]
        {
    "Sabah: Peynir, zeytin, kepekli ekmek\nÖğle: Fırında tavuk, pilav\nAkşam: Izgara somon, sebzeler",
    "Sabah: Peynir, zeytin, kepekli ekmek\nÖğle: Ispanaklı omlet, tam buğday ekmeği\nAkşam: Izgara hindi, mevsim salatası",
    "Sabah: Yumurta, tam buğday ekmeği, domates\nÖğle: Sebzeli mercimek köftesi\nAkşam: Izgara tavuk, brokoli"
        };

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKilo.Text) || string.IsNullOrEmpty(txtBoy.Text) || string.IsNullOrEmpty(txtYas.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double kilo = double.Parse(txtKilo.Text);
            double boy = double.Parse(txtBoy.Text);
            int yas = int.Parse(txtYas.Text);
            FizikselAktiviteDuzeyi fizikselAktiviteDuzeyi = (FizikselAktiviteDuzeyi)Enum.Parse(typeof(FizikselAktiviteDuzeyi), cmbAktiviteDuzeyi.SelectedItem.ToString());

            double kalori;
            if (rbdKadin.Checked)
            {
                kalori = HesaplaKadin(kilo, boy, yas, fizikselAktiviteDuzeyi);
                lblSonuc.Text = kalori.ToString("F2");
                SoruGonder(kalori);

            }
            else if (rbdErkek.Checked)
            {
                kalori = HesaplaErkek(kilo, boy, yas, fizikselAktiviteDuzeyi);
                lblSonuc.Text = kalori.ToString("F2");
                SoruGonder(kalori);
            }

        }
        private void btnProgram_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblSonuc.Text, out double kalori))
            {
                string yemekProgrami = "";

                if (kalori < 1500)
                {
                    Random random = new Random();
                    int index = random.Next(dusukKaloriProgramlar.Length);
                    yemekProgrami = dusukKaloriProgramlar[index];
                }
                else if (kalori < 2000)
                {
                    Random random = new Random();
                    int index = random.Next(ortaKaloriProgramlar.Length);
                    yemekProgrami = ortaKaloriProgramlar[index];
                }
                else
                {
                    Random random = new Random();
                    int index = random.Next(yuksekKaloriProgramlar.Length);
                    yemekProgrami = yuksekKaloriProgramlar[index];
                }

                MessageBox.Show($"Günlük Yemek Programınız:\n\n{yemekProgrami}", "Yemek Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kalori hesaplanmadı. Lütfen önce hesapla butonuna tıklayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SoruGonder(double kalori)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

                string soru = $"{kalori} kaloriye göre 1 günlük yemek programı ";
                string requestBody = $"{{ \"prompt\": \"{soru}\", \"min_tokens\": 100 }}";
                StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("ChatGPT Cevap: " + responseContent, "Cevap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ChatGPT ile iletişim hatası: " + response.ReasonPhrase, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtKilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public enum FizikselAktiviteDuzeyi
    {
        CokAz,
        Hafif,
        Orta,
        Yuksek,
        CokYuksek
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;

namespace PansiyonKayıtUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(kullanici.Text) || string.IsNullOrWhiteSpace(sifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL bağlantısı
            using (SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True"))
            {
                try
                {
                    baglanti.Open();
                    // SQL sorgusu
                    string sorgu = "SELECT COUNT(*) FROM admingiris WHERE kullanici = @Username AND sifre = @Password";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        // Parametreleri ekle
                        komut.Parameters.AddWithValue("@Username", kullanici.Text);
                        komut.Parameters.AddWithValue("@Password", sifre.Text);

                        // Sorguyu çalıştır ve sonucu al
                        int count = (int)komut.ExecuteScalar();

                        // Kullanıcı adı ve şifre doğru mu kontrol et
                        if (count > 0)
                        {
                            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Giriş başarılı ise ana formu aç
                            anaform mainForm = new anaform();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sayac--;
                            kullanici.Clear();
                            sifre.Clear();
                            if (sayac == 2)
                            {
                                MessageBox.Show("2 deneme hakkınız kaldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (sayac == 1)
                            {
                                MessageBox.Show("1 deneme hakkınız kaldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("DENEME HAKKINIZ KALMADI PROGRAMDAN ATILIYORSUNUZ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                                Application.Exit();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

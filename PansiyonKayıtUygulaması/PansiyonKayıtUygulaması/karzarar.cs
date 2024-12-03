using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonKayıtUygulaması
{
    public partial class karzarar : Form
    {
        public karzarar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(su.Text) || string.IsNullOrWhiteSpace(elektrik.Text) || string.IsNullOrWhiteSpace(doğalgaz.Text) || string.IsNullOrWhiteSpace(personel.Text) || string.IsNullOrWhiteSpace(internet.Text))
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select SUM(Mucret) as toplam from MusteriEkle", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ücret.Text = oku["toplam"].ToString();
                }
                baglanti.Close();


                int personelSayısı;
                personelSayısı = Convert.ToInt32(personel.Text);
                maaş.Text = (personelSayısı * 17000).ToString();

            int toplam;
            toplam = Convert.ToInt32(su.Text) + Convert.ToInt32(elektrik.Text) + Convert.ToInt32(doğalgaz.Text)+ Convert.ToInt32(internet.Text);
            faturatutar.Text = toplam.ToString();
        
          
            //toplam ürün fiyat
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select SUM(kahvaltıFiyatı+akşamYemeğiFiyatı+içecekFiyatı+atıştırmalıkFiyatı) as 'Toplam Fiyat' from stoklar where Gün=(select MAX(Gün) from stoklar)", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();


            while (oku1.Read())
            {
                ürüntutar.Text = oku1["Toplam Fiyat"].ToString();
            }
            baglanti.Close();


            //kar zarar hesaplama
            int durum;
            durum = Convert.ToInt32(ücret.Text) - Convert.ToInt32(maaş.Text) - Convert.ToInt32(ürüntutar.Text) - Convert.ToInt32(faturatutar.Text);
            sonuç.Text = durum.ToString();

            //kaar üzerinden %1 vergi alınıcak
            if (Convert.ToInt32(sonuç.Text) > 0)
            {
                double vergi;
                vergi = Convert.ToDouble(sonuç.Text) * 0.01;
                vergitutar.Text = vergi.ToString();
            }



        }

        private void faturatutar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void karzarar_Load(object sender, EventArgs e)
        {

        }
    }
}

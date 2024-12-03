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


namespace PansiyonKayıtUygulaması
{
    public partial class yenimusteriekle : Form
    {
        public yenimusteriekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");
        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renk dolu olduğunu gösterir");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renk boş olduğunu gösterir");
        }

         
       private void oda1_Click(object sender, EventArgs e)
        {
                textoda.Text = oda1.Text;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into oda1 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
        }
      
        private void oda2_Click(object sender, EventArgs e)
        {
            textoda.Text = oda2.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda2 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda3_Click(object sender, EventArgs e)
        {
            textoda.Text = oda3.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda3 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda4_Click(object sender, EventArgs e)
        {
            textoda.Text = oda4.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda4 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda5_Click(object sender, EventArgs e)
        {
            textoda.Text = oda5.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda5 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            textoda.Text = oda6.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda6 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            textoda.Text = oda7.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda7 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            textoda.Text = oda8.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda8 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            textoda.Text = oda9.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda9 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda10_Click(object sender, EventArgs e)
        {
            textoda.Text = oda10.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda10 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda11_Click(object sender, EventArgs e)
        {
            textoda.Text = oda11.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda11 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda12_Click(object sender, EventArgs e)
        {
            textoda.Text = oda12.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda12 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda13_Click(object sender, EventArgs e)
        {
            textoda.Text = oda13.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda13 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda14_Click(object sender, EventArgs e)
        {
            textoda.Text = oda14.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda14 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda15_Click(object sender, EventArgs e)
        {
            textoda.Text = oda15.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda15 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda16_Click(object sender, EventArgs e)
        {
            textoda.Text = oda16.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda16 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda17_Click(object sender, EventArgs e)
        {
            textoda.Text = oda17.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda17 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda18_Click(object sender, EventArgs e)
        {
            textoda.Text = oda18.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda18 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda19_Click(object sender, EventArgs e)
        {
            textoda.Text = oda19.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda19 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda20_Click(object sender, EventArgs e)
        {
            textoda.Text = oda20.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda20 (adi,soyadi) values ('" + textad.Text + "','" + textsoyad.Text + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textad.Text)||
               string.IsNullOrWhiteSpace(textsoyad.Text)|| 
               string.IsNullOrWhiteSpace(combocinsiyet.Text)||
               string.IsNullOrWhiteSpace(maskedtel.Text)||
               string.IsNullOrWhiteSpace(textmail.Text)||
               string.IsNullOrWhiteSpace(texttc.Text)||
               string.IsNullOrWhiteSpace(textoda.Text)||
               string.IsNullOrWhiteSpace(textucret.Text)||
               string.IsNullOrWhiteSpace(dategiris.Text)||
               string.IsNullOrWhiteSpace(datecıkıs.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into MusteriEkLe (Madi,Msoyadi,Mcinsiyet,Mtelefon,Mmail,Mtc,MOdaNo,Mucret,GirisTarihi,CikisTarihi) values('"
                + textad.Text + "','" + textsoyad.Text + "','" + combocinsiyet.Text + "','" + maskedtel.Text + "','" + textmail.Text + "','" + texttc.Text + "','" + textoda.Text + "','"
                + textucret.Text + "','" + dategiris.Value.ToString("yyyy-MM-dd") + "','" + datecıkıs.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı");

            textad.Clear();
            textsoyad.Clear();
            combocinsiyet.Text = "";
            maskedtel.Clear();
            textmail.Clear();
            texttc.Clear();
            textoda.Clear();
            textucret.Clear();


            for (int i = 1; i <= 20; i++)
            {
                string buttonName = "oda" + i.ToString();
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from oda" + i.ToString(), baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        button.Text = oku["adi"].ToString() + " " + oku["soyadi"].ToString();
                    }
                    baglanti.Close();

                    if (button.Text != i.ToString())
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }

            }

           


        }

        private void datecıkıs_ValueChanged(object sender, EventArgs e)
        {


            int ucret;

            DateTime kucukTarih = Convert.ToDateTime(dategiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(datecıkıs.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;
            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 700;
            textucret.Text = ucret.ToString();

        }
        
        private void yenimusteriekle_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 20; i++)
            {
                string buttonName = "oda" + i.ToString();
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from oda" + i.ToString(), baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        button.Text = oku["adi"].ToString() + " " + oku["soyadi"].ToString();
                    }
                    baglanti.Close();

                    if (button.Text != i.ToString())
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }

            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

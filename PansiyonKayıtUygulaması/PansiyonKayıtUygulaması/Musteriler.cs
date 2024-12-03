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
    public partial class Musteriler : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");

        public Musteriler()
        {
            InitializeComponent();
        }

        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Madi"].ToString());
                ekle.SubItems.Add(oku["Msoyadi"].ToString());
                ekle.SubItems.Add(oku["Mcinsiyet"].ToString());
                ekle.SubItems.Add(oku["Mtelefon"].ToString());
                ekle.SubItems.Add(oku["Mmail"].ToString());
                ekle.SubItems.Add(oku["Mtc"].ToString());
                ekle.SubItems.Add(oku["MOdaNo"].ToString());
                ekle.SubItems.Add(oku["Mucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["aktifMi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            veriGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tcno.Text))
            {
                MessageBox.Show("Lütfen bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Mtc like '%" + tcno.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Madi"].ToString());
                ekle.SubItems.Add(oku["Msoyadi"].ToString());
                ekle.SubItems.Add(oku["Mcinsiyet"].ToString());
                ekle.SubItems.Add(oku["Mtelefon"].ToString());
                ekle.SubItems.Add(oku["Mmail"].ToString());
                ekle.SubItems.Add(oku["Mtc"].ToString());
                ekle.SubItems.Add(oku["MOdaNo"].ToString());
                ekle.SubItems.Add(oku["Mucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["aktifMi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            combocinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedtel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            texttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textoda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dategiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datecıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
            

        }
       


        private void sil_Click(object sender, EventArgs e)
        {
            
                for (int i = 1; i <= 20; i++)
                {
                    if (textoda.Text == i.ToString())
                    { 
                        
                       
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("delete from oda"+i.ToString(), baglanti);
                        komut.ExecuteNonQuery();
                    
                    
                        SqlCommand komutGuncelle = new SqlCommand("update MusteriEkle set aktifMi=0 where MOdaNo=" + i.ToString(), baglanti);
                        komutGuncelle.ExecuteNonQuery();
                        baglanti.Close();
                        veriGoster();

                    }
                }
         
           

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textad.Clear();
            textsoyad.Clear();
            combocinsiyet.Text = "";
            maskedtel.Clear();
            textmail.Clear();
            texttc.Clear();
            textoda.Clear();
            textucret.Clear();
            dategiris.Text = "";
            datecıkıs.Text = "";
        }

       
        private void guncelle_Click(object sender, EventArgs e)
        { 
            

            baglanti.Open();
            // Müşteri bilgilerini güncelle
            SqlCommand komut = new SqlCommand("update MusteriEkle set Madi='" + textad.Text + "',Msoyadi='" + textsoyad.Text + "',Mcinsiyet='" + combocinsiyet.Text +
                "',Mtelefon='" + maskedtel.Text + "',Mmail='" + textmail.Text + "' ,Mtc='" + texttc.Text + "',MOdaNo='" + textoda.Text + "',Mucret='" + textucret.Text +
                "',GirisTarihi='" + dategiris.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + datecıkıs.Value.ToString("yyyy-MM-dd") + "' where MusteriId=" + id, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            // Yeni oda numarasına veriyi ekle
            SqlCommand komutEkle = new SqlCommand("insert into oda" + textoda.Text + " (adi,soyadi) values('" + textad.Text + "','" + textsoyad.Text + "')", baglanti);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            veriGoster();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();
        }

        private void datecıkıs_ValueChanged(object sender, EventArgs e)
        {
            int ucret;

            DateTime kucukTarih = Convert.ToDateTime(dategiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(datecıkıs.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;
             label17.Text= sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label17.Text) * 700;
            textucret.Text = ucret.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult diyalog = MessageBox.Show("Tüm verileri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (diyalog == DialogResult.Yes)
            {
               
                baglanti.Open();

             
                SqlCommand komut = new SqlCommand("DELETE FROM MusteriEkle", baglanti);

              
                komut.ExecuteNonQuery();

             
                baglanti.Close();

                listView1.Items.Clear();

              
                MessageBox.Show("Tüm veriler başarıyla silindi.");
            }

         
        }

        public void Musteriler_Load(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tut.Text = Convert.ToString(textoda.Text);
            baglanti.Open();
            // Eski oda numarasındaki veriyi sil
            SqlCommand komutSil = new SqlCommand("delete from oda" + tut.Text, baglanti);
            komutSil.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}

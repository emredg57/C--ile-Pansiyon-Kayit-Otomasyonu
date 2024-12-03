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

namespace PansiyonKayıtUygulaması
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (string.IsNullOrWhiteSpace(kahvaltı.Text) || string.IsNullOrWhiteSpace(akşam.Text) || string.IsNullOrWhiteSpace(içecek.Text)
                || string.IsNullOrWhiteSpace(atıştırmalık.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stoklar (kahvaltıFiyatı,akşamYemeğiFiyatı,içecekFiyatı,atıştırmalıkFiyatı) values ('"
                + kahvaltı.Text + "','" + akşam.Text + "','" + içecek.Text + "','" + atıştırmalık.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fiyat kayıtları yapıldı");

            veriGoster();
            kahvaltı.Clear();
            akşam.Clear();
            içecek.Clear();
            atıştırmalık.Clear();
        }
        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gün"].ToString();
                ekle.SubItems.Add(oku["kahvaltıFiyatı"].ToString());
                ekle.SubItems.Add(oku["akşamYemeğiFiyatı"].ToString());
                ekle.SubItems.Add(oku["içecekFiyatı"].ToString());
                ekle.SubItems.Add(oku["atıştırmalıkFiyatı"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            sveriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult diyalog = MessageBox.Show("Tüm verileri silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(diyalog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from stoklar",baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();
                listView1.Items.Clear();

                MessageBox.Show("Tüm veriler başarıyla silindi.");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

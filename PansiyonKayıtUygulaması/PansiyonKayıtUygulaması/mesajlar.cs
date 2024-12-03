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
using System.Drawing.Text;

namespace PansiyonKayıtUygulaması
{
    public partial class mesajlar : Form
    {
        public mesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void veriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesajlar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["adSoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mesajlar_Load(object sender, EventArgs e)
        {
            veriGoster();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(adsoyad.Text) || string.IsNullOrWhiteSpace(mesaj.Text))
            {
                MessageBox.Show("Boş alanları doldurmadan kaydedemezsiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into mesajlar (adSoyad,mesaj) values('"+adsoyad.Text+ "','" +mesaj.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgi başarıyla kaydedildi.", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            veriGoster();
            mesaj.Clear();
            adsoyad.Clear();
        }
        private void veriSil()
        {

            // ListView'de herhangi bir öğe seçilmiş mi kontrol eder
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçilen öğeyi alır
                ListViewItem seç = listView1.SelectedItems[0];

                // Seçilen öğenin ID'sini alır
                int id = int.Parse(seç.SubItems[0].Text);

                // ListView'den öğeyi kaldır
                listView1.Items.Remove(seç);


                // Veritabanından da silmek için
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from mesajlar where id=@id ", baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();

                }
                catch(Exception e)
                {
                    MessageBox.Show("Bir hata oluştu." + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Seçilen öge başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            adsoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            mesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriSil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

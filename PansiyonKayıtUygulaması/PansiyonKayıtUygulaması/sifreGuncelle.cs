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
    public partial class sifreGuncelle : Form
    {
        public sifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(kullanıcı.Text)|| string.IsNullOrWhiteSpace(sifre.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            baglanti.Open();
            SqlCommand komut = new SqlCommand("update admingiris set kullanici='" +kullanıcı.Text+ "', sifre='" +sifre.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı adınızı veya şifrenizi güncellediniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kullanıcı.Clear();
            sifre.Clear();

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
    }
}

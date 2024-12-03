using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayıtUygulaması
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenimusteriekle ekle = new yenimusteriekle();
            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 oda = new Form2();
            oda.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hakkimizda hak = new Hakkimizda();
            hak.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString();
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            karzarar kar = new karzarar();
            kar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Sinop");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sifreGuncelle guncelle = new sifreGuncelle();
            guncelle.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mesajlar mesaj = new mesajlar();
            mesaj.Show();
            this.Hide();
        }
    }
}

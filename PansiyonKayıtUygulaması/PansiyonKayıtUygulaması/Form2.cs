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
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EMRE-PC;Initial Catalog=pansiyonotamasyon;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            anaform ana = new anaform();
            ana.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oda1_Click(object sender, EventArgs e)
        {

        }
    }
}

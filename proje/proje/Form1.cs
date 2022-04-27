using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.;Database=superleague;Trusted_Connection=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            lsttakımlar.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand takımgetir = new SqlCommand("select * from Takımlar", baglanti);
            SqlDataReader dr = takımgetir.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string film = (String)dr["TakımAdi"];
                    lsttakımlar.Items.Add(film);
                }
            }






            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }



        }
        //EkLE
        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand takımekle = new SqlCommand("insert Takımlar(TakımAdi)values('" + txttakım.Text + "') ", baglanti);
            int sonuc = takımekle.ExecuteNonQuery();
            MessageBox.Show(sonuc.ToString() + "    satır eklendi");





            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }


        //Sil

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlCommand takımsil = new SqlCommand("delete from Takımlar where TakımAdi='" + lsttakımlar.SelectedItem.ToString() + "'", baglanti);
            int sonuc = takımsil.ExecuteNonQuery();
            MessageBox.Show(sonuc.ToString() + "  adet veri silindi");






            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        //düzenle
        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand düzenle = new SqlCommand("update Takımlar set TakımAdi='" + txttakım.Text + "' where TakımAdi='" + lsttakımlar.SelectedItem.ToString() + "' ", baglanti);
            int sonuc = düzenle.ExecuteNonQuery();
            MessageBox.Show(sonuc.ToString() + "  adet veri güncellendi");



            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void lsttakımlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void Oyuncular_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

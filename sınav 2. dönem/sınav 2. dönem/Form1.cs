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

namespace sınav_2.dönem
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=dbsınav;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileriyükle();
            
        }
        private void verileriyükle()
        {
            baglanti.Open();
            SqlCommand getData = new SqlCommand("select * from tblsınav", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getData);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            baglanti.Close();
        }
        private void işlem()
        {

  
            double sonuc;
            double sayi1 = Convert.ToInt32(txtvalue1.Text);
            double sayi2 = Convert.ToInt32(txtvalue2.Text);
            double sayi3 = Convert.ToInt32(txtvalue3.Text);
            double sayi4 = Convert.ToInt32(txtvalue4.Text);



            sonuc = sayi1 / sayi2 + sayi3 / sayi4;



            lblsonuc.Text = sonuc.ToString();

        }
        
        private void ekle()
        {
            baglanti.Open();
            SqlCommand addData = new SqlCommand("insert tblsınav values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            addData.Parameters.AddWithValue("@p1", txtvalue1.Text);
            addData.Parameters.AddWithValue("@p2", txtvalue2.Text);
            addData.Parameters.AddWithValue("@p3", txtvalue3.Text);
            addData.Parameters.AddWithValue("@p4", txtvalue4.Text);
            addData.Parameters.AddWithValue("@p5", lblsonuc.Text);           
            addData.ExecuteNonQuery();
            baglanti.Close();
            sıfırla();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            işlem();
            ekle();
            sıfırla();
            verileriyükle();
        }

        private void sıfırla()
        {
            txtvalue1.Text = "";
            txtvalue2.Text = "";
            txtvalue3.Text = "";
            txtvalue4.Text = "";
        }



        
        
    }
}

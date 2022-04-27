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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=SuperLeague;Trusted_Connection=True;");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            takımisim.Items.Clear();
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
                    takımisim.Items.Add(film);
                }
            }






            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void takımisim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From oyuncular", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "oyuncular");
            oyuncu.DataSource = ds.Tables[0];
            baglanti.Close();



        }

        private void oyuncu_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}

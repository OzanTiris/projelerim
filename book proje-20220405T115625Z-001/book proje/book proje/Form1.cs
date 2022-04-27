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
namespace book_proje
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbcizgi;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnlist_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TblBook", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblBook (BookName,BookAuthor,BookPrice) values (@p1,@p2,@p3)", connection);
       
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p2", txtAuthor.Text);
            command.Parameters.AddWithValue("@p3", txtPrice.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap Eklendi");
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblBook Where BookID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtkitapıd.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");

            connection.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TblBook set BookName=@p1,BookAuthor=@p3,BookPrice=@p4 where BookID=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p2", txtkitapıd.Text);
            command.Parameters.AddWithValue("@p3", txtAuthor.Text);
            command.Parameters.AddWithValue("@p4", txtPrice.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            connection.Close();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

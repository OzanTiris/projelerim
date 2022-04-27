using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Gray;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Sinan Engin ile Beyaz Futbol";

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Sinan Engin";
        }
    }
}

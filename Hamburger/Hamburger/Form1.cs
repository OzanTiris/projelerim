using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cocukboy = 5, etli = 20, tavuk = 15,sekersizcola=7,cola=7, ayran=4, pk=6,sh=5;

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            toplam += pk;
            label1.Text = toplam.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            toplam += sh;
            label1.Text = toplam.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            toplam += sekersizcola;
            label1.Text = toplam.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            toplam += cola;
            label1.Text = toplam.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            toplam += cola;
            label1.Text = toplam.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            toplam += 0;
            label1.Text = toplam.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toplam += etli;
            label1.Text = toplam.ToString();
       
        }

        double toplam = 0;
 

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                groupBox3.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toplam += cocukboy;
            label1.Text = toplam.ToString();

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                groupBox1.Enabled = true;
            }
            if (checkBox1.Checked==false)
            {
                groupBox1.Enabled = false;
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }
    }
}

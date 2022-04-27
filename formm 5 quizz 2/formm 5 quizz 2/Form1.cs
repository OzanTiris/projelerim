using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formm_5_quizz_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int süresay, devir;
        private void Form1_Load(object sender, EventArgs e)
        {
            süresay = 30;
            SÜRE.Enabled = true;
            SÜRE.Interval = 400;
            K.Text = "";
            S.Text = "";
            Y.Text = "";
            SAYAÇ.Text = süresay.ToString();
            K.BackColor = Color.Red;
            S.BackColor = Color.Black;
            Y.BackColor = Color.Black;
            SAYAÇ.BackColor = Color.LightBlue;
        }

        private void SÜRE_Tick(object sender, EventArgs e)
        {
            if (devir == 0)
            {
                if (süresay == 2)
                    S.BackColor = Color.Yellow;
                if (süresay == 0)
                {
                    K.BackColor = Color.Black;
                    S.BackColor = Color.Black;
                    Y.BackColor = Color.Green;
                    süresay = 30;
                    devir = 1;
                }
            }
            if (devir == 1)
            {
                if (süresay == 2)
                    S.BackColor = Color.Yellow;
                if (süresay == 0)
                {
                    K.BackColor = Color.Red;
                    S.BackColor = Color.Black;
                    Y.BackColor = Color.Black;
                    süresay = 30;
                    devir = 0;
                }
            }
            SAYAÇ.Text = süresay.ToString();
            süresay = süresay - 1;
        }
    }

   
}

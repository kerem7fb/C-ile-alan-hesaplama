using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uk, kk;
            int alan, cevre;
            kk = Convert.ToInt32(textBox1.Text);
            uk = Convert.ToInt32(textBox2.Text);
            alan = uk * kk;
            cevre = 2 * (uk + kk);
            label7.Text = alan.ToString();
            label6.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar;
            int alan, cevre;
            kenar = Convert.ToInt32(textBox4.Text);
            alan = kenar * kenar;
            cevre = 4 * kenar;
            label9.Text = alan.ToString();
            label8.Text = cevre.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double pi, yarıcap;
            double alan, cevre;
            pi = 3.14;
            yarıcap = Convert.ToDouble(textBox9.Text);
            alan = pi * yarıcap * yarıcap;
            cevre = 2 * pi * yarıcap;
            label29.Text = alan.ToString();
            label28.Text = cevre.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            double taban, yukseklık, alan;
            taban = Convert.ToDouble(textBox13.Text);
            yukseklık = Convert.ToDouble(textBox12.Text);
            alan = (taban * yukseklık) / 2;
            label43.Text = alan.ToString();

        }
    }
}

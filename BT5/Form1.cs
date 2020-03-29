using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class Form1 : Form
    {
        string TinhToan(string s1, string s2, int PhepToan)
        {
            
            switch (PhepToan)
            {
                case 1:
                    s1 = (double.Parse(s1) + double.Parse(s2)).ToString();
                    break;
                case 2:
                    s1 = (double.Parse(s1) - double.Parse(s2)).ToString();
                    break;
                case 3:
                    s1 = (double.Parse(s1) * double.Parse(s2)).ToString();
                    break;
                case 4:
                    s1 = (double.Parse(s1) / double.Parse(s2)).ToString();
                    break;
            }
            return s1;
        }
        public Form1()
        {
            InitializeComponent();
        }
        string s1, s2;
        int KiemTra1 = 0;
        int KiemTra2 = 0;
        int PhepToan;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            if (KiemTra1 == 0) textBox1.Text = textBox1.Text + ".";
            KiemTra1++;
            KiemTra2++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "1";
            KiemTra2++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "2";
            KiemTra2++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "3";
            KiemTra2++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "4";
            KiemTra2++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "5";
            KiemTra2++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "6";
            KiemTra2++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "7";
            KiemTra2++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "8";
            KiemTra2++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "9";
            KiemTra2++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            s1 = null;
            s2 = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (KiemTra2 == 0) textBox1.Text = null;
            textBox1.Text = textBox1.Text + "0";
            KiemTra2++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = textBox1.Text;
                PhepToan = 1;
                KiemTra1 = KiemTra2 = 0;
            }
            else
            {
                textBox1.Text = TinhToan(s1, textBox1.Text, PhepToan);
                PhepToan = 1;
                KiemTra1 = KiemTra2 = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = textBox1.Text;
                PhepToan = 2;
                KiemTra1 = KiemTra2 = 0;
            }
            else
            {
                textBox1.Text = TinhToan(s1, textBox1.Text, PhepToan);
                PhepToan = 2;
                KiemTra1 = KiemTra2 = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = textBox1.Text;
                PhepToan = 3;
                KiemTra1 = KiemTra2 = 0;
            }
            else
            {
                textBox1.Text = TinhToan(s1, textBox1.Text, PhepToan);
                PhepToan = 3;
                KiemTra1 = KiemTra2 = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (s1 == null)
            {
                s1 = textBox1.Text;
                PhepToan = 4;
                KiemTra1 = KiemTra2 = 0;
            }
            else
            {
                textBox1.Text = TinhToan(s1, textBox1.Text, PhepToan);
                PhepToan = 4;                
                KiemTra1 = KiemTra2 = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = TinhToan(s1, textBox1.Text, PhepToan);
            KiemTra1 = KiemTra2 = 0;
            s1 = null;
        }

       
        }
    
}

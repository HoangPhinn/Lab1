using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long[] a = new long[11];

        string Them(long b, string KQ)
        {
            switch (b)
            {
                case 0:
                    KQ = " Khong";
                    break;
                case 1:
                    KQ = " Mot";
                    break;
                case 2:
                    KQ = " Hai";
                    break;
                case 3:
                    KQ = " Ba";
                    break;
                case 4:
                    KQ = " Bon";
                    break;
                case 5:
                    KQ = " Nam";
                    break;
                case 6:
                    KQ = " Sau";
                    break;
                case 7:
                    KQ = " Bay";
                    break;
                case 8:
                    KQ = " Tam";
                    break;
                case 9:
                    KQ = " Chin";
                    break;
            }
            return KQ;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string KQ = null;
            
            string s1Text = textBox1.Text;
            long s1Int = long.Parse(s1Text);
            long x = Math.Abs(s1Int);

            if (x < -9999999999 || x > 9999999999) textBox2.Text = "Nhap sai vui long nhap lai";
            else
            {
                for (int i = 0; i < s1Text.Length; i++)
                {
                    a[i] = x % 10;
                    x = (x - a[i]) / 10;
                }

                for (int i = 0 ; i < s1Text.Length; i++)
                {
                    if (i == 3) KQ = " Ngin" + KQ;
                    if (i == 6) KQ = " Trieu" + KQ;
                    if (i == 9) KQ = " Ty" + KQ;

                    if (i == 2 || i == 8 || i == 5) KQ = " Tram" + KQ;

                    if (i == 1 || i == 4 || i == 7)
                    {
                        if (a[i] == 0) KQ = " Linh" + KQ;
                        else if (a[i] == 1) KQ = " Muoi" + KQ;
                        else KQ = Them(a[i], KQ) + " Muoi" + KQ;
                    }
                    else KQ = Them(a[i], KQ) + KQ;
                     

                }
                if (s1Int >= 0) textBox2.Text = KQ;
                else textBox2.Text = "Am" + KQ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

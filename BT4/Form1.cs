using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1text = textBox1.Text;
            string s2text = textBox2.Text;

            int s1Int = int.Parse(s1text);
            int s2Int = int.Parse(s2text);
            int A = 1;
            int B = 1;
            int S1 = 0;
            int S2 = 0;
            double S3 = 0;

            for (int i = 1; i <= s1Int; i++)
            {
                A = A * i;
            }
            for (int i = 1; i <= s2Int; i++)
            {
                B = B * i;
            }
            for (int i = 1; i <= s1Int; i++)
            {
                S1 = S1 + i;
            }
            for (int i = 1; i <= s2Int; i++)
            {
                S2 = S2 + i;
            }
            for (int i = 1; i <= s2Int; i++)
            {
                S3 = S3 + (Math.Pow(s1Int, i));
            }

            textBox3.Text = A.ToString();
            textBox4.Text = B.ToString();
            textBox5.Text = S1.ToString();
            textBox6.Text = S2.ToString();
            textBox7.Text = S3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

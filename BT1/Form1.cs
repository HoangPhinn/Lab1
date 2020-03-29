using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1Text = textBox1.Text;
            string s2Text = textBox2.Text;
            string s3Text = textBox3.Text;

            double s1Double = double.Parse(s1Text);
            double s2Double = double.Parse(s2Text);
            double s3Double = double.Parse(s3Text);

            double max = 0;
            double min = 0;
            if (s1Double > s2Double)
            {
                max = s1Double;
                min = s2Double;
            }
            else
            {
                min = s1Double;
                max = s2Double;
            }
            if (max < s3Double) max = s3Double;
            if (min > s3Double) min = s3Double;

            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

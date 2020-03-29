using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double i, j;
private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1Text = textBox1.Text;
            double s1Double = double.Parse(s1Text);
           

            if (comboBox1.Text == "USD (Do-la My)") i = s1Double * 22772;
            if (comboBox1.Text == "EUR (Euro)") i = s1Double * 28132;
            if (comboBox1.Text == "GBP (Bang Anh)") i = s1Double * 31538;
            if (comboBox1.Text == "SGD (Do-la Singapore)") i = s1Double * 17286;
            if (comboBox1.Text == "JPY  (Yen Nhat)") i = s1Double * 214;
            if (comboBox1.Text == "VND (Viet Nam Dong)") i = s1Double;

            if (comboBox2.Text == "USD (Do-la My)") j = i / 22772;
            if (comboBox2.Text == "EUR (Euro)") j = i / 28132;
            if (comboBox2.Text == "GBP (Bang Anh)") j = i / 31538;
            if (comboBox2.Text == "SGD (Do-la Singapore)") j = i / 17286;
            if (comboBox2.Text == "JPY  (Yen Nhat)") j = i / 214;
            if (comboBox2.Text == "VND (Viet Nam Dong)") j = i;

            textBox2.Text = j.ToString();

        }
    }
}

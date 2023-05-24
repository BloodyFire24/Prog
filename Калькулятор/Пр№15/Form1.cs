using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char sign = ' ';
        public double a, b, c;

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (sign == ' ')
            {
                sign = '+';
            }
            switch (sign)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            textBox3.Text = Convert.ToString(c).Replace(".", ",");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sign = Convert.ToChar(btn.Text);
            label1.Text = btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (sign == ' ')
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + btn.Text;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            sign = ' ';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sign == ' ')
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
            else
            {
                if (textBox2.Text[0] == '-')
                {
                    textBox2.Text = textBox2.Text.Remove(0, 1);
                }
                else
                {
                    textBox2.Text = '-' + textBox2.Text;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sign == ' ')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sign == ' ')
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0,";
                }
                else
                {
                    if (textBox1.Text.Contains(',') == false)
                    {
                        textBox1.Text = textBox1.Text + button11.Text;
                    }
                }
            }
            else
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0,";
                }
                else
                {
                    if (textBox2.Text.Contains(',') == false)
                    {
                        textBox2.Text = textBox2.Text + button11.Text;
                    }
                }
            }
        }
    }
}

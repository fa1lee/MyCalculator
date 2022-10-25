using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a; //  Объявление переменных

        int count;     

        bool sign = true;    

        Label label1 = new Label(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 1;
            }
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                a = double.Parse(textBoxTab.Text);
                textBoxTab.Text = "";
                count = 1;
                label1.Text = a.ToString() + "+";
                sign = true;
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                a = double.Parse(textBoxTab.Text);
                textBoxTab.Text = "";
                count = 2;
                label1.Text = a.ToString() + "-";
                sign = true;
            }
        }

        private void buttonxxx_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                a = double.Parse(textBoxTab.Text);
                textBoxTab.Text = "";
                count = 3;
                label1.Text = a.ToString() + "*";
                sign = true;
            }
        }

        private void buttondevide_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                a = double.Parse(textBoxTab.Text);
                textBoxTab.Text = "";
                count = 4;
                label1.Text = a.ToString() + "/";
                sign = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                textBoxTab.Text = "";
                label1.Text = "";
                a = 0;
            }
        }

        private void buttonplmn_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                if (sign == true)
                {
                    textBoxTab.Text = "-" + textBoxTab.Text;
                    sign = false;
                }
                else if (sign == false)
                {
                    textBoxTab.Text = textBoxTab.Text.Replace("-", "");
                    sign = true;
                }
            }
        }

        public calc calc = new calc();

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text += "5";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 0;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 9;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 8;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 7;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 6;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 4;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text.Length < 9)
            {
                textBoxTab.Text = textBoxTab.Text + 2;
            }
        }

        private void buttoneq_Click(object sender, EventArgs e)
        {
            if (textBoxTab.Text == "")
            {
                textBoxTab.Text = "";
            }
            else
            {
                if (textBoxTab.Text.Length < 9)
                {
                    textBoxTab.Text = calc.Calcc(count, a, textBoxTab.Text);
                    label1.Text = "";
                }
                else
                {
                    textBoxTab.Text = "EXCEEDED";
                }
            }
        }


    }
}

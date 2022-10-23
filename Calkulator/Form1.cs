using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;         //тип с плавающей точкой
        int count;          //целочисленный тип
        bool znak = true;   //меняет знак числа ( true — положительное число,false — отрицательное число)

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonTochka_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
            }
        }

        private void buttonResalt_Click(object sender, EventArgs e)
        {
            tcalculate();
            textBox1.Text = "";
        }

        private void tcalculate()
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a % double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void buttonPlas_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat(textBox1.Text))
            {
                a = double.Parse(textBox1.Text);
                count = 1;
                textBox1.Text += '+';
                znak = true;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat(textBox1.Text))
            {
                a = double.Parse(textBox1.Text);
                count = 2;
                textBox1.Text += '-';
                znak = true;
            }
        }

        private void buttonMnojit_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat(textBox1.Text))
            {
                a = double.Parse(textBox1.Text);
                count = 3;
                textBox1.Text += 'x';
                znak = true;
            }
        }

        private void buttonDiliti_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat(textBox1.Text))
            {
                a = double.Parse(textBox1.Text);
                count = 4;
                textBox1.Text += '/';
                znak = true;
            }
        }
         
        private void buttonZnak_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void buttonPresent_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat(textBox1.Text))
            {
                a = double.Parse(textBox1.Text);
                count = 5;
                textBox1.Text += '%';
                znak = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private bool CheckActionForRepeat(string text)
        {
            if(text.Contains("-"))
            {
                return false;
            }
            if (text.Contains("+"))
            {
                return false;
            }
            if (text.Contains("x"))
            {
                return false;
            }
            if (text.Contains("/"))
            {
                return false;
            }
            if (text.Contains("%"))
            {
                return false;
            }

            return true;
        }
    }  
}

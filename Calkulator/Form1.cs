using System;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = " ";
        }

        public double number;//число
        public char action = ' ';//действие которое мы будем выполнять
        bool znak = true;//меняет знак числа ( true — положительное число,false — отрицательное число)
        bool numberCheck;//проверяет какое число мы сейчас заполняем
        bool tockaCheck;//проверяет на точку

        private void button0_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()) && numberCheck)
            {
                DeleteText();
            }

            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonTochka_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") == -1 && tockaCheck == false)
            {
                textBox1.Text += ",";

                tockaCheck = true;
            }
        }

        private void buttonResalt_Click(object sender, EventArgs e)
        {
            tcalculate();
        }

        public void tcalculate()
        {
            if ("x/+-".Contains(textBox1.Text[textBox1.Text.Length - 1].ToString()))
            {
                return;
            }

            switch (action)
            {
                case '+':
                    number += double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                    numberCheck = false;
                    tockaCheck = false;
                    znak = true;
                    action = ' ';
                    break;
                case '-':
                    number -= double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                    numberCheck = false;
                    tockaCheck = false;
                    znak = true;
                    action = ' ';
                    break;
                case 'x':
                    number *= double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                    numberCheck = false;
                    tockaCheck = false;
                    znak = true;
                    action = ' ';
                    break;
                case '/':
                    number /= double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                    numberCheck = false;
                    tockaCheck = false;
                    znak = true;
                    action = ' ';
                    break;
                case '%':
                    number %= double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                    numberCheck = false;
                    tockaCheck = false;
                    znak = true;
                    action = ' ';
                    break;
                default:
                    break;
            }
        }

        private void buttonPlas_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat() && ActionIsNotFirst())
            {
                if (numberCheck == false)
                {
                    AddNumber();
                    action = '+';
                    textBox1.Text += '+';
                    znak = true;
                    numberCheck = true;
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat() && ActionIsNotFirst())
            {
                if (numberCheck == false)
                {
                    AddNumber();
                    action = '-';
                    textBox1.Text += '-';
                    znak = true;
                    numberCheck = true;
                }
            }
        }

        private void buttonMnojit_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat() && ActionIsNotFirst())
            {
                if (numberCheck == false)
                {
                    AddNumber();
                    action = 'x';
                    textBox1.Text += 'x';
                    znak = true;
                    numberCheck = true;
                }
            }
        }

        private void buttonDiliti_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat() && ActionIsNotFirst())
            {
                if (numberCheck == false)
                {
                    AddNumber();
                    action = '/';
                    textBox1.Text += '/';
                    znak = true;
                    numberCheck = true;
                }
            }
        }

        private void buttonZnak_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text.Trim();
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Trim().Replace("-", "");
                znak = true;
            }
        }

        private void buttonPresent_Click(object sender, EventArgs e)
        {
            if (CheckActionForRepeat() && ActionIsNotFirst())
            {
                number = double.Parse(textBox1.Text);
                textBox1.Text += '%';
                znak = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            number = 0;
            numberCheck = false;
            tockaCheck = false;
            znak = true;
            action = ' ';
        }

        private bool ActionIsNotFirst()
        {
            if (char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]))
            {
                return true;
            }

            return false;
        }

        private bool CheckActionForRepeat()
        {
            if (action == '-')
            {
                return false;
            }
            if (action == '+')
            {
                return false;
            }
            if (action == 'x')
            {
                return false;
            }
            if (action == '/')
            {
                return false;
            }
            if (action == '%')
            {
                return false;
            }

            return true;
        }

        private void AddNumber()
        {
            number = double.Parse(textBox1.Text);
        }

        private void DeleteText()
        {
            textBox1.Clear();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calkulator;

namespace test_calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10and5return15()
        {
            double number1 = 10, number2 = 5;

            string excpected = "15";

            Form1 f = new Form1();

            f.number = number1;

            f.action = '+';

            f.textBox1.Text = number2.ToString();

            f.tcalculate();

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");
                               
        }
        [TestMethod]
        public void Min_10and5return5()
        {
            double number1 = 10, number2 = 5;

            string excpected = "5";

            Form1 f = new Form1();

            f.number = number1;

            f.action = '-';

            f.textBox1.Text = number2.ToString();

            f.tcalculate();

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");

        }
        [TestMethod]
        public void Dilit_10and5return2()
        {
            double number1 = 10, number2 = 5;

            string excpected = "2";

            Form1 f = new Form1();

            f.number = number1;

            f.action = '/';

            f.textBox1.Text = number2.ToString();

            f.tcalculate();

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");

        }
        [TestMethod]
        public void Mnojit_10and5return50()
        {
            double number1 = 10, number2 = 5;

            string excpected = "50";

            Form1 f = new Form1();

            f.number = number1;

            f.action = 'x';

            f.textBox1.Text = number2.ToString();

            f.tcalculate();

            string actual = f.textBox1.Text;

            Assert.AreEqual(excpected, actual, "test is not correct");

        }

    }
}

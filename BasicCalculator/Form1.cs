using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //A string to store user input
        string operand1 = string.Empty;     //A string to store the first operand
        string operand2 = string.Empty;     //A string to store the second operand
        char operation;                     //A char to store the operation
        double result = 0.0;                //The calculated result


        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "1";
            this.textBox.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "2";
            this.textBox.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "3";
            this.textBox.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "4";
            this.textBox.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "5";
            this.textBox.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "6";
            this.textBox.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "7";
            this.textBox.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "8";
            this.textBox.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "9";
            this.textBox.Text += input;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "0";
            this.textBox.Text += input;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "Cannot Divide by Zero!";
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}

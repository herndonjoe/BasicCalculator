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
            input += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            input += "0";
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

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }
}

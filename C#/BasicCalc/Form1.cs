using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string firstarg = "";
        string secondarg = "";
        string input = "";
        float result = 0;
        char func;

        private void oneButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "1";
            CalcDisplay.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "2";
            CalcDisplay.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "3";
            CalcDisplay.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "4";
            CalcDisplay.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "5";
            CalcDisplay.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "6";
            CalcDisplay.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "7";
            CalcDisplay.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "8";
            CalcDisplay.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "9";
            CalcDisplay.Text += input;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            input += "0";
            CalcDisplay.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            input += ",";
            CalcDisplay.Text += input;
        }

        float firstNum, secondNum;

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondarg = input;

            //Plus
            if (func == '+')
            {
                secondNum = float.Parse(CalcDisplay.Text);
                result = firstNum + secondNum;
                CalcDisplay.Text = result.ToString();
            }
            //Minus
            else if (func == '-')
            {
                secondNum = float.Parse(CalcDisplay.Text);
                result = firstNum - secondNum;
                CalcDisplay.Text = result.ToString();
            }
            //Multiply
            else if (func == '*')
            {
                secondNum = float.Parse(CalcDisplay.Text);
                result = firstNum * secondNum;
                CalcDisplay.Text = result.ToString();
            }
            //Divide
            else if (func == '/')
            {
                secondNum = float.Parse(CalcDisplay.Text);
                if (secondNum == '0')
                {
                    CalcDisplay.Text = "Never divide by 0";
                }
                else
                {
                    result = firstNum / secondNum;
                    CalcDisplay.Text = result.ToString();
                }
            }
            //Square
            else if (func == '^')
            {
                firstNum = float.Parse(CalcDisplay.Text);
                result = firstNum * firstNum;
                CalcDisplay.Text = result.ToString();
            }
            //Squareroot
            else if (func == '$')
            {
                firstNum = float.Parse(CalcDisplay.Text);
                result = (float)Math.Sqrt(firstNum);
                CalcDisplay.Text = result.ToString();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(CalcDisplay.Text);
            func = '-';
            firstarg = input;
            input = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(CalcDisplay.Text);
            func = '+';
            firstarg = input;
            input = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(CalcDisplay.Text);
            func = '*';
            firstarg = input;
            input = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(CalcDisplay.Text);
            func = '/';
            firstarg = input;
            input = "";
        }

        private void squarerootButton_Click(object sender, EventArgs e)
        {
            func = '$';
            firstarg = input;
            input = "";
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            func = '^';
            firstarg = input;
            input = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstarg = "";
            secondarg = "";
            input = "";
            result = 0;
            CalcDisplay.Text = "0";
        }
    }
}

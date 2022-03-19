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

        float firstarg;
        float secondarg;
        float result = 0;
        char func;
        bool dec = false;

        private void changeLabel(int numPressed)
        {
            if(dec == true)
            {
                int decCount = 0;
                foreach (char c in CalcDisplay.Text)
                {
                    if (c == '.')
                    {
                        decCount++;
                    }
                }
                if(decCount < 1)
                {
                    CalcDisplay.Text = CalcDisplay.Text + ".";
                }
                dec = false;
            }
            else
            {
                if (CalcDisplay.Text.Equals("0") == true && CalcDisplay.Text != null)
                {
                    CalcDisplay.Text = numPressed.ToString();
                }
                else if (CalcDisplay.Text.Equals("-0") == true)
                {
                    CalcDisplay.Text = "-" + numPressed.ToString();
                }
                else
                {
                    CalcDisplay.Text = CalcDisplay.Text + numPressed.ToString();
                }
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
            /*
            CalcDisplay.Text = "";
            input += "0";
            CalcDisplay.Text += input;
            */
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if(CalcDisplay.Text.Equals("0") == false)
            {
                //Plus
                if (func == '+')
                {
                    secondarg = float.Parse(CalcDisplay.Text);
                    result = firstarg + secondarg;
                }
                //Minus
                else if (func == '-')
                {
                    secondarg = float.Parse(CalcDisplay.Text);
                    result = firstarg - secondarg;
                }
                //Multiply
                else if (func == '*')
                {
                    secondarg = float.Parse(CalcDisplay.Text);
                    result = firstarg * secondarg;
                }
                //Divide
                else if (func == '/')
                {
                    secondarg = float.Parse(CalcDisplay.Text);
                    if (secondarg == '0')
                    {
                        CalcDisplay.Text = "Never divide by 0";
                    }
                    else
                    {
                        result = firstarg / secondarg;
                    }

                }
                //Square
                else if (func == '^')
                {
                    result = firstarg * firstarg;
                }
            }
            CalcDisplay.Text = result.ToString();
        }    
            

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstarg = float.Parse(CalcDisplay.Text);
            func = '-';
            CalcDisplay.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstarg = float.Parse(CalcDisplay.Text);
            func = '+';
            CalcDisplay.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstarg = float.Parse(CalcDisplay.Text);
            func = '*';
            CalcDisplay.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstarg = float.Parse(CalcDisplay.Text);
            func = '/';
            CalcDisplay.Text = "";
        }

        private void squarerootButton_Click(object sender, EventArgs e)
        {
            func = '$';
            firstarg = float.Parse(CalcDisplay.Text);
            if (firstarg > 0)
            {
                double sqrt = Math.Sqrt(firstarg);
                CalcDisplay.Text = sqrt.ToString();
            }
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            firstarg = float.Parse(CalcDisplay.Text);
            func = '^';
            CalcDisplay.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "0";
            firstarg = 0;
            secondarg = 0;
            result = 0;
            func = '\0';
            dec = false;
        }
    }
}

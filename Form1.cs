using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private string _firstNumber = "0"; //number for the first half of the equation
        private string _operator;//operator that has just been hit
        private string OPERATOR;//operator for the equation
        private bool equalSignHit = false;//Has the equal sign been hit?

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if(_operator !="")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if(equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "1";

            outputLabel.Text = newnumber;
            
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "2";

            outputLabel.Text = newnumber;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "3";

            outputLabel.Text = newnumber;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "4";

            outputLabel.Text = newnumber;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "5";

            outputLabel.Text = newnumber;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "6";

            outputLabel.Text = newnumber;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "7";

            outputLabel.Text = newnumber;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "8";

            outputLabel.Text = newnumber;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            string currentNumber = "0";
            string newnumber = "0";

            currentNumber = outputLabel.Text;
            newnumber = currentNumber + "9";

            outputLabel.Text = newnumber;
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "0";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            if (outputLabel.Text != "0")
            {
                string currentNumber = "0";
                string newnumber = "0";

                currentNumber = outputLabel.Text;
                newnumber = currentNumber + "0";

                outputLabel.Text = newnumber;
            }
        }
        
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (_operator != "")
            {
                outputLabel.Text = "";
                _operator = "";
            }

            if (equalSignHit)
            {
                outputLabel.Text = "";
                equalSignHit = false;
            }

            if (_operator != null)
            {
                outputLabel.Text = "";
            }

            if (!outputLabel.Text.Contains("."))
            {
                string currentNumber = "0";
                string newnumber = "0";

                currentNumber = outputLabel.Text;
                newnumber = currentNumber + ".";

                outputLabel.Text = newnumber;
            }
            
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _firstNumber = outputLabel.Text;
            _operator = "divide";
            OPERATOR = "divide";
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _firstNumber = outputLabel.Text;
            _operator = "multiply";
            OPERATOR = "multiply";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            _firstNumber = outputLabel.Text;
            _operator = "subtract";
            OPERATOR = "subtract";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _firstNumber = outputLabel.Text;
            _operator = "add";
            OPERATOR = "add";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string secondNumber = outputLabel.Text;
            double output;

            if (OPERATOR == "divide")
            {
                output = double.Parse(_firstNumber) / double.Parse(secondNumber);
                outputLabel.Text = output.ToString();
            }
            else if (OPERATOR == "multiply")
            {
                output = double.Parse(_firstNumber) * double.Parse(secondNumber);
                outputLabel.Text = output.ToString();
            }
            else if(OPERATOR == "subtract")
            {
                output = double.Parse(_firstNumber) - double.Parse(secondNumber);
                outputLabel.Text = output.ToString();
            }
            else if(OPERATOR == "add")
            {
                output = double.Parse(_firstNumber) + double.Parse(secondNumber);
                outputLabel.Text = output.ToString();
            }

            _operator = "";
            equalSignHit = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "0";
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "0";
            _firstNumber = "";
            OPERATOR = "";
            
        }
    }
}

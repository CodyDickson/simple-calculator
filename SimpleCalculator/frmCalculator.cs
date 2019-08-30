using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        private string empty = "0";
        private string currentNumber = "";
        private int firstNumber = 0;
        private int secondNumber = 0;
        private string operation = "";
        private bool status = false;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            txtScreen.Text = empty;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "0";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "0";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "1";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "1";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "2";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "2";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "3";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "3";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "4";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "4";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "5";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "5";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "6";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "6";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "7";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "7";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "8";
                txtScreen.Text = currentNumber;
            }
            else
            {
                currentNumber = "8";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                currentNumber += "9";
                txtScreen.Text = currentNumber;
            } else
            {
                currentNumber = "9";
                txtScreen.Text = currentNumber;
                status = false;
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                firstNumber = Convert.ToInt32(currentNumber);
                currentNumber = "";
                txtScreen.Text = empty;
                operation = "Plus";
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                firstNumber = Convert.ToInt32(currentNumber);
                currentNumber = "";
                txtScreen.Text = empty;
                operation = "Minus";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                firstNumber = Convert.ToInt32(currentNumber);
                currentNumber = "";
                txtScreen.Text = empty;
                operation = "Multiply";
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                firstNumber = Convert.ToInt32(currentNumber);
                currentNumber = "";
                txtScreen.Text = empty;
                operation = "Divide";
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (operation == "Plus")
            {
                secondNumber = Convert.ToInt32(currentNumber);
                currentNumber = Convert.ToString(firstNumber + secondNumber);
                txtScreen.Text = currentNumber;
                operation = "";
                status = true;
                firstNumber = 0;
            } else if (operation == "Minus")
            {
                secondNumber = Convert.ToInt32(currentNumber);
                currentNumber = Convert.ToString(firstNumber - secondNumber);
                txtScreen.Text = currentNumber;
                operation = "";
                status = true;
                firstNumber = 0;
            } else if (operation == "Multiply")
            {
                secondNumber = Convert.ToInt32(currentNumber);
                currentNumber = Convert.ToString(firstNumber * secondNumber);
                txtScreen.Text = currentNumber;
                operation = "";
                status = true;
                firstNumber = 0;
            } else if (operation == "Divide")
            {
                secondNumber = Convert.ToInt32(currentNumber);
                currentNumber = Convert.ToString(firstNumber / secondNumber);
                txtScreen.Text = currentNumber;
                operation = "";
                status = true;
                firstNumber = 0;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            txtScreen.Text = empty;
            currentNumber = "";
            operation = "";
        }
    }
}

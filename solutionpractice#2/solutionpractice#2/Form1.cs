using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solutionpractice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result;
        int num1;
        int num2;

        bool typeCheckInt(string input)
        {
            int number = 0;
            return int.TryParse(input, out number);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (typeCheckInt(txtNumber1.Text) == true && typeCheckInt(txtNumber2.Text) == true)
            {
                num1 = int.Parse(txtNumber1.Text);
                num2 = int.Parse(txtNumber2.Text);

                result = num1 + num2;
                txtAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("The number you entered is not a number");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (typeCheckInt(txtNumber1.Text) == true && typeCheckInt(txtNumber2.Text) == true)
            {
                num1 = int.Parse(txtNumber1.Text);
                num2 = int.Parse(txtNumber2.Text);

                result = num1 - num2;
                txtAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("The number you entered is not a number");
            }
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            if (typeCheckInt(txtNumber1.Text) == true && typeCheckInt(txtNumber2.Text) == true)
            {
                num1 = int.Parse(txtNumber1.Text);
                num2 = int.Parse(txtNumber2.Text);

                result = num1 * num2;
                txtAnswer.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("The number you entered is not a number");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (typeCheckInt(txtNumber1.Text) == true && typeCheckInt(txtNumber2.Text) == true)
            {
                if (txtNumber2.Text.Equals("0"))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    num1 = int.Parse(txtNumber1.Text);
                    num2 = int.Parse(txtNumber2.Text);

                    result = num1 / num2;
                    txtAnswer.Text = result.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("The number you entered is not a number");
            }
        }
    }
}

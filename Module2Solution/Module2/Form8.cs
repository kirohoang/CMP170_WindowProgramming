using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private bool checkTypeInt(string input)
        {
            double n = 0;
            return double.TryParse(input, out n);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtResult.Text = firstDegreeEquation(float.Parse(txtA.Text), float.Parse(txtB.Text));
            btnDelete.Enabled = true;
            btnCalc.Enabled = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            txtA.Focus();
            btnCalc.Enabled = false;
            btnDelete.Enabled = false;
            txtResult.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String firstDegreeEquation(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                return "Equation has many solutions";
            }
            else if (a == 0 && b != 0)
            {
                return "Equation has no solution";
            }
            else
            {
                return Convert.ToString(-b / a);
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (checkTypeInt(txtA.Text) == false)
            {
                MessageBox.Show("The entered number is not correct format or empty!");
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtResult.Clear();
            txtA.Focus();
            btnDelete.Enabled = false;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (checkTypeInt(txtB.Text) == false)
            {
                MessageBox.Show("The entered number is not correct format or empty!");
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
            }
        }
    }
}

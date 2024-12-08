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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        double usd = 17861;
        double eur = 27043;

        private bool checkTypeInt(string input)
        {
            double n = 0;
            return double.TryParse(input, out n);
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            if (txtMoneyTransfer.Text == string.Empty)
            {
                MessageBox.Show("Please enter amount of money you want to transfer!");
                return;
            }
            else if (checkTypeInt(txtMoneyTransfer.Text) == false)
            {
                MessageBox.Show("Please enter correct number");
                return;
            }

            double currentMoney = double.Parse(txtMoneyTransfer.Text);
            double transfered = currentMoney / usd;
            double result =  Math.Round(transfered, 2);
            txtMoneyTransfered.Text = result.ToString();
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            if (txtMoneyTransfer.Text == string.Empty)
            {
                MessageBox.Show("Please enter amount of money you want to transfer!");
                return;
            }
            else if (checkTypeInt(txtMoneyTransfer.Text) == false)
            {
                MessageBox.Show("Please enter correct number");
                return;
            }

            double currentMoney = double.Parse(txtMoneyTransfer.Text);
            double transfered = currentMoney / eur;
            double result = Math.Round(transfered, 2);
            txtMoneyTransfered.Text = result.ToString();
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            if (txtMoneyTransfer.Text == string.Empty)
            {
                MessageBox.Show("Please enter amount of money you want to transfer!");
                return;
            }
            else if (checkTypeInt(txtMoneyTransfer.Text) == false)
            {
                MessageBox.Show("Please enter correct number");
                return;
            }
            double currentMoney = double.Parse(txtMoneyTransfer.Text);
            double transfered = currentMoney * usd;
            double result = Math.Round(transfered, 2);
            txtMoneyTransfered.Text = result.ToString();
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            if (txtMoneyTransfer.Text == string.Empty)
            {
                MessageBox.Show("Please enter amount of money you want to transfer!");
                return;
            }
            else if (checkTypeInt(txtMoneyTransfer.Text) == false)
            {
                MessageBox.Show("Please enter correct number");
                return;
            }
            double currentMoney = double.Parse(txtMoneyTransfer.Text);
            double transfered = currentMoney * eur;
            double result = Math.Round(transfered, 2);
            txtMoneyTransfered.Text = result.ToString();
        }

        private void btnExchangeRateDollar_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = usd.ToString();
        }

        private void btnExchangeRateEur_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = eur.ToString();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtYourName.Text == string.Empty || txtYears.Text == string.Empty)
            {
                MessageBox.Show("You can't leave the field empty");
            }
            else if (!int.TryParse(txtYears.Text, out i))
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                int year = int.Parse(txtYears.Text);
                int age = DateTime.Now.Year;
                MessageBox.Show($"My Name is {txtYourName.Text}\nAge: {age}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYears.Clear();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure want to exit?", "Annouce",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

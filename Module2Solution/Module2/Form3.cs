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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please, don't leave these field empty");
            }
            labelLastName.Text = $"Last Name: {txtLastName.Text}";
        }

        private void btnFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("Please, don't leave these field empty");
            }
            labelFirstName.Text = $"First Name: {txtFirstName.Text}";
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please, don't leave these field empty");
            }
            labelFullName.Text = $"Full Name: {txtFirstName.Text + txtLastName.Text}";
        }

        private void labelLastName_DoubleClick(object sender, EventArgs e)
        {
            labelLastName.Text = "Last Name:";
        }

        private void labelFirstName_DoubleClick(object sender, EventArgs e)
        {
            labelFirstName.Text = "First Name:";
        }

        private void labelFullName_DoubleClick(object sender, EventArgs e)
        {
            labelFullName.Text = "Full Name:";
        }
    }
}

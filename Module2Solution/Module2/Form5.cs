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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            rdoRed.Checked = true;
            txtName.Focus();
            lblName.Text = "";
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text.Trim();
        }
        private void lblName_TextChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
            {
                txtName.ForeColor = Color.Red;
                lblName.ForeColor = Color.Red;
            }
            else if (rdoGreen.Checked)
            {
                txtName.ForeColor = Color.Green;
                lblName.ForeColor = Color.Green;
            }
            else if (rdoBlue.Checked)
            {
                txtName.ForeColor = Color.Blue;
                lblName.ForeColor = Color.Blue;
            }
            else if (rdoBlack.Checked)
            {
                txtName.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

            lblName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);
        }

        private void chkRegular_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}


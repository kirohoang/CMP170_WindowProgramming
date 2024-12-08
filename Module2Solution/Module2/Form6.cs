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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picture_Small_Click(object sender, EventArgs e)
        {
            picture_Big.Visible = true;
            picture_Small.Visible = false;
        }

        private void picture_Big_Click(object sender, EventArgs e)
        {
            picture_Big.Visible = false;
            picture_Small.Visible = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblMessage.Text = txtMessage.Text;
            if (chkMessageVisible.Checked)
            {
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtName.Text = string.Empty;
            lblMessage.Text = string.Empty;
            lblName.Text = string.Empty;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Red;
            lblMessage.ForeColor = Color.Red;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Green;
            lblMessage.ForeColor = Color.Green;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Blue;
            lblMessage.ForeColor = Color.Blue;
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Black;
            lblMessage.ForeColor = Color.Black;
        }
    }
}


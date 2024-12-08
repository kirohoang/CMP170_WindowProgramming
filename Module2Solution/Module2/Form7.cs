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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = $"{txtName.Text}. Turn on the light. Pls!";
        }

        private void lightOn_picture_Click(object sender, EventArgs e)
        {
            lblMessage.Text = $"{txtName.Text}. Turn on the light. Pls!";
            lightOff_picture.Visible = true;
            lightOn_picture.Visible = false;
        }

        private void lightOff_picture_Click(object sender, EventArgs e)
        {
            lblMessage.Text = $"{txtName.Text}. Turn off the light. Pls!";
            lightOff_picture.Visible = false;
            lightOn_picture.Visible = true;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lblMadeBy.Text = "Designed By Kiro Dev";
            lblMessage.Text = $"{txtName.Text}. Turn on the light. Pls!";
        }
    }
}

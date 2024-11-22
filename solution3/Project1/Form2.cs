using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdoRed.Checked = true;
            chk1.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHobbies_Click(object sender, EventArgs e)
        {
            String strHobbies = "";
            if (chk1.Checked == true) { strHobbies = chk1.Text + "\n"; }
            if (chk2.Checked == true) { strHobbies = strHobbies + chk2.Text + "\n"; }
            if (chk3.Checked ==true) { strHobbies = strHobbies + chk3.Text + "\n"; }
            if (chk4.Checked == true) { strHobbies = strHobbies + chk4.Text + "\n"; }
            if (chk5.Checked == true) { strHobbies = strHobbies + chk5.Text + "\n"; }
            if (strHobbies.Length > 0)
            {
                MessageBox.Show("Your Hobbies: \n" + strHobbies);
            }
            else
            {
                MessageBox.Show("No Hobbies Selected");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            String strColor = "";
            if (rdoRed.Checked == true) { strColor = rdoRed.Text; }
            if (rdoWhite.Checked == true) { strColor = rdoWhite.Text; }
            if (rdoPurple.Checked == true) { strColor = rdoPurple.Text; }
            if (rdoOrange.Checked == true) { strColor = rdoOrange.Text; }
            if (rdoPink.Checked == true) { strColor = rdoPink.Text; }

            if (strColor.Length > 0)
            {
                MessageBox.Show("Your favorire color is: \n" + strColor);
            }
            else
            {
                MessageBox.Show("Default favorite color is Red");
            }
        }
    }
}

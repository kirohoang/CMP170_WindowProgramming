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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            rdoTNR.Checked = true;
        }

        private void rdoTNR_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", 8, FontStyle.Regular);
        }

        private void rdoArial_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void rdoTahoma_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }

        private void rdoCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Courier New", 8, FontStyle.Regular);
        }
    }
}

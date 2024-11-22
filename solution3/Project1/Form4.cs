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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Form4_Load(object sender, EventArgs e)
        {
            cmbMajor.Items.Add("Major A");
            cmbMajor.Items.Add("Major B");
            cmbMajor.Items.Add("Major C");
            cmbMajor.Items.Add("Major D");
            cmbMajor.SelectedIndex = 0;


            table.Columns.Add(labelStudentID.Text, typeof(int));
            table.Columns.Add(labelName.Text, typeof(string));
            table.Columns.Add(labelGender.Text, typeof(string));
            table.Columns.Add(labelMajor.Text, typeof(string));
            table.Columns.Add("Count", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMajorSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbMajor.SelectedIndex;

            lstBox1.Items.Clear();
            lstBox2.Items.Clear();
            if (index == 0)
            {
                lstBox1.Items.Add("Subject 1");
                lstBox1.Items.Add("Subject 2");
                lstBox1.Items.Add("Subject 3");
                lstBox1.Items.Add("Subject 4");
            }

            else if (index == 1)
            {
                lstBox1.Items.Add("Subject 5");
                lstBox1.Items.Add("Subject 6");
                lstBox1.Items.Add("Subject 7");
                lstBox1.Items.Add("Subject 8");

            }
            else if (index == 2)
            {
                lstBox1.Items.Add("Subject 9");
                lstBox1.Items.Add("Subject 10");
                lstBox1.Items.Add("Subject 11");
                lstBox1.Items.Add("Subject 12");

            }
            else
            {
                lstBox1.Items.Add("Subject 13");
                lstBox1.Items.Add("Subject 14");
                lstBox1.Items.Add("Subject 15");
                lstBox1.Items.Add("Subject 16");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstBox1.SelectedIndex >= 0)
            {
                lstBox2.Items.Add(lstBox1.SelectedItem);
                lstBox1.Items.Remove(lstBox1.SelectedItem);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lstBox2.SelectedIndex >= 0)
            {
                lstBox1.Items.Add(lstBox2.SelectedItem);
                lstBox2.Items.Remove(lstBox2.SelectedItem);
                if (lstBox2.Items.Count > 0)
                {
                    lstBox2.SelectedIndex = 0;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strGender = "";
            if (rdoMale.Checked == true)
            {
                strGender = rdoMale.Text;
            }
            else if (rdoFemale.Checked == true)
            {
                strGender = rdoFemale.Text;
            }

            table.Rows.Add(txtStudentID.Text, txtName.Text, strGender, cmbMajor.Text, lstBox2.Items.Count.ToString());
        }
    }
}

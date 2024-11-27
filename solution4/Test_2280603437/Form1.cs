using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2280603437
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbMajor.SelectedIndex;
            if (index == 0)
            {
                checkBox1.Text = "Subject 1";
                checkBox2.Text = "Subject 2";
                checkBox3.Text = "Subject 3";
                checkBox4.Text = "Subject 4";
            }
            else if (index == 1)
            {
                checkBox1.Text = "Subject 5";
                checkBox2.Text = "Subject 6";
                checkBox3.Text = "Subject 7";
                checkBox4.Text = "Subject 8";
            }
            else if (index == 2)
            {
                checkBox1.Text = "Subject 9";
                checkBox2.Text = "Subject 10";
                checkBox3.Text = "Subject 11";
                checkBox4.Text = "Subject 12";
            }
            else
            {
                checkBox1.Text = "Subject 13";
                checkBox2.Text = "Subject 14";
                checkBox3.Text = "Subject 15";
                checkBox4.Text = "Subject 16";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMajor.Items.Add("Major A");
            cmbMajor.Items.Add("Major B");
            cmbMajor.Items.Add("Major C");
            cmbMajor.Items.Add("Major D");
            cmbMajor.SelectedIndex = 0;

            table.Columns.Add(label_ID.Text, typeof(int));
            table.Columns.Add(label_FullName.Text, typeof(string));
            table.Columns.Add(label_Major.Text, typeof(string));
            table.Columns.Add("Count", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string strSubject = "";
            if (checkBox1.Checked == true)
            {
                strSubject = checkBox1.Text;
                count++;
            }
            if (checkBox2.Checked == true)
            {
                strSubject = checkBox2.Text;
                count++;
            }
            if (checkBox3.Checked == true)
            {
                strSubject = checkBox3.Text;
                count++;
            }
            if (checkBox4.Checked == true)
            {
                strSubject = checkBox4.Text;
                count++;
            }

            table.Rows.Add(txtID.Text, txtFullName.Text, cmbMajor.Text, count);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[label_ID.Text].Value.ToString();
            txtFullName.Text = dataGridView1.CurrentRow.Cells[label_FullName.Text].Value.ToString();
            cmbMajor.Text = dataGridView1.CurrentRow.Cells[label_Major.Text].Value.ToString();
        }

        private void dataGridView1_ColumnHeader(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[label_ID.Text].Value.ToString();
            txtFullName.Text = dataGridView1.CurrentRow.Cells[label_FullName.Text].Value.ToString();
            cmbMajor.Text = dataGridView1.CurrentRow.Cells[label_Major.Text].Value.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solutionpractice_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            cmbFacultyName.Items.Add("QTKD");
            cmbFacultyName.Items.Add("IT");
            cmbFacultyName.Items.Add("NNA");
            cmbFacultyName.SelectedIndex = 0;

            txtTotalFemale.Text = "0";
            txtTotalMale.Text = "0";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int totalMale = 0;
        int totalFemale = 0;
        int selectedRow;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string gender = "";
            if (txtStudentID.Text != string.Empty ||
                txtFullName.Text != string.Empty ||
                txtGPA.Text != string.Empty)
            {
                if (rdoMale.Checked)
                {
                    gender = rdoMale.Text;
                    totalMale++;
                }
                else if (rdoFemale.Checked)
                {
                    gender = rdoFemale.Text;
                    totalFemale++;
                }
                dataGridView1.Rows.Add(txtStudentID.Text, txtFullName.Text, gender, txtGPA.Text, cmbFacultyName.Text);
                txtTotalMale.Text = totalMale.ToString();
                txtTotalFemale.Text = totalFemale.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up these fields");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString().Equals("Female"))
            {
                rdoFemale.Checked = true;
            }
            else
            {
                rdoMale.Checked = true;
            }
            txtGPA.Text = row.Cells[3].Value.ToString();
            cmbFacultyName.Text = row.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);                
            }
            MessageBox.Show("Student Deleted");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            newRow.Cells[0].Value = txtStudentID.Text;
            newRow.Cells[1].Value = txtFullName.Text;
            if (rdoFemale.Checked)
            {
                newRow.Cells[2].Value = rdoFemale.Text;
                totalMale--;
                totalFemale++;
                if (totalMale < 0)
                {
                    totalMale = 0;
                }
            }
            else if (rdoMale.Checked)
            {
                newRow.Cells[2].Value = rdoMale.Text;
                totalMale++;
                totalFemale--;
                if (totalFemale < 0)
                {
                    totalFemale = 0;
                }

            }
            newRow.Cells[3].Value = txtGPA.Text;
            newRow.Cells[4].Value = cmbFacultyName.Text;

            txtTotalMale.Text = totalMale.ToString();
            txtTotalFemale.Text = totalFemale.ToString();

            MessageBox.Show("Updated Data Successfully", "Updated");
        }
    }
}

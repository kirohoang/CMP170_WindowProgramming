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
    public partial class Form4 : Form
    {
        int selectedRow;
        public Form4()
        {
            InitializeComponent();
        }
        int totalAmount = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAccountNumber.Text == string.Empty || 
                txtCustomerName.Text == string.Empty ||
                txtAddress.Text == string.Empty ||
                txtAccountNumber.Text == string.Empty)
            {
                MessageBox.Show("You can't leave these fields empty");
            }
            else
            {
                dataGridView1.Rows.Add(txtAccountNumber.Text, 
                                        txtCustomerName.Text, 
                                        txtAddress.Text, 
                                        txtAccountAmount.Text);
                MessageBox.Show($"New Data Added Successfully");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            newRow.Cells[0].Value = txtAccountNumber.Text;
            newRow.Cells[1].Value = txtCustomerName.Text;
            newRow.Cells[2].Value = txtAddress.Text;
            newRow.Cells[3].Value = txtAccountAmount.Text;

            MessageBox.Show("Updated Data Successfully");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txtAccountNumber.Text = row.Cells[0].Value.ToString();
            txtCustomerName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtAccountAmount.Text = row.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Account Deleted");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}

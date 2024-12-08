using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution5
{
    public partial class Form3 : Form
    {
        dbContact db = new dbContact();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                db = new dbContact();
                List<customer> customerList = db.customers.ToList();
                dgvCustomers.Rows.Clear();
                foreach (customer customer in customerList)
                {
                    int index = dgvCustomers.Rows.Add();
                    dgvCustomers.Rows[index].Cells[0].Value = customer.customer_id;
                    dgvCustomers.Rows[index].Cells[1].Value = customer.customer_name;
                    dgvCustomers.Rows[index].Cells[2].Value = customer.username;
                    dgvCustomers.Rows[index].Cells[3].Value = customer.password;
                    dgvCustomers.Rows[index].Cells[4].Value = customer.email;
                    dgvCustomers.Rows[index].Cells[5].Value = customer.numberphone;
                    dgvCustomers.Rows[index].Cells[6].Value = customer.dob;
                    dgvCustomers.Rows[index].Cells[7].Value = customer.address;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty ||
            txtCustomerID.Text == string.Empty ||
            txtCustomerName.Text == string.Empty ||
            txtEmail.Text == string.Empty ||
            txtPhone.Text == string.Empty ||
            txtPassword.Text == string.Empty ||
            txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtCustomerID.Text);
                int phoneNumber = int.Parse(txtPhone.Text);
                customer customer = new customer()
                {
                    customer_id = id,
                    customer_name = txtCustomerName.Text,
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    email = txtEmail.Text,
                    dob = dateDOB.Value,
                    numberphone = phoneNumber,
                    address = txtAddress.Text,
                };
                db.customers.Add(customer);
                db.SaveChanges();
                Form3_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty ||
            txtCustomerID.Text == string.Empty ||
            txtCustomerName.Text == string.Empty ||
            txtEmail.Text == string.Empty ||
            txtPhone.Text == string.Empty ||
            txtPassword.Text == string.Empty ||
            txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtCustomerID.Text);
                int phoneNumber = int.Parse(txtPhone.Text);
                customer customer = db.customers.FirstOrDefault(x => x.customer_id == id);
                if (customer != null)
                {
                    customer.customer_name = txtCustomerName.Text;
                    customer.username = txtUsername.Text;
                    customer.password = txtPassword.Text;
                    customer.email = txtEmail.Text;
                    customer.dob = dateDOB.Value;
                    customer.numberphone = phoneNumber;
                    customer.address = txtAddress.Text;
                    db.SaveChanges();
                }
                Form3_Load(sender, e);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
            txtCustomerID.Text = row.Cells[0].Value.ToString();
            txtCustomerName.Text = row.Cells[1].Value.ToString();
            txtUsername.Text = row.Cells[2].Value.ToString();
            txtPassword.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtPhone.Text = row.Cells[5].Value.ToString();
            dateDOB.Text = row.Cells[6].Value.ToString();
            txtAddress.Text = row.Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerID.Text);
            customer customer = db.customers.FirstOrDefault(x => x.customer_id == id);
            if (customer != null)
            {
                db.customers.Remove(customer);
                db.SaveChanges();
            }
            Form3_Load(sender, e);
        }
    }
}

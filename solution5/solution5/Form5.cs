using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        dbContact db = new dbContact();
        private void Form5_Load(object sender, EventArgs e)
        {
            db = new dbContact();
            List<order> orderList = db.orders.ToList();
            dataGridView1.Rows.Clear();
            foreach (order order in orderList)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = order.order_id;
                dataGridView1.Rows[index].Cells[1].Value = order.ispayment;
                dataGridView1.Rows[index].Cells[2].Value = order.isship;
                dataGridView1.Rows[index].Cells[3].Value = order.order_date;
                dataGridView1.Rows[index].Cells[4].Value = order.delivery_date;
                dataGridView1.Rows[index].Cells[5].Value = order.customer_id;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty ||
                txtIspayment.Text == string.Empty ||
                txtIsship.Text == string.Empty ||
                txtOrderID.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtOrderID.Text);
                int customer_id = int.Parse(txtCustomerID.Text);
                bool ispayment = bool.Parse(txtIspayment.Text);
                bool isship = bool.Parse(txtIsship.Text);
                order order = new order()
                {
                    order_id = id,
                    customer_id = customer_id,
                    order_date = dateDeliveryDate.Value,
                    delivery_date = dateDeliveryDate.Value,
                    ispayment = ispayment,
                    isship = isship,
                };
                db.orders.Add(order);
                db.SaveChanges();
                Form5_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty ||
                txtIspayment.Text == string.Empty ||
                txtIsship.Text == string.Empty ||
                txtOrderID.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtCustomerID.Text);
                int order_id = int.Parse(txtOrderID.Text);

                bool ispayment = bool.Parse(txtIspayment.Text);
                bool isship = bool.Parse(txtIsship.Text);
                order order = db.orders.FirstOrDefault(x => x.order_id == order_id && x.customer_id == id);
                if (order != null)
                {
                    order.order_date = dateDeliveryDate.Value;
                    order.delivery_date = dateDeliveryDate.Value;
                    order.ispayment = ispayment;
                    order.isship = isship;
                    db.SaveChanges();
                }
                Form5_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOrderID.Text);
            order order = db.orders.FirstOrDefault(x => x.order_id == id);
            if (order != null)
            {
                db.orders.Remove(order);
                db.SaveChanges();
            }
            Form5_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtOrderID.Text = row.Cells[0].Value.ToString();
            txtIspayment.Text = row.Cells[1].Value.ToString();
            txtIsship.Text = row.Cells[2].Value.ToString();
            dateOrderDate.Text = row.Cells[3].Value.ToString();
            dateDeliveryDate.Text = row.Cells[4].Value.ToString();
            txtCustomerID.Text = row.Cells[5].Value.ToString();
        }
    }
}

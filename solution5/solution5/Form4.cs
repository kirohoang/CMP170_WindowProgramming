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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        dbContact db = new dbContact();
        private void Form4_Load(object sender, EventArgs e)
        {
            db = new dbContact();
            List<order_details> orderDetailsList = db.order_details.ToList();
            dataGridView1.Rows.Clear();
            foreach (order_details order_Details in orderDetailsList)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = order_Details.order_id;
                dataGridView1.Rows[index].Cells[1].Value = order_Details.book_id;
                dataGridView1.Rows[index].Cells[2].Value = order_Details.quantity;
                dataGridView1.Rows[index].Cells[3].Value = order_Details.price;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == string.Empty ||
                txtOrderID.Text == string.Empty ||
                txtQuanity.Text == string.Empty ||
                txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtBookID.Text);
                int order_id = int.Parse(txtOrderID.Text);
                int quantity = int.Parse(txtQuanity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                order_details orderDetails = new order_details()
                {
                    order_id = order_id,
                    book_id = id,
                    quantity = quantity,
                    price = price
                };
                db.order_details.Add(orderDetails);
                db.SaveChanges();
            }
            Form4_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == string.Empty ||
                txtOrderID.Text == string.Empty ||
                txtQuanity.Text == string.Empty ||
                txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtBookID.Text);
                int order_id = int.Parse(txtOrderID.Text);
                int quantity = int.Parse(txtQuanity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                order_details orderDetails = db.order_details.FirstOrDefault(x => x.order_id == order_id && x.book_id == id);
                if (orderDetails != null)
                {
                    orderDetails.quantity = quantity;
                    orderDetails.price = price;
                    db.SaveChanges();
                }
            }
            Form4_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            int order_id = int.Parse(txtOrderID.Text);
            order_details orderDetails = db.order_details.FirstOrDefault(x => x.order_id == order_id && x.book_id == id);
            if (orderDetails != null)
            {
                db.order_details.Remove(orderDetails);
                db.SaveChanges();
            }
            Form4_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtBookID.Text = row.Cells[1].Value.ToString();
            txtOrderID.Text = row.Cells[0].Value.ToString();
            txtQuanity.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
        }
    }
}

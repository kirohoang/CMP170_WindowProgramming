using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace solution5
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        dbContact db = new dbContact();
        private void Form7_Load(object sender, EventArgs e)
        {
            db = new dbContact();
            List<category> categoryList = db.categories.ToList();
            dataGridView1.Rows.Clear();
            foreach (category category in categoryList)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = category.category_id;
                dataGridView1.Rows[index].Cells[1].Value = category.category_name;
                dataGridView1.Rows[index].Cells[2].Value = category.description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty ||
            txtName.Text == string.Empty ||
            txtDesc.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string desc = txtDesc.Text;
                category category = new category()
                {
                    category_id = id,
                    category_name = name,
                    description = desc
                };
                db.categories.Add(category);
                db.SaveChanges();
                Form7_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty ||
            txtName.Text == string.Empty ||
            txtDesc.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string desc = txtDesc.Text;
                category category = db.categories.FirstOrDefault(x => x.category_id == id);
                if (category != null)
                {
                    category.category_name = name;
                    category.description = desc;
                    db.SaveChanges();
                }
                Form7_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            category category = db.categories.FirstOrDefault(x => x.category_id == id);
            if (category != null)
            {
                db.categories.Remove(category);
                db.SaveChanges();
            }
            Form7_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtDesc.Text = row.Cells[2].Value.ToString();
        }
    }
}

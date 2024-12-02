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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        dbContact db = new dbContact();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                db = new dbContact();
                List<publisher> publishersList = db.publishers.ToList();
                dataGridView1.Rows.Clear();
                foreach (var item in publishersList)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = item.publisher_id;
                    dataGridView1.Rows[index].Cells[1].Value = item.publisher_name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            publisher s = new publisher()
            {
                publisher_id = x,
                publisher_name = txtName.Text
            };
            db.publishers.Add(s);
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            publisher dbDelete = db.publishers.FirstOrDefault(db => db.publisher_id == x);
            if (dbDelete != null)
            {
                db.publishers.Remove(dbDelete);
                db.SaveChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            publisher dbEdit = db.publishers.FirstOrDefault(p => p.publisher_id == x);
            if (dbEdit != null)
            {
                dbEdit.publisher_name = txtName.Text;
                db.SaveChanges();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

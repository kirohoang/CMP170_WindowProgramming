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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        dbContact db = new dbContact();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthorID.Text == string.Empty ||
                            txtName.Text == string.Empty ||
                            txtBio.Text == string.Empty ||
                            txtNationality.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtAuthorID.Text);
                string name = txtName.Text;
                string bio = txtBio.Text;
                DateTime dob = dateDOB.Value;
                string nationality = txtNationality.Text;
                author author = new author()
                {
                    author_id = id,
                    name = name,
                    bio = bio,
                    dob = dob,
                    nationality = nationality
                };
                db.authors.Add(author);
                db.SaveChanges();
                Form6_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAuthorID.Text == string.Empty ||
                                        txtName.Text == string.Empty ||
                                        txtBio.Text == string.Empty ||
                                        txtNationality.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtAuthorID.Text);
                string name = txtName.Text;
                string bio = txtBio.Text;
                DateTime dob = dateDOB.Value;
                string nationality = txtNationality.Text;
                author author = db.authors.FirstOrDefault(x => x.author_id == id);
                if (author != null)
                {
                    author.name = name;
                    author.bio = bio;
                    author.dob = dob;
                    author.nationality = nationality;
                    db.SaveChanges();
                }
                Form6_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtAuthorID.Text);
            author author = db.authors.FirstOrDefault(x => x.author_id == id);
            if (author != null)
            {
                db.authors.Remove(author);
                db.SaveChanges();
            }
            Form6_Load(sender, e);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            db = new dbContact();
            List<author> authorsauthorList = db.authors.ToList();
            dataGridView1.Rows.Clear();
            foreach (author author in authorsauthorList)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = author.author_id;
                dataGridView1.Rows[index].Cells[1].Value = author.name;
                dataGridView1.Rows[index].Cells[2].Value = author.bio;
                dataGridView1.Rows[index].Cells[3].Value = author.dob;
                dataGridView1.Rows[index].Cells[4].Value = author.nationality;
            }
        }
    }
}

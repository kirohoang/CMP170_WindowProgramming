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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        dbContact db = new dbContact();
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                db = new dbContact();
                List<book> bookList = db.books.ToList();
                dgvBook.Rows.Clear();
                foreach (book book in bookList)
                {
                    int index = dgvBook.Rows.Add();
                    dgvBook.Rows[index].Cells[0].Value = book.book_id;
                    dgvBook.Rows[index].Cells[1].Value = book.book_name;
                    dgvBook.Rows[index].Cells[2].Value = book.price;
                    dgvBook.Rows[index].Cells[3].Value = book.quantity_stock;
                    dgvBook.Rows[index].Cells[4].Value = book.publisher_id;
                    dgvBook.Rows[index].Cells[5].Value = book.update_date;
                    dgvBook.Rows[index].Cells[6].Value = book.image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                txtBookName.Text == string.Empty ||
                txtBookPrice.Text == string.Empty ||
                txtImage.Text == string.Empty ||
                txtQuantity.Text == string.Empty ||
                txtPublisherID.Text == string.Empty)
            {
                MessageBox.Show("You can't leave these fields empty");
            }
            else
            {
                int id = int.Parse(txtBookID.Text);
                int quantity = int.Parse(txtQuantity.Text);
                int publisher_id = int.Parse(txtPublisherID.Text);
                decimal book_price = decimal.Parse(txtBookPrice.Text);
                book book = new book()
                {
                    book_id = id,
                    book_name = txtBookName.Text,
                    price = book_price,
                    quantity_stock = quantity,
                    publisher_id = publisher_id,
                    update_date = dateTimeUpdateDate.Value,
                    image = txtImage.Text,
                };
                db.books.Add(book);
                db.SaveChanges();
                image1.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBookID.Text);
                book bookDelete = db.books.FirstOrDefault(db => db.book_id == id);
                if (bookDelete != null)
                {
                    db.books.Remove(bookDelete);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBook.Rows[e.RowIndex];
            txtBookID.Text = row.Cells[0].Value.ToString();
            txtBookName.Text = row.Cells[1].Value.ToString();
            txtBookPrice.Text = row.Cells[2].Value.ToString();
            txtQuantity.Text = row.Cells[3].Value.ToString();
            txtPublisherID.Text = row.Cells[4].Value.ToString();
            dateTimeUpdateDate.Text = row.Cells[5].Value.ToString();
            txtImage.Text = row.Cells[6].Value.ToString();

            if (txtImage.Text != string.Empty)
            {
                image1.Image = Image.FromFile(txtImage.Text);
            }
            image1.Show();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;

                    image1.ImageLocation = imageLocation;
                    txtImage.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            image1.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            int publisher_id = int.Parse(txtPublisherID.Text);
            decimal bookPrice = decimal.Parse(txtBookPrice.Text);
            book bookEdit = db.books.FirstOrDefault(b => b.book_id == id);
            if (bookEdit != null)
            {
                bookEdit.book_name = txtBookName.Text;
                bookEdit.price = bookPrice;
                bookEdit.quantity_stock = quantity;
                bookEdit.publisher_id = publisher_id;
                bookEdit.update_date = dateTimeUpdateDate.Value;
                bookEdit.image = txtImage.Text;
                db.SaveChanges();
            }
            image1.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPublisherID.Text = string.Empty;
            txtBookPrice.Text = string.Empty;
            txtImage.Text = string.Empty;
            image1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Form2_Load(sender, e);
        }
    }
}

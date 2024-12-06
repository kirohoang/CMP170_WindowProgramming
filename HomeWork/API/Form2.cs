using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadDataAsync();
        }
        private async Task DeleteUSer(int ID)
        {
            string apiUrl = $"http://localhost:5102/api/Users/{ID}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Removed!");
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode} - {errorResponse}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUSer(int.Parse(txtID.Text));

        }
        private async Task UpdateUser(int ID)
        {
            string apiUrl = $"http://localhost:5102/api/Users/{ID}";

            // Dữ liệu cần cập nhật
            var updatedUser = new
            {
                Id = ID,
                Name = txtName.Text,
                Email = txtEmail.Text
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonContent = JsonConvert.SerializeObject(updatedUser);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Updated Sucessfully!");
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode} - {errorResponse}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser(int.Parse(txtID.Text));
        }
        private async Task LoadDataAsync()
        {
            string apiUrl = "http://localhost:5102/api/Users";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON thành danh sách đối tượng User
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                    // Hiển thị trong DataGridView
                    dataGridView1.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        async Task AddUser()
        {
            // API URL
            string apiUrl = "http://localhost:5102/api/Users/";

            // Dữ liệu cần gửi
            var newUser = new
            {
                Id = txtID.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Chuyển dữ liệu thành JSON
                    string jsonContent = JsonConvert.SerializeObject(newUser);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    // Gửi yêu cầu POST
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Success ");
                    }
                    else
                    {
                        MessageBox.Show($"Error{response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erorr {ex.Message}");
            }
        }
    }
}

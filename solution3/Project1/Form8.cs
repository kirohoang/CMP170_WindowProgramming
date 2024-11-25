using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form8 : Form
    {
        #region Properties
        private List<List<Button>> matrix;
        private Image[] images;
        public int sizeGame;
        public int[] game;
        private List<Button> clickedButton = new List<Button>();
        private int elapsedTime;
        private int matchedPairs;
        private int ratio;
        private int numImages; 
        #endregion

        public Form8()
        {
            InitializeComponent();
            InitializeGameTimer();
        }

        private void InitializeGameTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GamerTimer_Tick;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cmbMatrix.Items.Add("4 x 4");
            cmbMatrix.Items.Add("6 x 6");
            cmbMatrix.Items.Add("8 x 8");
            cmbMatrix.SelectedIndex = 0;
        }

        public static int[] GenerateArray(int n)
        {
            int size = n * n;
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i += 2)
            {
                int randomValue = random.Next(0, n);
                array[i] = randomValue;
                array[i + 1] = randomValue;
            }
            array = array.OrderBy(x => random.Next()).ToArray();
            return array;
        }

        void LoadMatrix()
        {
            panelMatrix.Controls.Clear();
            matchedPairs = 0;
            string img = "mine.png";
            imageList1.ImageSize = new Size(40, 40);
            var image = imageList1.Images;
            image.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\" + img));
            sizeGame = cmbMatrix.SelectedIndex == 0 ? 4 : cmbMatrix.SelectedIndex == 1 ? 6 : 8;
            game = GenerateArray(sizeGame);
            int totalNumbers = sizeGame * sizeGame;
            matrix = new List<List<Button>>();
            Button x = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };

            for (int i = 0; i < sizeGame; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < sizeGame; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 40,
                        Height = 40,
                    };
                    btn.Location = new Point(x.Location.X + x.Width, x.Location.Y);
                    btn.ForeColor = Color.Gray;
                    btn.Click += btn_Check;
                    btn.Click += btn_Click;
                    panelMatrix.Controls.Add(btn);
                    x = btn;
                }
                x = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(0, x.Location.Y + 40)
                };
            }
            panelMatrix.Enabled = false;
        }

        private void btn_Check(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Random random = new Random();
            int percentage = random.Next(0, 100);

            if (percentage < 26)
            {
                button.BackgroundImage = imageList1.Images[0];
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (clickedButton.Contains(button))
                {
                    return;
                }
                clickedButton.Add(button);

                if (button.BackgroundImage != null)
                {
                    gameTimer.Stop();
                    MessageBox.Show("You clicked into a mine! Game Over");
                    
                    LoadMatrix();
                }
                else
                {
                    button.BackColor = Color.Gray;
                }

                if (checkWinCondition())
                {
                    gameTimer.Stop();
                    MessageBox.Show($"You have comepleted the game with {elapsedTime} seconds");
                }
            }
        }

        private bool checkWinCondition()
        {
            foreach (Control control in panelMatrix.Controls)
            {
                if (control is Button button && button.BackColor != Color.Gray)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadMatrix();
            elapsedTime = 0;
            lblTimer.Text = "Time: 0s";
            gameTimer.Start();
            panelMatrix.Enabled = true;
        }

        private void cmbMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatrix();
        }

        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblTimer.Text = $"Time: {elapsedTime}s";
        }
    }
}

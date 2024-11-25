using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{

    public partial class Form7 : Form
    {
        #region Properties
        private List<List<Button>> matrix;
        private Image[] images;
        public int sizeGame;
        public int[] game;
        private List<Button> clickedButton = new List<Button>();
        public int elapsedTime;
        public int matchedPair;
        #endregion
        public Form7()
        {
            InitializeComponent();
            InitializeGameTimer();
        }

        private void InitializeGameTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cmbMatrixSize.Items.Add("4 x 4");
            cmbMatrixSize.Items.Add("6 x 6");
            cmbMatrixSize.Items.Add("8 x 8");
            cmbMatrixSize.SelectedIndex = 0;
        }

        public static int[] GenerateArray(int n)
        {
            int size = n * n;
            Random random = new Random();
            int[] pairs = new int[size];
            for (int i = 0; i < size; i += 2)
            {
                int randomValue = random.Next(0, n);
                pairs[i] = randomValue;
                pairs[i + 1] = randomValue;
            }
            pairs = pairs.OrderBy(x => random.Next()).ToArray();
            return pairs;
        }

        void loadMatrix()
        {
            panelMatrix.Controls.Clear();
            matchedPair = 0;
            string[] img = { "stone.png", "dirt.png", "sand.png", "gravel.png", "oak_log.png", "crafting_table.png", "cobblestone.png", "birch_log.png" };
            imageList1.ImageSize = new Size(40, 40);
            var image = imageList1.Images;
            foreach (var item in img)
            {
                image.Add(Image.FromFile("D:\\CMP170_WindowProgramming\\solution3\\" + item));
            }
            sizeGame = cmbMatrixSize.SelectedIndex == 0 ? 4 : cmbMatrixSize.SelectedIndex == 1 ? 6 : 8;
            game = GenerateArray(sizeGame);

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
                    btn.Text = (i * sizeGame + j).ToString();
                    btn.ForeColor = Color.Gray;
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

        private void cmbMatrix_SelectedIndexChange(object sender, EventArgs e)
        {
            loadMatrix();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            loadMatrix();
            elapsedTime = 0;
            lblTimer.Text = "Time: 0s";
            gameTimer.Start();
            panelMatrix.Enabled = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (clickedButton.Contains(button))
                {
                    return;
                }
                int position = int.Parse(button.Text);
                button.BackgroundImage = imageList1.Images[game[position]];

                clickedButton.Add(button);

                if (clickedButton.Count == 2)
                {
                    int pos1 = int.Parse(clickedButton[0].Text);
                    int pos2 = int.Parse(clickedButton[1].Text);

                    if (game[pos1] == game[pos2])
                    {
                        MessageBox.Show("Matched");
                        clickedButton[0].Visible = false;
                        clickedButton[1].Visible = false;

                        matchedPair++;

                        if (matchedPair == (sizeGame * sizeGame) / 2)
                        {
                            gameTimer.Stop();
                            MessageBox.Show($"You have completed the game with in {elapsedTime} seconds");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not matched");
                        clickedButton[0].BackgroundImage = null;
                        clickedButton[1].BackgroundImage = null;
                    }
                    clickedButton.Clear();
                }
            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblTimer.Text = $"Time: {elapsedTime}s";
        }

    }
}

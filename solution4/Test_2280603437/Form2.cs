using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2280603437
{
    public partial class Form2 : Form
    {
        #region Properties
        private List<List<Button>> matrix;
        public int sizeGame;
        public int[] game;
        private int elapsedTime;
        #endregion
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbMatrix.Items.Add("3 x 3");
            cmbMatrix.Items.Add("5 x 5");
            cmbMatrix.Items.Add("7 x 7");
            cmbMatrix.SelectedIndex = 0;
        }

        void LoadMatrix()
        {
            panelMatrix.Controls.Clear();
            sizeGame = cmbMatrix.SelectedIndex == 0 ? 3 : cmbMatrix.SelectedIndex == 1 ? 5 : 7;
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

        private void cmbMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatrix();
            gameTimer.Stop();
            elapsedTime = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadMatrix();
            elapsedTime = 0;
            labelTimer.Text = "Timer: 0s";
            gameTimer.Start();
            panelMatrix.Enabled = true;
        }

        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            labelTimer.Text = $"Time: {elapsedTime}s";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form6 : Form
    {
        #region Properties
        private List<List<Button>> seat;

        public List<List<Button>> Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        #endregion
        public Form6()
        {
            InitializeComponent();
            loadMatrix();
        }

        private void loadMatrix()
        {
            int buttonNumber = 0;
            Seat = new List<List<Button>>();

            Button x = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(panelScreen.Width / 4 - 30, panelScreen.Height / 4 - 30)
            };

            for (int i = 0; i < Cons.seatAmountCols; i++)
            {
                Seat.Add(new List<Button>());
                for (int j = 0; j < Cons.seatAmountRow; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.btnSeatWidth,
                        Height = Cons.btnSeatHeight,
                    };
                    btn.Location = new Point(x.Location.X + x.Width, x.Location.Y);
                    panelScreen.Controls.Add(btn);
                    Seat[i].Add(btn);
                    x = btn;
                    buttonNumber++;
                    btn.Text = buttonNumber.ToString();
                    btn.BackColor = Color.White;
                    // Using lambda to add Events on button
                    btn.Click += (sender, e) => Button_Click(sender, e);
                    btnCancel.Click += (sender, e) => btnCancel_Click(sender, e);
                    btnSelect.Click += (sender, e) => btnCancel_Click(sender, e);
                }
                x = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(panelScreen.Width / 4 - 30, x.Location.Y + Cons.btnSeatHeight)
                };
            }
        }

        public int price = 0;

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int buttonText = Convert.ToInt32(button.Text);
            bool buttonSelected = false;

            if (button.BackColor == Color.White)
            {
                if (buttonText >= 1 && buttonText <= 5)
                {
                    price += 30000;
                    if (!buttonSelected) button.BackColor = Color.Cyan;
                }
                else if (buttonText >= 6 && buttonText <= 10)
                {
                    price += 40000;
                    if (!buttonSelected) button.BackColor = Color.Cyan;
                }
                else if (buttonText >= 11 && buttonText <= 15)
                {
                    price += 50000;
                    if (!buttonSelected) button.BackColor = Color.Cyan;
                }
                else if (buttonText >= 16 && buttonText <= 20)
                {
                    price += 80000;
                    if (!buttonSelected) button.BackColor = Color.Cyan;
                }
            }
            else if (button.BackColor == Color.Cyan)
            {
                if (buttonText >= 1 && buttonText <= 5)
                {
                    price -= 30000;
                    if (!buttonSelected) button.BackColor = Color.White;
                }
                else if (buttonText >= 6 && buttonText <= 10)
                {
                    price -= 40000;
                    if (!buttonSelected) button.BackColor = Color.White;
                }
                else if (buttonText >= 11 && buttonText <= 15)
                {
                    price -= 50000;
                    if (!buttonSelected) button.BackColor = Color.White;
                }
                else if (buttonText >= 16 && buttonText <= 20)
                {
                    price -= 80000;
                    if (!buttonSelected) button.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("The ticket of this location has been sold!");
            }
            txtTotal.Text = price.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            price = 0;
            txtTotal.Text = price.ToString();
            foreach (var row in Seat)
            {
                foreach (var btn in row)
                {
                    if (btn.BackColor == Color.Cyan) btn.BackColor = Color.White;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var row in Seat)
            {
                foreach (var btn in row)
                {
                    if (btn.BackColor == Color.Cyan) btn.BackColor = Color.Yellow;
                }
            }
        }
    }
}

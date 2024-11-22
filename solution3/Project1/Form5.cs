using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form5 : Form
    {
        #region Properties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeak = new List<string>()
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        #endregion
        public Form5()
        {
            InitializeComponent();
            loadMatrix();
        }

        void setDefaultDate()
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        void clearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return (date1.Year == date2.Year && 
                    date1.Month == date2.Month && 
                    date1.Day == date2.Day);
        }

        void loadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button x = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < Cons.DayOfWeek; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight
                    };
                    btn.Location = new Point(x.Location.X + x.Width, x.Location.Y);

                    pnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    x = btn;
                }
                x = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(0, x.Location.Y + Cons.dateButtonHeight)
                };
            }
            setDefaultDate();
        }
        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Month % 100 == 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        void addNumberIntoMatrixByDate(DateTime date)
        {
            clearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date) ; i++)
            {
                int column = dateOfWeak.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            addNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            setDefaultDate();
        }

        private void btnTuesday_Click(object sender, EventArgs e)
        {

        }

        private void btnSunday_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMonday_Click(object sender, EventArgs e)
        {

        }
    }
}

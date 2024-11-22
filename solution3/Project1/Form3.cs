using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCourses_SelectedIn(object sender, EventArgs e)
        {
            var selectedIndex = cmbCourses.SelectedIndex;

            lst1.Items.Clear();
            lst2.Items.Clear();

            if (selectedIndex == 0)
            {
                lst1.Items.Add("Project Design");
                lst1.Items.Add("English");
                lst1.Items.Add("Linear Algebra");
            }
            else if (selectedIndex == 1)
            {
                lst1.Items.Add("Basic Programming");
                lst1.Items.Add("Introduction to Database");
                lst1.Items.Add("Data Structures and Algorithms");
                lst1.Items.Add("Windows Programming");
                lst1.Items.Add("Mobile Device Programming");
            }
            else
            {
                lst1.Items.Add("Software Testing");
                lst1.Items.Add("Distributed Databases");
                lst1.Items.Add("Cloud Computing");
                lst1.Items.Add("Deep Learning");
            }
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndex >= 0)
            {
                lst2.Items.Add(lst1.SelectedItem);

                lst1.Items.Remove(lst1.SelectedItem);

                if (lst1.Items.Count > 0)
                {
                    lst1.SelectedIndex = 0;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lst2.SelectedIndex >= 0)
            {
                lst1.Items.Add(lst2.SelectedItem);

                lst2.Items.Remove(lst2.SelectedItem);
    
                if (lst2.Items.Count > 0)
                {
                    lst2.SelectedIndex = 0;
                }
            }
        }

        private void load_form3(object sender, EventArgs e)
        {
            cmbCourses.Items.Add("General");
            cmbCourses.Items.Add("Foundation");
            cmbCourses.Items.Add("Specialized Knowledge");
            cmbCourses.SelectedIndex = 0;
        }
    }
}

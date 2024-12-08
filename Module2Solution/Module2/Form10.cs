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

namespace Module2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog.FileName);
                lblFileSize.Text = $"File Size: {file.Length}";
                lblDateMod.Text = $"Date Modified: {file.LastWriteTime.ToLongDateString()}";
                lblDateAccess.Text = $"Date Accessed: {file.LastAccessTime.ToLongDateString()}";
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}

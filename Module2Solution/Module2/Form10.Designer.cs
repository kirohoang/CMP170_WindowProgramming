namespace Module2
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblDateMod = new System.Windows.Forms.Label();
            this.lblDateAccess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDateAccess);
            this.groupBox1.Controls.Add(this.lblDateMod);
            this.groupBox1.Controls.Add(this.lblFileSize);
            this.groupBox1.Location = new System.Drawing.Point(38, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click Button to Open a picture file";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(260, 16);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(32, 25);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(46, 13);
            this.lblFileSize.TabIndex = 0;
            this.lblFileSize.Text = "File Size";
            // 
            // lblDateMod
            // 
            this.lblDateMod.AutoSize = true;
            this.lblDateMod.Location = new System.Drawing.Point(32, 51);
            this.lblDateMod.Name = "lblDateMod";
            this.lblDateMod.Size = new System.Drawing.Size(103, 13);
            this.lblDateMod.TabIndex = 0;
            this.lblDateMod.Text = "Date Lated Modified";
            // 
            // lblDateAccess
            // 
            this.lblDateAccess.AutoSize = true;
            this.lblDateAccess.Location = new System.Drawing.Point(32, 75);
            this.lblDateAccess.Name = "lblDateAccess";
            this.lblDateAccess.Size = new System.Drawing.Size(98, 13);
            this.lblDateAccess.TabIndex = 0;
            this.lblDateAccess.Text = "Date Lated Access";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 413);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblDateAccess;
        private System.Windows.Forms.Label lblDateMod;
        private System.Windows.Forms.Label lblFileSize;
    }
}
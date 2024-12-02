namespace Module2
{
    partial class Form3
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnFirstName = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.btnFullName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(52, 68);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.DoubleClick += new System.EventHandler(this.labelLastName_DoubleClick);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(52, 119);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.DoubleClick += new System.EventHandler(this.labelFirstName_DoubleClick);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(163, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnFirstName
            // 
            this.btnFirstName.Location = new System.Drawing.Point(163, 187);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(75, 23);
            this.btnFirstName.TabIndex = 2;
            this.btnFirstName.Text = "First Name";
            this.btnFirstName.UseVisualStyleBackColor = true;
            this.btnFirstName.Click += new System.EventHandler(this.btnFirstName_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Location = new System.Drawing.Point(82, 187);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(75, 23);
            this.btnLastName.TabIndex = 2;
            this.btnLastName.Text = "Last Name";
            this.btnLastName.UseVisualStyleBackColor = true;
            this.btnLastName.Click += new System.EventHandler(this.btnLastName_Click);
            // 
            // btnFullName
            // 
            this.btnFullName.Location = new System.Drawing.Point(244, 187);
            this.btnFullName.Name = "btnFullName";
            this.btnFullName.Size = new System.Drawing.Size(75, 23);
            this.btnFullName.TabIndex = 2;
            this.btnFullName.Text = "Full Name";
            this.btnFullName.UseVisualStyleBackColor = true;
            this.btnFullName.Click += new System.EventHandler(this.btnFullName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(163, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(52, 154);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(54, 13);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name";
            this.labelFullName.DoubleClick += new System.EventHandler(this.labelFullName_DoubleClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 285);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnFullName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnFirstName;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.Button btnFullName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelFullName;
    }
}
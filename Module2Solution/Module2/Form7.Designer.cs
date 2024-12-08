namespace Module2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lightOn_picture = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lightOff_picture = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lightOn_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOff_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Location = new System.Drawing.Point(46, 233);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(35, 13);
            this.lblMadeBy.TabIndex = 1;
            this.lblMadeBy.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lightOn_picture
            // 
            this.lightOn_picture.Image = ((System.Drawing.Image)(resources.GetObject("lightOn_picture.Image")));
            this.lightOn_picture.Location = new System.Drawing.Point(97, 42);
            this.lightOn_picture.Name = "lightOn_picture";
            this.lightOn_picture.Size = new System.Drawing.Size(206, 140);
            this.lightOn_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOn_picture.TabIndex = 3;
            this.lightOn_picture.TabStop = false;
            this.lightOn_picture.Visible = false;
            this.lightOn_picture.Click += new System.EventHandler(this.lightOn_picture_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lightOff_picture
            // 
            this.lightOff_picture.Image = ((System.Drawing.Image)(resources.GetObject("lightOff_picture.Image")));
            this.lightOff_picture.Location = new System.Drawing.Point(97, 42);
            this.lightOff_picture.Name = "lightOff_picture";
            this.lightOff_picture.Size = new System.Drawing.Size(206, 140);
            this.lightOff_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightOff_picture.TabIndex = 3;
            this.lightOff_picture.TabStop = false;
            this.lightOff_picture.Click += new System.EventHandler(this.lightOff_picture_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(118, 194);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label2";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 255);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lightOff_picture);
            this.Controls.Add(this.lightOn_picture);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lightOn_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOff_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox lightOn_picture;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox lightOff_picture;
        private System.Windows.Forms.Label lblMessage;
    }
}
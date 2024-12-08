namespace Module2
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoTNR = new System.Windows.Forms.RadioButton();
            this.rdoArial = new System.Windows.Forms.RadioButton();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoCourierNew = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 128);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoTNR
            // 
            this.rdoTNR.AutoSize = true;
            this.rdoTNR.Location = new System.Drawing.Point(332, 46);
            this.rdoTNR.Name = "rdoTNR";
            this.rdoTNR.Size = new System.Drawing.Size(115, 17);
            this.rdoTNR.TabIndex = 3;
            this.rdoTNR.TabStop = true;
            this.rdoTNR.Text = "Times New Roman";
            this.rdoTNR.UseVisualStyleBackColor = true;
            this.rdoTNR.CheckedChanged += new System.EventHandler(this.rdoTNR_CheckedChanged);
            // 
            // rdoArial
            // 
            this.rdoArial.AutoSize = true;
            this.rdoArial.Location = new System.Drawing.Point(332, 84);
            this.rdoArial.Name = "rdoArial";
            this.rdoArial.Size = new System.Drawing.Size(45, 17);
            this.rdoArial.TabIndex = 3;
            this.rdoArial.TabStop = true;
            this.rdoArial.Text = "Arial";
            this.rdoArial.UseVisualStyleBackColor = true;
            this.rdoArial.CheckedChanged += new System.EventHandler(this.rdoArial_CheckedChanged);
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Location = new System.Drawing.Point(332, 118);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(64, 17);
            this.rdoTahoma.TabIndex = 3;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            this.rdoTahoma.CheckedChanged += new System.EventHandler(this.rdoTahoma_CheckedChanged);
            // 
            // rdoCourierNew
            // 
            this.rdoCourierNew.AutoSize = true;
            this.rdoCourierNew.Location = new System.Drawing.Point(332, 157);
            this.rdoCourierNew.Name = "rdoCourierNew";
            this.rdoCourierNew.Size = new System.Drawing.Size(83, 17);
            this.rdoCourierNew.TabIndex = 3;
            this.rdoCourierNew.TabStop = true;
            this.rdoCourierNew.Text = "Courier New";
            this.rdoCourierNew.UseVisualStyleBackColor = true;
            this.rdoCourierNew.CheckedChanged += new System.EventHandler(this.rdoCourierNew_CheckedChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 267);
            this.Controls.Add(this.rdoCourierNew);
            this.Controls.Add(this.rdoTahoma);
            this.Controls.Add(this.rdoArial);
            this.Controls.Add(this.rdoTNR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoTNR;
        private System.Windows.Forms.RadioButton rdoArial;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoCourierNew;
    }
}
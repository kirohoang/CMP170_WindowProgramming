namespace Test_2280603437
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMatrix = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Matrix";
            // 
            // cmbMatrix
            // 
            this.cmbMatrix.FormattingEnabled = true;
            this.cmbMatrix.Location = new System.Drawing.Point(127, 40);
            this.cmbMatrix.Name = "cmbMatrix";
            this.cmbMatrix.Size = new System.Drawing.Size(121, 21);
            this.cmbMatrix.TabIndex = 1;
            this.cmbMatrix.SelectedIndexChanged += new System.EventHandler(this.cmbMatrix_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(254, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelMatrix
            // 
            this.panelMatrix.Location = new System.Drawing.Point(12, 91);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(419, 369);
            this.panelMatrix.TabIndex = 3;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(177, 486);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTimer.Size = new System.Drawing.Size(47, 13);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Time: 0s";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 518);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbMatrix);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMatrix;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Label labelTimer;
    }
}
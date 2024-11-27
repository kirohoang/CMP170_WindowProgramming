namespace Test_2280603437
{
    partial class Form1
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_FullName = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkboxSubject = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit_Click = new System.Windows.Forms.Button();
            this.checkboxSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(51, 102);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            this.label_ID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(26, 155);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(54, 13);
            this.label_FullName.TabIndex = 0;
            this.label_FullName.Text = "Full Name";
            this.label_FullName.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(34, 216);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(33, 13);
            this.label_Major.TabIndex = 0;
            this.label_Major.Text = "Major";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(398, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkboxSubject
            // 
            this.checkboxSubject.Controls.Add(this.checkBox4);
            this.checkboxSubject.Controls.Add(this.checkBox3);
            this.checkboxSubject.Controls.Add(this.checkBox2);
            this.checkboxSubject.Controls.Add(this.checkBox1);
            this.checkboxSubject.Location = new System.Drawing.Point(75, 265);
            this.checkboxSubject.Name = "checkboxSubject";
            this.checkboxSubject.Size = new System.Drawing.Size(120, 135);
            this.checkboxSubject.TabIndex = 2;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Subject 8";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Subject 7";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Subject 6";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Subject 5";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(86, 152);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(86, 213);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(98, 21);
            this.cmbMajor.TabIndex = 4;
            this.cmbMajor.SelectedIndexChanged += new System.EventHandler(this.cmbMajor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 331);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeader);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(479, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit_Click
            // 
            this.btnExit_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_Click.Location = new System.Drawing.Point(560, 376);
            this.btnExit_Click.Name = "btnExit_Click";
            this.btnExit_Click.Size = new System.Drawing.Size(75, 37);
            this.btnExit_Click.TabIndex = 1;
            this.btnExit_Click.Text = "Exit";
            this.btnExit_Click.UseVisualStyleBackColor = true;
            this.btnExit_Click.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.checkboxSubject);
            this.Controls.Add(this.btnExit_Click);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.checkboxSubject.ResumeLayout(false);
            this.checkboxSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel checkboxSubject;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit_Click;
    }
}


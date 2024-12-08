namespace Module2
{
    partial class Form4
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoneyTransfer = new System.Windows.Forms.TextBox();
            this.btnVNDtoUSD = new System.Windows.Forms.Button();
            this.btnVNDtoEUR = new System.Windows.Forms.Button();
            this.btnUSDtoVND = new System.Windows.Forms.Button();
            this.btnEURtoVND = new System.Windows.Forms.Button();
            this.txtMoneyTransfered = new System.Windows.Forms.TextBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.btnExchangeRateDollar = new System.Windows.Forms.Button();
            this.btnExchangeRateEur = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(62, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 13);
            label2.TabIndex = 1;
            label2.Text = "Money Transfer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 13);
            label3.TabIndex = 1;
            label3.Text = "Money Transfered:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(59, 227);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 13);
            label4.TabIndex = 1;
            label4.Text = "Exchange Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Transfer";
            // 
            // txtMoneyTransfer
            // 
            this.txtMoneyTransfer.Location = new System.Drawing.Point(149, 54);
            this.txtMoneyTransfer.Name = "txtMoneyTransfer";
            this.txtMoneyTransfer.Size = new System.Drawing.Size(204, 20);
            this.txtMoneyTransfer.TabIndex = 2;
            // 
            // btnVNDtoUSD
            // 
            this.btnVNDtoUSD.Location = new System.Drawing.Point(12, 98);
            this.btnVNDtoUSD.Name = "btnVNDtoUSD";
            this.btnVNDtoUSD.Size = new System.Drawing.Size(88, 23);
            this.btnVNDtoUSD.TabIndex = 3;
            this.btnVNDtoUSD.Text = "VND to USD";
            this.btnVNDtoUSD.UseVisualStyleBackColor = true;
            this.btnVNDtoUSD.Click += new System.EventHandler(this.btnVNDtoUSD_Click);
            // 
            // btnVNDtoEUR
            // 
            this.btnVNDtoEUR.Location = new System.Drawing.Point(149, 98);
            this.btnVNDtoEUR.Name = "btnVNDtoEUR";
            this.btnVNDtoEUR.Size = new System.Drawing.Size(81, 23);
            this.btnVNDtoEUR.TabIndex = 3;
            this.btnVNDtoEUR.Text = "VND to EUR";
            this.btnVNDtoEUR.UseVisualStyleBackColor = true;
            this.btnVNDtoEUR.Click += new System.EventHandler(this.btnVNDtoEUR_Click);
            // 
            // btnUSDtoVND
            // 
            this.btnUSDtoVND.Location = new System.Drawing.Point(265, 98);
            this.btnUSDtoVND.Name = "btnUSDtoVND";
            this.btnUSDtoVND.Size = new System.Drawing.Size(88, 23);
            this.btnUSDtoVND.TabIndex = 3;
            this.btnUSDtoVND.Text = "USD to VND";
            this.btnUSDtoVND.UseVisualStyleBackColor = true;
            this.btnUSDtoVND.Click += new System.EventHandler(this.btnUSDtoVND_Click);
            // 
            // btnEURtoVND
            // 
            this.btnEURtoVND.Location = new System.Drawing.Point(397, 98);
            this.btnEURtoVND.Name = "btnEURtoVND";
            this.btnEURtoVND.Size = new System.Drawing.Size(87, 23);
            this.btnEURtoVND.TabIndex = 3;
            this.btnEURtoVND.Text = "EUR to VND";
            this.btnEURtoVND.UseVisualStyleBackColor = true;
            this.btnEURtoVND.Click += new System.EventHandler(this.btnEURtoVND_Click);
            // 
            // txtMoneyTransfered
            // 
            this.txtMoneyTransfered.BackColor = System.Drawing.Color.Silver;
            this.txtMoneyTransfered.Location = new System.Drawing.Point(149, 161);
            this.txtMoneyTransfered.Name = "txtMoneyTransfered";
            this.txtMoneyTransfered.Size = new System.Drawing.Size(204, 20);
            this.txtMoneyTransfered.TabIndex = 2;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(149, 224);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.txtExchangeRate.TabIndex = 2;
            // 
            // btnExchangeRateDollar
            // 
            this.btnExchangeRateDollar.Location = new System.Drawing.Point(255, 202);
            this.btnExchangeRateDollar.Name = "btnExchangeRateDollar";
            this.btnExchangeRateDollar.Size = new System.Drawing.Size(114, 23);
            this.btnExchangeRateDollar.TabIndex = 4;
            this.btnExchangeRateDollar.Text = "$ Exchange Rate";
            this.btnExchangeRateDollar.UseVisualStyleBackColor = true;
            this.btnExchangeRateDollar.Click += new System.EventHandler(this.btnExchangeRateDollar_Click);
            // 
            // btnExchangeRateEur
            // 
            this.btnExchangeRateEur.Location = new System.Drawing.Point(255, 242);
            this.btnExchangeRateEur.Name = "btnExchangeRateEur";
            this.btnExchangeRateEur.Size = new System.Drawing.Size(114, 23);
            this.btnExchangeRateEur.TabIndex = 4;
            this.btnExchangeRateEur.Text = "Eur Exchange Rate";
            this.btnExchangeRateEur.UseVisualStyleBackColor = true;
            this.btnExchangeRateEur.Click += new System.EventHandler(this.btnExchangeRateEur_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 290);
            this.Controls.Add(this.btnExchangeRateEur);
            this.Controls.Add(this.btnExchangeRateDollar);
            this.Controls.Add(this.btnEURtoVND);
            this.Controls.Add(this.btnUSDtoVND);
            this.Controls.Add(this.btnVNDtoEUR);
            this.Controls.Add(this.btnVNDtoUSD);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtMoneyTransfered);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtMoneyTransfer);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoneyTransfer;
        private System.Windows.Forms.Button btnVNDtoUSD;
        private System.Windows.Forms.Button btnVNDtoEUR;
        private System.Windows.Forms.Button btnUSDtoVND;
        private System.Windows.Forms.Button btnEURtoVND;
        private System.Windows.Forms.TextBox txtMoneyTransfered;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Button btnExchangeRateDollar;
        private System.Windows.Forms.Button btnExchangeRateEur;
    }
}
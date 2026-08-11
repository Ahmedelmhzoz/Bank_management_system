namespace BankSystem {
    partial class FrmTransactionProcess {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblTransactionProcess = new System.Windows.Forms.Label();
            this.numericalMoney = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoProcess = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.personCard1 = new BankSystem.PersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.numericalMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransactionProcess
            // 
            this.lblTransactionProcess.AutoSize = true;
            this.lblTransactionProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransactionProcess.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.lblTransactionProcess.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblTransactionProcess.Location = new System.Drawing.Point(158, 44);
            this.lblTransactionProcess.Name = "lblTransactionProcess";
            this.lblTransactionProcess.Size = new System.Drawing.Size(341, 88);
            this.lblTransactionProcess.TabIndex = 29;
            this.lblTransactionProcess.Text = "Client details:";
            // 
            // numericalMoney
            // 
            this.numericalMoney.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericalMoney.Location = new System.Drawing.Point(665, 74);
            this.numericalMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericalMoney.Name = "numericalMoney";
            this.numericalMoney.Size = new System.Drawing.Size(404, 38);
            this.numericalMoney.TabIndex = 30;
            this.numericalMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericalMoney.Validating += new System.ComponentModel.CancelEventHandler(this.numericalMoney_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystem.Properties.Resources.atm;
            this.pictureBox1.Location = new System.Drawing.Point(519, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 70);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoProcess
            // 
            this.btnDoProcess.BackColor = System.Drawing.Color.Teal;
            this.btnDoProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoProcess.ForeColor = System.Drawing.Color.Cyan;
            this.btnDoProcess.Location = new System.Drawing.Point(1137, 44);
            this.btnDoProcess.Name = "btnDoProcess";
            this.btnDoProcess.Size = new System.Drawing.Size(230, 103);
            this.btnDoProcess.TabIndex = 32;
            this.btnDoProcess.Text = "Deposit";
            this.btnDoProcess.UseVisualStyleBackColor = false;
            this.btnDoProcess.Click += new System.EventHandler(this.btnDoProcess_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Image = global::BankSystem.Properties.Resources.close;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1351, 723);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 68);
            this.button3.TabIndex = 33;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // personCard1
            // 
            this.personCard1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personCard1.Location = new System.Drawing.Point(81, 153);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(1355, 564);
            this.personCard1.TabIndex = 0;
            // 
            // FrmTransactionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1573, 802);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDoProcess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericalMoney);
            this.Controls.Add(this.lblTransactionProcess);
            this.Controls.Add(this.personCard1);
            this.Name = "FrmTransactionProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransactionProcess";
            ((System.ComponentModel.ISupportInitialize)(this.numericalMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.Label lblTransactionProcess;
        private System.Windows.Forms.NumericUpDown numericalMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDoProcess;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
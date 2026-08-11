namespace BankSystem {
    partial class FrmTransactions {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTotalBalances = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblTransactionProcess = new System.Windows.Forms.Label();
            this.lblWrongAcc = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 30.9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(522, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 103);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transactions";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Teal;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Cyan;
            this.btnWithdraw.Location = new System.Drawing.Point(540, 423);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(354, 102);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.BackColor = System.Drawing.Color.Teal;
            this.btnTotalBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBalances.ForeColor = System.Drawing.Color.Cyan;
            this.btnTotalBalances.Location = new System.Drawing.Point(540, 591);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Size = new System.Drawing.Size(354, 102);
            this.btnTotalBalances.TabIndex = 11;
            this.btnTotalBalances.Text = "Total balances";
            this.btnTotalBalances.UseVisualStyleBackColor = false;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(737, 809);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(345, 38);
            this.txtAccountNumber.TabIndex = 13;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessage1.Font = new System.Drawing.Font("Microsoft Himalaya", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblMessage1.Location = new System.Drawing.Point(47, 798);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(488, 67);
            this.lblMessage1.TabIndex = 14;
            this.lblMessage1.Text = "Enter account number to";
            // 
            // lblTransactionProcess
            // 
            this.lblTransactionProcess.AutoSize = true;
            this.lblTransactionProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransactionProcess.Font = new System.Drawing.Font("Microsoft Himalaya", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionProcess.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblTransactionProcess.Location = new System.Drawing.Point(515, 798);
            this.lblTransactionProcess.Name = "lblTransactionProcess";
            this.lblTransactionProcess.Size = new System.Drawing.Size(176, 67);
            this.lblTransactionProcess.TabIndex = 15;
            this.lblTransactionProcess.Text = "deposit:";
            // 
            // lblWrongAcc
            // 
            this.lblWrongAcc.AutoSize = true;
            this.lblWrongAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWrongAcc.Font = new System.Drawing.Font("Microsoft Himalaya", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAcc.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongAcc.Location = new System.Drawing.Point(47, 936);
            this.lblWrongAcc.Name = "lblWrongAcc";
            this.lblWrongAcc.Size = new System.Drawing.Size(131, 67);
            this.lblWrongAcc.TabIndex = 16;
            this.lblWrongAcc.Text = "A150";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Himalaya", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.Crimson;
            this.lblMessage2.Location = new System.Drawing.Point(177, 936);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(330, 67);
            this.lblMessage2.TabIndex = 17;
            this.lblMessage2.Text = "Is out of service";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Teal;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.Cyan;
            this.btnEnter.Location = new System.Drawing.Point(1137, 775);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(127, 102);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Teal;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Cyan;
            this.btnDeposit.Location = new System.Drawing.Point(540, 245);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(354, 102);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Image = global::BankSystem.Properties.Resources.close;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1109, 992);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 68);
            this.button3.TabIndex = 12;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1352, 1081);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblWrongAcc);
            this.Controls.Add(this.lblTransactionProcess);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTotalBalances);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeposit);
            this.Name = "FrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransactions";
            this.Load += new System.EventHandler(this.FrmTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTotalBalances;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblTransactionProcess;
        private System.Windows.Forms.Label lblWrongAcc;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDeposit;
    }
}
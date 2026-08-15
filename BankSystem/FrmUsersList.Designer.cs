namespace BankSystem {
    partial class FrmUsersList {
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
            this.ucUsersList1 = new BankSystem.ucUsersList();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblUsersNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucUsersList1
            // 
            this.ucUsersList1.BackColor = System.Drawing.Color.Black;
            this.ucUsersList1.Location = new System.Drawing.Point(-9, 169);
            this.ucUsersList1.Name = "ucUsersList1";
            this.ucUsersList1.Size = new System.Drawing.Size(1439, 1115);
            this.ucUsersList1.TabIndex = 0;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Cyan;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.Color.Teal;
            this.lblProcess.Location = new System.Drawing.Point(561, 24);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(336, 76);
            this.lblProcess.TabIndex = 5;
            this.lblProcess.Text = "Users list:";
            // 
            // lblUsersNumber
            // 
            this.lblUsersNumber.AutoSize = true;
            this.lblUsersNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.lblUsersNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblUsersNumber.Location = new System.Drawing.Point(1215, 218);
            this.lblUsersNumber.Name = "lblUsersNumber";
            this.lblUsersNumber.Size = new System.Drawing.Size(160, 39);
            this.lblUsersNumber.TabIndex = 66;
            this.lblUsersNumber.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(821, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 54);
            this.label2.TabIndex = 67;
            this.label2.Text = "Number of users:";
            // 
            // FrmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1419, 1286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsersNumber);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.ucUsersList1);
            this.Name = "FrmUsersList";
            this.Text = "FrmUsersList";
            this.Load += new System.EventHandler(this.FrmUsersList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucUsersList ucUsersList1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblUsersNumber;
        private System.Windows.Forms.Label label2;
    }
}
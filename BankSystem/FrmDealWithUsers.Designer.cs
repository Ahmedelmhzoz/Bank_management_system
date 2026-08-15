namespace BankSystem {
    partial class FrmDealWithUsers {
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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.ucUsersList1 = new BankSystem.ucUsersList();
            this.SuspendLayout();
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateUser.BackgroundImage = global::BankSystem.Properties.Resources.Update;
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.Location = new System.Drawing.Point(983, 194);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(153, 58);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteUser.BackgroundImage = global::BankSystem.Properties.Resources.delete;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(1202, 194);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 58);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Cyan;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.Color.Teal;
            this.lblProcess.Location = new System.Drawing.Point(566, 33);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(349, 76);
            this.lblProcess.TabIndex = 4;
            this.lblProcess.Text = "Find User:";
            // 
            // ucUsersList1
            // 
            this.ucUsersList1.BackColor = System.Drawing.Color.Black;
            this.ucUsersList1.Location = new System.Drawing.Point(-11, 169);
            this.ucUsersList1.Name = "ucUsersList1";
            this.ucUsersList1.Size = new System.Drawing.Size(1439, 1115);
            this.ucUsersList1.TabIndex = 0;
            // 
            // FrmDealWithUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1407, 1285);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.ucUsersList1);
            this.Name = "FrmDealWithUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDealWithUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucUsersList ucUsersList1;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblProcess;
    }
}
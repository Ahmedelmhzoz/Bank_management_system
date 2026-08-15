namespace BankSystem {
    partial class FrmUserProcess {
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fdChooseImg = new System.Windows.Forms.OpenFileDialog();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkDeleteU = new System.Windows.Forms.CheckBox();
            this.chkUpdateU = new System.Windows.Forms.CheckBox();
            this.chkFindU = new System.Windows.Forms.CheckBox();
            this.chkAddU = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkDeleteC = new System.Windows.Forms.CheckBox();
            this.chkShowC = new System.Windows.Forms.CheckBox();
            this.chkFindC = new System.Windows.Forms.CheckBox();
            this.chkShowU = new System.Windows.Forms.CheckBox();
            this.chkUpdateC = new System.Windows.Forms.CheckBox();
            this.chkAddC = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(927, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 47);
            this.label4.TabIndex = 28;
            this.label4.Text = "password:";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Uighur", 22F, System.Drawing.FontStyle.Bold);
            this.lblProcess.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblProcess.Location = new System.Drawing.Point(643, 28);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(342, 88);
            this.lblProcess.TabIndex = 27;
            this.lblProcess.Text = "Add new user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(88, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 47);
            this.label1.TabIndex = 26;
            this.label1.Text = "Username:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fdChooseImg
            // 
            this.fdChooseImg.FileName = "openFileDialog1";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(367, 192);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(349, 38);
            this.txtUsername.TabIndex = 25;
            this.txtUsername.Tag = "Account number";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.Cyan;
            this.btnSave.Image = global::BankSystem.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(703, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 122);
            this.btnSave.TabIndex = 35;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1167, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(349, 38);
            this.txtPassword.TabIndex = 36;
            this.txtPassword.Tag = "Client name";
            // 
            // chkDeleteU
            // 
            this.chkDeleteU.AutoSize = true;
            this.chkDeleteU.BackColor = System.Drawing.Color.Aqua;
            this.chkDeleteU.ForeColor = System.Drawing.Color.Black;
            this.chkDeleteU.Location = new System.Drawing.Point(182, 635);
            this.chkDeleteU.Name = "chkDeleteU";
            this.chkDeleteU.Size = new System.Drawing.Size(197, 36);
            this.chkDeleteU.TabIndex = 89;
            this.chkDeleteU.Tag = "enDeleteUser";
            this.chkDeleteU.Text = "Delete user";
            this.chkDeleteU.UseVisualStyleBackColor = false;
            // 
            // chkUpdateU
            // 
            this.chkUpdateU.AutoSize = true;
            this.chkUpdateU.BackColor = System.Drawing.Color.Aqua;
            this.chkUpdateU.ForeColor = System.Drawing.Color.Black;
            this.chkUpdateU.Location = new System.Drawing.Point(1220, 513);
            this.chkUpdateU.Name = "chkUpdateU";
            this.chkUpdateU.Size = new System.Drawing.Size(206, 36);
            this.chkUpdateU.TabIndex = 88;
            this.chkUpdateU.Tag = "enUpdateUser";
            this.chkUpdateU.Text = "Update user";
            this.chkUpdateU.UseVisualStyleBackColor = false;
            // 
            // chkFindU
            // 
            this.chkFindU.AutoSize = true;
            this.chkFindU.BackColor = System.Drawing.Color.Aqua;
            this.chkFindU.ForeColor = System.Drawing.Color.Black;
            this.chkFindU.Location = new System.Drawing.Point(935, 513);
            this.chkFindU.Name = "chkFindU";
            this.chkFindU.Size = new System.Drawing.Size(170, 36);
            this.chkFindU.TabIndex = 87;
            this.chkFindU.Tag = "enFindUser";
            this.chkFindU.Text = "Find user";
            this.chkFindU.UseVisualStyleBackColor = false;
            // 
            // chkAddU
            // 
            this.chkAddU.AutoSize = true;
            this.chkAddU.BackColor = System.Drawing.Color.Aqua;
            this.chkAddU.ForeColor = System.Drawing.Color.Black;
            this.chkAddU.Location = new System.Drawing.Point(703, 513);
            this.chkAddU.Name = "chkAddU";
            this.chkAddU.Size = new System.Drawing.Size(165, 36);
            this.chkAddU.TabIndex = 86;
            this.chkAddU.Tag = "enAddUser";
            this.chkAddU.Text = "Add user";
            this.chkAddU.UseVisualStyleBackColor = false;
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.BackColor = System.Drawing.Color.Aqua;
            this.chkTransactions.ForeColor = System.Drawing.Color.Black;
            this.chkTransactions.Location = new System.Drawing.Point(184, 513);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(215, 36);
            this.chkTransactions.TabIndex = 85;
            this.chkTransactions.Tag = "enTransactions";
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = false;
            // 
            // chkDeleteC
            // 
            this.chkDeleteC.AutoSize = true;
            this.chkDeleteC.BackColor = System.Drawing.Color.Aqua;
            this.chkDeleteC.ForeColor = System.Drawing.Color.Black;
            this.chkDeleteC.Location = new System.Drawing.Point(1220, 408);
            this.chkDeleteC.Name = "chkDeleteC";
            this.chkDeleteC.Size = new System.Drawing.Size(210, 36);
            this.chkDeleteC.TabIndex = 84;
            this.chkDeleteC.Tag = "enDeleteClient";
            this.chkDeleteC.Text = "Delete client";
            this.chkDeleteC.UseVisualStyleBackColor = false;
            // 
            // chkShowC
            // 
            this.chkShowC.AutoSize = true;
            this.chkShowC.BackColor = System.Drawing.Color.Aqua;
            this.chkShowC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkShowC.Location = new System.Drawing.Point(428, 408);
            this.chkShowC.Name = "chkShowC";
            this.chkShowC.Size = new System.Drawing.Size(212, 36);
            this.chkShowC.TabIndex = 83;
            this.chkShowC.Tag = "enShowClient";
            this.chkShowC.Text = "Show clients";
            this.chkShowC.UseVisualStyleBackColor = false;
            // 
            // chkFindC
            // 
            this.chkFindC.AutoSize = true;
            this.chkFindC.BackColor = System.Drawing.Color.Aqua;
            this.chkFindC.ForeColor = System.Drawing.Color.Black;
            this.chkFindC.Location = new System.Drawing.Point(703, 408);
            this.chkFindC.Name = "chkFindC";
            this.chkFindC.Size = new System.Drawing.Size(183, 36);
            this.chkFindC.TabIndex = 82;
            this.chkFindC.Tag = "enFindClient";
            this.chkFindC.Text = "Find client";
            this.chkFindC.UseVisualStyleBackColor = false;
            // 
            // chkShowU
            // 
            this.chkShowU.AutoSize = true;
            this.chkShowU.BackColor = System.Drawing.Color.Aqua;
            this.chkShowU.ForeColor = System.Drawing.Color.Black;
            this.chkShowU.Location = new System.Drawing.Point(428, 513);
            this.chkShowU.Name = "chkShowU";
            this.chkShowU.Size = new System.Drawing.Size(199, 36);
            this.chkShowU.TabIndex = 81;
            this.chkShowU.Tag = "enShowUsers";
            this.chkShowU.Text = "Show users";
            this.chkShowU.UseVisualStyleBackColor = false;
            // 
            // chkUpdateC
            // 
            this.chkUpdateC.AutoSize = true;
            this.chkUpdateC.BackColor = System.Drawing.Color.Aqua;
            this.chkUpdateC.ForeColor = System.Drawing.Color.Black;
            this.chkUpdateC.Location = new System.Drawing.Point(935, 408);
            this.chkUpdateC.Name = "chkUpdateC";
            this.chkUpdateC.Size = new System.Drawing.Size(219, 36);
            this.chkUpdateC.TabIndex = 80;
            this.chkUpdateC.Tag = "enUpdateClient";
            this.chkUpdateC.Text = "Update client";
            this.chkUpdateC.UseVisualStyleBackColor = false;
            // 
            // chkAddC
            // 
            this.chkAddC.AutoSize = true;
            this.chkAddC.BackColor = System.Drawing.Color.Cyan;
            this.chkAddC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAddC.Location = new System.Drawing.Point(182, 408);
            this.chkAddC.Name = "chkAddC";
            this.chkAddC.Size = new System.Drawing.Size(178, 36);
            this.chkAddC.TabIndex = 79;
            this.chkAddC.Tag = "enAddClient";
            this.chkAddC.Text = "Add client";
            this.chkAddC.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(88, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 47);
            this.label2.TabIndex = 78;
            this.label2.Text = "permissions:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.Image = global::BankSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1379, 827);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 59);
            this.btnClose.TabIndex = 90;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FrmUserProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1605, 911);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkDeleteU);
            this.Controls.Add(this.chkUpdateU);
            this.Controls.Add(this.chkFindU);
            this.Controls.Add(this.chkAddU);
            this.Controls.Add(this.chkTransactions);
            this.Controls.Add(this.chkDeleteC);
            this.Controls.Add(this.chkShowC);
            this.Controls.Add(this.chkFindC);
            this.Controls.Add(this.chkShowU);
            this.Controls.Add(this.chkUpdateC);
            this.Controls.Add(this.chkAddC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmUserProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserProcess";
            this.Load += new System.EventHandler(this.FrmUserProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog fdChooseImg;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkDeleteU;
        private System.Windows.Forms.CheckBox chkUpdateU;
        private System.Windows.Forms.CheckBox chkFindU;
        private System.Windows.Forms.CheckBox chkAddU;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkDeleteC;
        private System.Windows.Forms.CheckBox chkShowC;
        private System.Windows.Forms.CheckBox chkFindC;
        private System.Windows.Forms.CheckBox chkShowU;
        private System.Windows.Forms.CheckBox chkUpdateC;
        private System.Windows.Forms.CheckBox chkAddC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}
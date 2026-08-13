namespace BankSystem {
    partial class FrmLogin {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linklblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblPassConfirm = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::BankSystem.Properties.Resources.userName;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(979, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::BankSystem.Properties.Resources.Password;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(976, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 17.9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(787, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 17.9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(787, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1109, 413);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(342, 38);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1109, 546);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(342, 38);
            this.txtPassword.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogin.Location = new System.Drawing.Point(942, 860);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(354, 129);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linklblCreateAcc
            // 
            this.linklblCreateAcc.AutoSize = true;
            this.linklblCreateAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linklblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.linklblCreateAcc.Location = new System.Drawing.Point(950, 1028);
            this.linklblCreateAcc.Name = "linklblCreateAcc";
            this.linklblCreateAcc.Size = new System.Drawing.Size(325, 39);
            this.linklblCreateAcc.TabIndex = 15;
            this.linklblCreateAcc.TabStop = true;
            this.linklblCreateAcc.Text = "Don\'t have account?";
            this.linklblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreateAcc_LinkClicked);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Black;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Himalaya", 14.9F, System.Drawing.FontStyle.Bold);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErrorMessage.Location = new System.Drawing.Point(883, 263);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(493, 50);
            this.lblErrorMessage.TabIndex = 16;
            this.lblErrorMessage.Text = "Wrong password or username )-:";
            this.lblErrorMessage.Visible = false;
            // 
            // lblPassConfirm
            // 
            this.lblPassConfirm.AutoSize = true;
            this.lblPassConfirm.BackColor = System.Drawing.Color.Black;
            this.lblPassConfirm.Font = new System.Drawing.Font("Microsoft Himalaya", 12.9F, System.Drawing.FontStyle.Bold);
            this.lblPassConfirm.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPassConfirm.Location = new System.Drawing.Point(789, 660);
            this.lblPassConfirm.Name = "lblPassConfirm";
            this.lblPassConfirm.Size = new System.Drawing.Size(309, 43);
            this.lblPassConfirm.TabIndex = 17;
            this.lblPassConfirm.Text = "password Confirmation";
            this.lblPassConfirm.Visible = false;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(1109, 660);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(342, 38);
            this.txtConfirmPass.TabIndex = 18;
            this.txtConfirmPass.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 20.9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(945, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 70);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bank system app";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem.Properties.Resources.loginBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1516, 1131);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblPassConfirm);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.linklblCreateAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linklblCreateAcc;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblPassConfirm;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label3;
    }
}
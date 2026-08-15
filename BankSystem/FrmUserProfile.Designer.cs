namespace BankSystem {
    partial class FrmUserProfile {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserProfile));
            this.btnChange = new System.Windows.Forms.Button();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNEw = new System.Windows.Forms.Label();
            this.profileCard1 = new BankSystem.ProfileCard();
            this.linklblChangePass = new System.Windows.Forms.LinkLabel();
            this.btnUpdateOrSetImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Teal;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Cyan;
            this.btnChange.Location = new System.Drawing.Point(1343, 961);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(250, 106);
            this.btnChange.TabIndex = 11;
            this.btnChange.Tag = "processesPermissions.";
            this.btnChange.Text = "Change password";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(1172, 1118);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(377, 38);
            this.txtOld.TabIndex = 12;
            this.txtOld.Visible = false;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(1172, 1204);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(377, 38);
            this.txtNew.TabIndex = 13;
            this.txtNew.Visible = false;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.lblOld.ForeColor = System.Drawing.Color.Azure;
            this.lblOld.Location = new System.Drawing.Point(863, 1109);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(285, 47);
            this.lblOld.TabIndex = 64;
            this.lblOld.Text = "Old password:";
            this.lblOld.Visible = false;
            // 
            // lblNEw
            // 
            this.lblNEw.AutoSize = true;
            this.lblNEw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNEw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.lblNEw.ForeColor = System.Drawing.Color.Azure;
            this.lblNEw.Location = new System.Drawing.Point(863, 1196);
            this.lblNEw.Name = "lblNEw";
            this.lblNEw.Size = new System.Drawing.Size(303, 47);
            this.lblNEw.TabIndex = 65;
            this.lblNEw.Text = "New password:";
            this.lblNEw.Visible = false;
            // 
            // profileCard1
            // 
            this.profileCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileCard1.BackgroundImage")));
            this.profileCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileCard1.Location = new System.Drawing.Point(-10, -39);
            this.profileCard1.Name = "profileCard1";
            this.profileCard1.Size = new System.Drawing.Size(1674, 1321);
            this.profileCard1.TabIndex = 0;
            // 
            // linklblChangePass
            // 
            this.linklblChangePass.AutoSize = true;
            this.linklblChangePass.Location = new System.Drawing.Point(1113, 1118);
            this.linklblChangePass.Name = "linklblChangePass";
            this.linklblChangePass.Size = new System.Drawing.Size(258, 32);
            this.linklblChangePass.TabIndex = 66;
            this.linklblChangePass.TabStop = true;
            this.linklblChangePass.Text = "Change password?";
            this.linklblChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblChangePass_LinkClicked);
            // 
            // btnUpdateOrSetImage
            // 
            this.btnUpdateOrSetImage.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateOrSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrSetImage.ForeColor = System.Drawing.Color.Cyan;
            this.btnUpdateOrSetImage.Location = new System.Drawing.Point(1392, 147);
            this.btnUpdateOrSetImage.Name = "btnUpdateOrSetImage";
            this.btnUpdateOrSetImage.Size = new System.Drawing.Size(171, 140);
            this.btnUpdateOrSetImage.TabIndex = 67;
            this.btnUpdateOrSetImage.Text = "Update image";
            this.btnUpdateOrSetImage.UseVisualStyleBackColor = false;
            this.btnUpdateOrSetImage.Click += new System.EventHandler(this.btnUpdateOrSetImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1615, 1280);
            this.Controls.Add(this.btnUpdateOrSetImage);
            this.Controls.Add(this.linklblChangePass);
            this.Controls.Add(this.lblNEw);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.profileCard1);
            this.Name = "FrmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserProfile";
            this.Load += new System.EventHandler(this.FrmUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProfileCard profileCard1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNEw;
        private System.Windows.Forms.LinkLabel linklblChangePass;
        private System.Windows.Forms.Button btnUpdateOrSetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
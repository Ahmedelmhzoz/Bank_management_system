namespace BankSystem {
    partial class FrmUserDetails {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserDetails));
            this.profileCard1 = new BankSystem.ProfileCard();
            this.SuspendLayout();
            // 
            // profileCard1
            // 
            this.profileCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileCard1.BackgroundImage")));
            this.profileCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileCard1.Location = new System.Drawing.Point(-16, -29);
            this.profileCard1.Name = "profileCard1";
            this.profileCard1.Size = new System.Drawing.Size(1674, 1345);
            this.profileCard1.TabIndex = 0;
            // 
            // FrmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 1257);
            this.Controls.Add(this.profileCard1);
            this.Name = "FrmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private ProfileCard profileCard1;
    }
}
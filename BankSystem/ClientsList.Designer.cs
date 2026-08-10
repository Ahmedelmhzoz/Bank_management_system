namespace BankSystem {
    partial class ClientsList {
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
            this.dgvClients1 = new BankSystem.dgvClients();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientsNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(751, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinets number:";
            // 
            // dgvClients1
            // 
            this.dgvClients1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClients1.Location = new System.Drawing.Point(-10, 229);
            this.dgvClients1.Name = "dgvClients1";
            this.dgvClients1.Size = new System.Drawing.Size(1959, 1172);
            this.dgvClients1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(805, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clinets list:";
            // 
            // lblClientsNum
            // 
            this.lblClientsNum.AutoSize = true;
            this.lblClientsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientsNum.ForeColor = System.Drawing.Color.Cyan;
            this.lblClientsNum.Location = new System.Drawing.Point(1106, 158);
            this.lblClientsNum.Name = "lblClientsNum";
            this.lblClientsNum.Size = new System.Drawing.Size(194, 46);
            this.lblClientsNum.TabIndex = 3;
            this.lblClientsNum.Text = "Unknown";
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1950, 1260);
            this.Controls.Add(this.lblClientsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients1);
            this.Name = "ClientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dgvClients dgvClients1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientsNum;
    }
}
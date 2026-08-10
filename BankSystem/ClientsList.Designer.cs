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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(799, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinets list:";
            // 
            // dgvClients1
            // 
            this.dgvClients1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClients1.Location = new System.Drawing.Point(-3, 99);
            this.dgvClients1.Name = "dgvClients1";
            this.dgvClients1.Size = new System.Drawing.Size(1959, 1085);
            this.dgvClients1.TabIndex = 0;
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1950, 1116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients1);
            this.Name = "ClientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dgvClients dgvClients1;
        private System.Windows.Forms.Label label1;
    }
}
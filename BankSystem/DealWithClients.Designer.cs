namespace BankSystem {
    partial class DealWithClients {
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
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.dgvClients = new BankSystem.ClientsFilter();
            this.SuspendLayout();
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.BackgroundImage = global::BankSystem.Properties.Resources.delete;
            this.btnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteClient.Location = new System.Drawing.Point(1698, 191);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(196, 100);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateClient.BackgroundImage = global::BankSystem.Properties.Resources.Update;
            this.btnUpdateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateClient.Location = new System.Drawing.Point(1395, 191);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(196, 100);
            this.btnUpdateClient.TabIndex = 1;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.BackColor = System.Drawing.Color.Cyan;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.Color.Teal;
            this.lblProcess.Location = new System.Drawing.Point(800, 47);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(379, 76);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "Find Client:";
            // 
            // dgvClients
            // 
            this.dgvClients.BackColor = System.Drawing.Color.Black;
            this.dgvClients.Location = new System.Drawing.Point(-5, 135);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(1959, 1133);
            this.dgvClients.TabIndex = 0;
            // 
            // DealWithClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1947, 1268);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.dgvClients);
            this.Name = "DealWithClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealWithClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientsFilter dgvClients;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Label lblProcess;
    }
}
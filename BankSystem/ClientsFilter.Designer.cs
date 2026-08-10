namespace BankSystem {
    partial class ClientsFilter {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvClients1 = new BankSystem.dgvClients();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dgvClients1
            // 
            this.dgvClients1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClients1.Location = new System.Drawing.Point(0, 188);
            this.dgvClients1.Name = "dgvClients1";
            this.dgvClients1.Size = new System.Drawing.Size(1959, 942);
            this.dgvClients1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Account number",
            "Client name",
            "Phone"});
            this.comboBox2.Location = new System.Drawing.Point(263, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 39);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 38);
            this.textBox1.TabIndex = 4;
            // 
            // ClientsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients1);
            this.Name = "ClientsFilter";
            this.Size = new System.Drawing.Size(1962, 1135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dgvClients dgvClients1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

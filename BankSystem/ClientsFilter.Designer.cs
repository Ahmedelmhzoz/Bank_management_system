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
            this.dgvFilteredClients = new BankSystem.dgvClients();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearchCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dgvFilteredClients
            // 
            this.dgvFilteredClients.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFilteredClients.Location = new System.Drawing.Point(0, 188);
            this.dgvFilteredClients.Name = "dgvFilteredClients";
            this.dgvFilteredClients.Size = new System.Drawing.Size(1959, 942);
            this.dgvFilteredClients.TabIndex = 0;
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(705, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 38);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbSearchCategories
            // 
            this.cbSearchCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchCategories.FormattingEnabled = true;
            this.cbSearchCategories.Items.AddRange(new object[] {
            "None",
            "Account number",
            "Client name",
            "Phone"});
            this.cbSearchCategories.Location = new System.Drawing.Point(279, 91);
            this.cbSearchCategories.Name = "cbSearchCategories";
            this.cbSearchCategories.Size = new System.Drawing.Size(368, 46);
            this.cbSearchCategories.TabIndex = 3;
            this.cbSearchCategories.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategories_SelectedIndexChanged);
            // 
            // ClientsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFilteredClients);
            this.Name = "ClientsFilter";
            this.Size = new System.Drawing.Size(1962, 1135);
            this.Load += new System.EventHandler(this.ClientsFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dgvClients dgvFilteredClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearchCategories;
    }
}

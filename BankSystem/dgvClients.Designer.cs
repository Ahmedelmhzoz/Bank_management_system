namespace BankSystem {
    partial class dgvClients {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            this.accountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PinCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsList.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumber,
            this.PinCode,
            this.clientName,
            this.PhoneNum,
            this.Balance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientsList.Location = new System.Drawing.Point(-3, 45);
            this.dgvClientsList.Name = "dgvClientsList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientsList.RowHeadersWidth = 102;
            this.dgvClientsList.RowTemplate.Height = 40;
            this.dgvClientsList.Size = new System.Drawing.Size(1959, 991);
            this.dgvClientsList.TabIndex = 0;
            // 
            // accountNumber
            // 
            this.accountNumber.DataPropertyName = "accountNumber";
            this.accountNumber.HeaderText = "Account number";
            this.accountNumber.MinimumWidth = 12;
            this.accountNumber.Name = "accountNumber";
            // 
            // PinCode
            // 
            this.PinCode.DataPropertyName = "pinCode";
            this.PinCode.HeaderText = "Pin code";
            this.PinCode.MinimumWidth = 12;
            this.PinCode.Name = "PinCode";
            // 
            // clientName
            // 
            this.clientName.DataPropertyName = "clientName";
            this.clientName.HeaderText = "Client Name";
            this.clientName.MinimumWidth = 12;
            this.clientName.Name = "clientName";
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "phone";
            this.PhoneNum.HeaderText = "Phone";
            this.PhoneNum.MinimumWidth = 12;
            this.PhoneNum.Name = "PhoneNum";
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 12;
            this.Balance.Name = "Balance";
            // 
            // dgvClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dgvClientsList);
            this.Name = "dgvClients";
            this.Size = new System.Drawing.Size(1959, 1027);
            this.Load += new System.EventHandler(this.dgvClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PinCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}

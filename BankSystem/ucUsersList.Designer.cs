namespace BankSystem {
    partial class ucUsersList {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.usernameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.contextMenuStri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(276, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(357, 38);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameC,
            this.clientName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.Location = new System.Drawing.Point(-14, 121);
            this.dgvUsersList.Name = "dgvUsersList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.RowHeadersWidth = 102;
            this.dgvUsersList.RowTemplate.Height = 40;
            this.dgvUsersList.Size = new System.Drawing.Size(1495, 991);
            this.dgvUsersList.TabIndex = 9;
            // 
            // usernameC
            // 
            this.usernameC.ContextMenuStrip = this.contextMenuStri;
            this.usernameC.DataPropertyName = "username";
            this.usernameC.HeaderText = "Username";
            this.usernameC.MinimumWidth = 12;
            this.usernameC.Name = "usernameC";
            // 
            // contextMenuStri
            // 
            this.contextMenuStri.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtailsToolStripMenuItem});
            this.contextMenuStri.Name = "contextMenuStrip1";
            this.contextMenuStri.Size = new System.Drawing.Size(201, 52);
            // 
            // dtailsToolStripMenuItem
            // 
            this.dtailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtailsToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.dtailsToolStripMenuItem.Image = global::BankSystem.Properties.Resources.search;
            this.dtailsToolStripMenuItem.Name = "dtailsToolStripMenuItem";
            this.dtailsToolStripMenuItem.Size = new System.Drawing.Size(200, 48);
            this.dtailsToolStripMenuItem.Text = "Details";
            this.dtailsToolStripMenuItem.Click += new System.EventHandler(this.dtailsToolStripMenuItem_Click);
            // 
            // clientName
            // 
            this.clientName.ContextMenuStrip = this.contextMenuStri;
            this.clientName.DataPropertyName = "permission";
            this.clientName.HeaderText = "Permission number";
            this.clientName.MinimumWidth = 12;
            this.clientName.Name = "clientName";
            // 
            // ucUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgvUsersList);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "ucUsersList";
            this.Size = new System.Drawing.Size(1439, 1115);
            this.Load += new System.EventHandler(this.ucUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.contextMenuStri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStri;
        private System.Windows.Forms.ToolStripMenuItem dtailsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
    }
}

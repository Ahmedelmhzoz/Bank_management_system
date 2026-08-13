namespace BankSystem {
    partial class Presentation {
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2041, 70);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.FindCToolStripMenuItem});
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientsToolStripMenuItem.Image = global::BankSystem.Properties.Resources.clients;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(238, 66);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // showClientsToolStripMenuItem
            // 
            this.showClientsToolStripMenuItem.Enabled = false;
            this.showClientsToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.showClientsToolStripMenuItem.Name = "showClientsToolStripMenuItem";
            this.showClientsToolStripMenuItem.Size = new System.Drawing.Size(476, 70);
            this.showClientsToolStripMenuItem.Tag = "enShowClient";
            this.showClientsToolStripMenuItem.Text = "Show clients";
            this.showClientsToolStripMenuItem.Click += new System.EventHandler(this.showClientsToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Enabled = false;
            this.addClientToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(476, 70);
            this.addClientToolStripMenuItem.Tag = "enAddClient";
            this.addClientToolStripMenuItem.Text = "Add client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // FindCToolStripMenuItem
            // 
            this.FindCToolStripMenuItem.Enabled = false;
            this.FindCToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.FindCToolStripMenuItem.Name = "FindCToolStripMenuItem";
            this.FindCToolStripMenuItem.Size = new System.Drawing.Size(476, 70);
            this.FindCToolStripMenuItem.Tag = "enFindClient";
            this.FindCToolStripMenuItem.Text = "Find Client";
            this.FindCToolStripMenuItem.Click += new System.EventHandler(this.FindCToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.totalBalancesToolStripMenuItem});
            this.transactionsToolStripMenuItem.Enabled = false;
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transactionsToolStripMenuItem.Image = global::BankSystem.Properties.Resources.transaction1;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(365, 66);
            this.transactionsToolStripMenuItem.Tag = "enTransactions";
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Enabled = false;
            this.depositToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(514, 70);
            this.depositToolStripMenuItem.Tag = "enTransactions";
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Enabled = false;
            this.withdrawToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(514, 70);
            this.withdrawToolStripMenuItem.Tag = "enTransactions";
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // totalBalancesToolStripMenuItem
            // 
            this.totalBalancesToolStripMenuItem.Enabled = false;
            this.totalBalancesToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.totalBalancesToolStripMenuItem.Name = "totalBalancesToolStripMenuItem";
            this.totalBalancesToolStripMenuItem.Size = new System.Drawing.Size(514, 70);
            this.totalBalancesToolStripMenuItem.Tag = "enTransactions";
            this.totalBalancesToolStripMenuItem.Text = "Total Balances";
            this.totalBalancesToolStripMenuItem.Click += new System.EventHandler(this.totalBalancesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addUserToolStripMenuItem1,
            this.findUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageUsersToolStripMenuItem.Image = global::BankSystem.Properties.Resources.manage;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(395, 66);
            this.manageUsersToolStripMenuItem.Text = "Manage users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.addUserToolStripMenuItem.Enabled = false;
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(468, 70);
            this.addUserToolStripMenuItem.Tag = "enShowUsers";
            this.addUserToolStripMenuItem.Text = "Show users";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem1
            // 
            this.addUserToolStripMenuItem1.Enabled = false;
            this.addUserToolStripMenuItem1.ForeColor = System.Drawing.Color.Teal;
            this.addUserToolStripMenuItem1.Name = "addUserToolStripMenuItem1";
            this.addUserToolStripMenuItem1.Size = new System.Drawing.Size(468, 70);
            this.addUserToolStripMenuItem1.Tag = "enAddUser";
            this.addUserToolStripMenuItem1.Text = "Add user";
            // 
            // findUserToolStripMenuItem
            // 
            this.findUserToolStripMenuItem.Enabled = false;
            this.findUserToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            this.findUserToolStripMenuItem.Size = new System.Drawing.Size(468, 70);
            this.findUserToolStripMenuItem.Tag = "enFindUser";
            this.findUserToolStripMenuItem.Text = "Find user";
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Enabled = false;
            this.updateUserToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(468, 70);
            this.updateUserToolStripMenuItem.Tag = "enUpdateUser";
            this.updateUserToolStripMenuItem.Text = "Update user";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Enabled = false;
            this.deleteUserToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(468, 70);
            this.deleteUserToolStripMenuItem.Tag = "enDeleteUser";
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profileToolStripMenuItem.Image = global::BankSystem.Properties.Resources.user;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(236, 66);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 30.9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(636, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Management system";
            // 
            // btnShowClients
            // 
            this.btnShowClients.BackColor = System.Drawing.Color.Teal;
            this.btnShowClients.Enabled = false;
            this.btnShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowClients.ForeColor = System.Drawing.Color.Cyan;
            this.btnShowClients.Location = new System.Drawing.Point(1407, 458);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(354, 129);
            this.btnShowClients.TabIndex = 2;
            this.btnShowClients.Tag = "enShowClient";
            this.btnShowClients.Text = "Show clients list";
            this.btnShowClients.UseVisualStyleBackColor = false;
            this.btnShowClients.Click += new System.EventHandler(this.btnShowClients_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(777, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 69);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fast processes:";
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.Teal;
            this.btnFindClient.Enabled = false;
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.Cyan;
            this.btnFindClient.Location = new System.Drawing.Point(246, 739);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(354, 129);
            this.btnFindClient.TabIndex = 4;
            this.btnFindClient.Tag = "enFindClient";
            this.btnFindClient.Text = "Find client";
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.AlterClientClick);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Teal;
            this.btnAddClient.Enabled = false;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.Cyan;
            this.btnAddClient.Location = new System.Drawing.Point(246, 458);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(354, 129);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Tag = "enAddClient";
            this.btnAddClient.Text = "Add client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.Teal;
            this.btnTransactions.Enabled = false;
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Cyan;
            this.btnTransactions.Location = new System.Drawing.Point(1407, 739);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(354, 129);
            this.btnTransactions.TabIndex = 6;
            this.btnTransactions.Tag = "enTransactions";
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateClient.Enabled = false;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Cyan;
            this.btnUpdateClient.Location = new System.Drawing.Point(246, 1023);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(354, 129);
            this.btnUpdateClient.TabIndex = 7;
            this.btnUpdateClient.Tag = "enUpdateClient";
            this.btnUpdateClient.Text = "Update client";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.AlterClientClick);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteClient.Enabled = false;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Cyan;
            this.btnDeleteClient.Location = new System.Drawing.Point(1407, 1036);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(354, 129);
            this.btnDeleteClient.TabIndex = 8;
            this.btnDeleteClient.Tag = "enDeleteClient";
            this.btnDeleteClient.Text = "Delete client";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.AlterClientClick);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Teal;
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Cyan;
            this.btnManageUsers.Location = new System.Drawing.Point(831, 739);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(354, 129);
            this.btnManageUsers.TabIndex = 10;
            this.btnManageUsers.Tag = "enShowUsers";
            this.btnManageUsers.Text = "Manage users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(44, 1280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 52);
            this.label3.TabIndex = 11;
            this.label3.Text = "user: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblUsername.Location = new System.Drawing.Point(159, 1286);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 42);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "user: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.Image = global::BankSystem.Properties.Resources.pic;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1671, 1286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(358, 73);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Logout";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2041, 1388);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Presentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank system menu";
            this.Load += new System.EventHandler(this.Presentation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ToolStripMenuItem showClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBalancesToolStripMenuItem;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem FindCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}


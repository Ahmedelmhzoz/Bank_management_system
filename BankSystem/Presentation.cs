using System;
using System.Windows.Forms;
using BankBusiness;
namespace BankSystem {
    public enum entransactionMode { deposit = 0, withdraw = 1, none = 2 }
    public enum enProcessesPermissions { enAddClient = 1, enShowClient = 2, enFindClient = 4, enUpdateClient = 8,
    enDeleteClient = 16, enTransactions = 32, enShowUsers = 64, enAddUser = 128, enFindUser = 256, enUpdateUser = 512, 
        enDeleteUser = 1024}
  
    public partial class Presentation : Form {
        private Users currentUser = new Users();
        DealWithClients dealWithClients = new DealWithClients();

        FrmDealWithUsers frmDealWithUsers = null;
        void setButtonsVisiblityByPermission() {
            if (currentUser == null)
                return;
            GeneralMethods.setButtonsVisiblityByPermission(this.Controls, currentUser.permissionNum);
            if ((currentUser.permissionNum & 8) == 8) {
                dealWithClients.EnableButtons(8); // it will enable the update button in the update clinets form
                                                  // if the user has the permission
            }
            if ((currentUser.permissionNum & 16) == 16) {
                dealWithClients.EnableButtons(16); // it will enable the delete button in the delete clinets form
            }
            frmDealWithUsers = new FrmDealWithUsers(currentUser);
            if ((currentUser.permissionNum & 512) == 512) {
                frmDealWithUsers.EnableButtons(512); // it will enable the update button in the update Users form
                                                  // if the user has the permission
            }
            if ((currentUser.permissionNum & 1024) == 1024) {
                frmDealWithUsers.EnableButtons(1024); // it will enable the delete button in the delete Users form
            }
        }

        void setVisiblityToItemChildren(ToolStripMenuItem MenuItem) {
            // at first, we check the main item permission in the menuStrip before we check its children
            if (MenuItem.Tag != null) {
                int processPermission = GeneralMethods.convertTagEnumToInt(MenuItem.Tag.ToString());
                if ((currentUser.permissionNum & processPermission) == processPermission)
                    MenuItem.Enabled = true;
                return;
            }
            foreach (ToolStripItem children in MenuItem.DropDownItems) {
                if (children is ToolStripMenuItem child) {
                    int processPermission = GeneralMethods.convertTagEnumToInt(child.Tag.ToString());
                    if((currentUser.permissionNum & processPermission) == processPermission) {
                        child.Enabled = true;
                    }
                }
            }
        }

        void setMenuStripVisiblityByPermission() {
            if (currentUser == null)
                return;
           foreach (ToolStripItem item in menuStrip1.Items) {
                 if (item is ToolStripMenuItem Item) {
                    setVisiblityToItemChildren(Item);
                 }
           }
        }

        private void Presentation_Load(object sender, EventArgs e) {
            lblUsername.Text = currentUser.username;
            setButtonsVisiblityByPermission();
            setMenuStripVisiblityByPermission();
        }
        public Presentation() {
            InitializeComponent();
        }
        public Presentation(Users usr) {
            InitializeComponent();
            currentUser = usr;
        }
        private void btnShowClients_Click(object sender, EventArgs e) {
            ClientsList cf = new ClientsList();
            cf.ShowDialog();
        }

        private void AlterClientClick(object sender, EventArgs e) {
            Button btn = (Button)sender;
            dealWithClients.setProcess(btn.Text);
            dealWithClients.ShowDialog();
        }

        private void showClientsToolStripMenuItem_Click(object sender, EventArgs e) {
            ClientsList cf = new ClientsList();
            cf.ShowDialog();
        }

        private void FindCToolStripMenuItem_Click(object sender, EventArgs e) {
            DealWithClients dealWithClients = new DealWithClients();
            dealWithClients.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            FrmClientProcess frm = new FrmClientProcess("Add new client");

            frm.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmClientProcess frm = new FrmClientProcess();

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            FrmTransactions frm = new FrmTransactions(entransactionMode.none);
            frm.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTransactions frm = new FrmTransactions(entransactionMode.deposit);
            frm.ShowDialog();

        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTransactions frm = new FrmTransactions(entransactionMode.withdraw);
            frm.ShowDialog();

        }

        private void totalBalancesToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTotalBalances frm = new FrmTotalBalances();
            frm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e) {
            FrmManageUsersMenu frm = new FrmManageUsersMenu(currentUser, frmDealWithUsers);
            frm.ShowDialog();
        }


        private void profileToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUserProfile frm = new FrmUserProfile(currentUser);
            frm.ShowDialog();
        }



        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e) {
            frmDealWithUsers.setProcess("Update user:");
            frmDealWithUsers.ShowDialog();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmUserProcess Frm = new FrmUserProcess();
            Frm.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e) {
            frmDealWithUsers.setProcess("Find user:");
            frmDealWithUsers.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e) {
            frmDealWithUsers.setProcess("Delete user:");
            frmDealWithUsers.ShowDialog();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUsersList frm = new FrmUsersList();
            frm.ShowDialog();
        }
    }
}

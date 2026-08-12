using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusiness;
namespace BankSystem {
    public enum entransactionMode { deposit = 0, withdraw = 1, none = 2 }
    public enum enProcessesPermissions { enAddClient = 1, enShowClient = 2, enFindClient = 4, enUpdateClient = 8,
    enDeleteClient = 16, enTransactions = 32, enShowUsers = 64, enAddUser = 128}

    public partial class Presentation : Form {
        private Users currentUser = new Users();

        FrmManageUsersMenu userMenu = new FrmManageUsersMenu();
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
            DealWithClients dealWithClients = new DealWithClients();
            dealWithClients.setProcess(btn.Text);
            dealWithClients.ShowDialog();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e) {
            DealWithClients dealWithClients = new DealWithClients();
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
            this.Close();
            Application.Exit();
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

        }

        private void Presentation_Load(object sender, EventArgs e) {
            lblUsername.Text = currentUser.username;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUserProfile Frm = new FrmUserProfile(currentUser);
            Frm.ShowDialog();
        }
    }
}

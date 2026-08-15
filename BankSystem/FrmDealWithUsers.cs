using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem {
    public partial class FrmDealWithUsers : Form {

        Users currentUser = new Users();
        public FrmDealWithUsers() {
            InitializeComponent();
        }
        public FrmDealWithUsers(Users user) {
            InitializeComponent();
            currentUser = user;
        }
        public void setProcess(string ProcessName) {
            lblProcess.Text = ProcessName;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e) {
            string currentUsername = ucUsersList1.returnCurrentUsername();
            Users user = new Users();
            user.findUserAndGetData(currentUsername);
            FrmUserProcess frm = new FrmUserProcess(user, currentUser);
            frm.ShowDialog();
            ucUsersList1.refreshData();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e) {
            string currentUsername = ucUsersList1.returnCurrentUsername();
            if (currentUsername == currentUser.username) {
                MessageBox.Show("U cant delete your account", "Process went wrong", MessageBoxButtons.OK
                           , MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure that u want to delete this User" + Environment.NewLine + $"[username: {currentUsername}]",
                "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (Users.deleteUser(currentUsername)) {
                    MessageBox.Show("User was deleted successfully (-:", "Process went Successfully", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    ucUsersList1.refreshData(); ;
                }
                else {
                    MessageBox.Show("User wasn't deleted )-:", "Process went wrong", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                }
            }
        }

        public void EnableButtons(int buttonPermission) {
            if (buttonPermission == 512) {
                btnUpdateUser.Enabled = true;
            }
            else if (buttonPermission == 1024) {
                btnDeleteUser.Enabled = true;
            }
        }
    }
}

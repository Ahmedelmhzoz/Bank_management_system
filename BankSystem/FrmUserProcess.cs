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
using System.Xml.Linq;

namespace BankSystem {
    public partial class FrmUserProcess : Form {
        Users currentUser = null;
        Users userToBeAddOrUpdate = new Users();
        public FrmUserProcess() {
            InitializeComponent();
        }
        public FrmUserProcess(Users user, Users crntUser) {
            InitializeComponent();
            userToBeAddOrUpdate = user;
            currentUser = crntUser;
        }
        void makeAuthorizedBoxesChecked() {
            foreach (Control control in this.Controls) {
                if (control is CheckBox box) {
                    int boxPermission = GeneralMethods.convertTagEnumToInt(box.Tag.ToString());
                    if ((userToBeAddOrUpdate.permissionNum & boxPermission) == boxPermission)
                        box.Checked = true;
                }
            }
        }
        int getTotalUserPermission() {
            int totalPermission = 0;
            foreach (Control control in this.Controls) {
                if (control is CheckBox box) {
                    if (box.Checked) 
                        totalPermission += GeneralMethods.convertTagEnumToInt(box.Tag.ToString());
                }
            }
            return totalPermission;
        }
        void disableCheckBoxes() {
            foreach (Control control in this.Controls) {
                if (control is CheckBox box) {
                    box.Enabled = false;
                }
            }
        }
        private void FrmUserProcess_Load(object sender, EventArgs e) {
            if (userToBeAddOrUpdate.currentMode == enUserMode.updateUser) {
                lblProcess.Text = "Update user";
                txtUsername.Text = userToBeAddOrUpdate.username;
                txtUsername.Enabled = false;
                txtPassword.Text = userToBeAddOrUpdate.password;
                makeAuthorizedBoxesChecked();
                if (currentUser.username == userToBeAddOrUpdate.username) {
                    // if u wanted to update ur user u cant update ur permissions directly so we will disable the boxes
                    disableCheckBoxes();
                }
            }
            else {
                lblProcess.Text = "Add new user";
                txtUsername.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text) ) {
                MessageBox.Show("Please fill username, password text boxes before saving",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (userToBeAddOrUpdate.currentMode == enUserMode.updateUser &&
                    userToBeAddOrUpdate.password != txtPassword.Text && Users.isPasswordTaken(txtPassword.Text)) {
                    if (Users.isPasswordTaken(userToBeAddOrUpdate.password)) { // if he updated the password to a used one 
                        MessageBox.Show("The password is taken",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (userToBeAddOrUpdate.currentMode == enUserMode.addUser && // if he add a user has taken username or password
                    (Users.isUsernameTaken(txtUsername.Text) || Users.isPasswordTaken(txtPassword.Text))) {
                    MessageBox.Show("The username or Password is taken",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                userToBeAddOrUpdate.permissionNum = getTotalUserPermission();
                userToBeAddOrUpdate.username = txtUsername.Text;
                userToBeAddOrUpdate.password = txtPassword.Text;
                if (userToBeAddOrUpdate.Save()) {
                    MessageBox.Show("User Saved successfully (-:",
                   "Successful process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("User wasn't saved )-:",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

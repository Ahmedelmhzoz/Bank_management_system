using BankBusiness;
using System;
using System.Windows.Forms;

namespace BankSystem {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }
        public enum enEnterMode { enLogin = 0, enRegister = 1}
        enEnterMode currentMode = enEnterMode.enLogin;
        void ErrorMessage(string message) {
            MessageBox.Show(message, "uncorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblErrorMessage.Visible = true;
        }
        void loginProcess() {
            if (txtPassword.Text == "" || txtUsername.Text == "") {
                ErrorMessage("Please fill all text boxes");
                return;
            }
            Users user = new Users();
            if (user.findUserAndGetData(txtUsername.Text, txtPassword.Text)) {
                MessageBox.Show($"Welcome, {user.username} (-:", "Process done Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Presentation Frm = new Presentation(user);
                this.Hide();
                Frm.ShowDialog();
                this.Close();
            }
            else {
                string message = "Wrong Password or Username" + Environment.NewLine + "Please enter user data correctly";
                ErrorMessage(message);
            }
        }
        void registerProcess() {
            if (txtConfirmPass.Text == "" || txtPassword.Text == "" || txtUsername.Text == "") {
                ErrorMessage("Please fill all text boxes");
                return;
            }
            if (Users.isUsernameTaken(txtUsername.Text)) {
                string message = "The username is taken" + Environment.NewLine + "Please enter user data correctly";
                ErrorMessage(message);
                return;
            }
            else if (Users.isPasswordTaken(txtPassword.Text)) {
                string message = "The password is taken" + Environment.NewLine + "Please enter user data correctly";
                ErrorMessage(message);
                return;
            }
            // for sure the username and the password at this moment are UNIQUE
            Users user = new Users();
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            user.permissionNum = 255; // all clients processes and add user 
            if (user.Save()) {
                MessageBox.Show($"Welcome, {user.username} (-:", "Process done Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Presentation Frm = new Presentation(user);
                this.Hide();
                Frm.ShowDialog();
                this.Close();
            }
            else {
                ErrorMessage("Error happened while saving");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            
            switch (currentMode) {
                case enEnterMode.enLogin:
                    loginProcess();
                    break;
                case enEnterMode.enRegister:
                    registerProcess();
                    break;
                default: return;
            }
        }
        private void linklblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            currentMode = enEnterMode.enRegister;
            lblErrorMessage.Visible = false;
            txtConfirmPass.Visible = true;
            lblPassConfirm.Visible = true;
            btnLogin.Text = "Register";
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}

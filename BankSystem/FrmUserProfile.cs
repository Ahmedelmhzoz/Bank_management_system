using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using BankBusiness;

namespace BankSystem {
    public partial class FrmUserProfile : Form {

        Users user = null;
        public FrmUserProfile(Users usr) {
            InitializeComponent();
            user = usr;
            profileCard1.loadData(user);
        }
        void ErrorMessage(string message) {
            MessageBox.Show(message, "uncorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmUserProfile_Load(object sender, EventArgs e) {
            btnChange.Visible= false;
        }

        private void btnChange_Click(object sender, EventArgs e) {
            if (txtNew.Text == "" || txtOld.Text == "") {
                ErrorMessage("Please fill all text boxes");
                return;
            }
            else if (txtOld.Text != user.password) {
                ErrorMessage("The old password is wrong");
                return;
            }
            else if (txtOld.Text == txtNew.Text) {
                ErrorMessage("The new password is the same as the old");
                return;
            }
            else {
                user.password = txtNew.Text;
                if (user.Save()) {
                    MessageBox.Show("The password is saved successfully",
                        "uncorrect input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNew.Visible = false;
                    txtOld.Visible = false;
                    lblNEw.Visible = false;
                    lblOld.Visible = false;
                    btnChange.Visible = false;
                    linklblChangePass.Visible = true;
                }
                else {
                    ErrorMessage("Error happend while saving");
                }
            }
        }
        private void linklblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            btnChange.Visible = true;
            txtNew.Visible = true;
            txtOld.Visible = true;
            linklblChangePass.Visible = false;
            lblNEw.Visible = true;
            lblOld.Visible = true;
        }
    }
}

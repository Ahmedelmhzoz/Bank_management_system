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
    public partial class FrmAddClient : Form {
        public FrmAddClient() {
            InitializeComponent();
        }

        private void validatingTextBoxes(object sender, CancelEventArgs e) {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Tag.ToString() == "PinCode") 
                return;
            if (string.IsNullOrEmpty(txtBox.Text)) {
                e.Cancel = true;
                txtBox.Focus();
                errorProvider1.SetError(txtBox, $"{txtBox.Tag} Should have a value");
            } else {
                e.Cancel = false;
                errorProvider1.SetError(txtBox, "");
            }
        }

        private void FrmAddClient_Load(object sender, EventArgs e) {
            txtAccNumber.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtAccNumber.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPhoneNum.Text)) {
                MessageBox.Show("Please fill Account Number, Name and phone text boxes before saving",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                Clients client = new Clients();
                client.accountNumber = txtAccNumber.Text;
                client.clientName = txtName.Text;
                client.phone = txtPhoneNum.Text;
                client.pinCode = txtPinCode.Text;
                if (Clients.isAccountNumberTaken(client.accountNumber)) {
                    MessageBox.Show("Account number is taken, please enter a new account number",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (client.Save()) {
                    MessageBox.Show("Client Added successfully (-:",
                   "Successful process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("Client wasn't saved )-:",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e) {

        }
    }
}

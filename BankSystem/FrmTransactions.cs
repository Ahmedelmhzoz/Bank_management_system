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

    public partial class FrmTransactions : Form {

        entransactionMode mode = entransactionMode.none;
        public FrmTransactions(entransactionMode Mode) {
            InitializeComponent();
            mode = Mode;
        }
        public void processForm(entransactionMode mode) {
            if (mode == entransactionMode.deposit) {
                lblMessage1.Visible = true;
                txtAccountNumber.Visible = true;
                btnEnter.Visible = true;
                lblTransactionProcess.Text = "deposit:";
                lblTransactionProcess.Visible = true;
                lblMessage2.Visible = false;
                lblWrongAcc.Visible = false;
                txtAccountNumber.Text = "";
            }
            else {
                lblMessage1.Visible = true;
                txtAccountNumber.Visible = true;
                btnEnter.Visible = true;
                lblTransactionProcess.Text = "Withdraw:";
                lblTransactionProcess.Visible = true;
                lblMessage2.Visible = false;
                lblWrongAcc.Visible = false;
                txtAccountNumber.Text = "";
            }
        }

        private void FrmTransactions_Load(object sender, EventArgs e) {
            switch (mode) {
                case entransactionMode.deposit:
                    processForm(entransactionMode.deposit);
                    break;
                case entransactionMode.withdraw:
                    processForm(entransactionMode.withdraw);
                    break;
                default:
                    lblMessage1.Visible = false;
                    txtAccountNumber.Visible = false;
                    btnEnter.Visible = false;
                    lblTransactionProcess.Visible = false;
                    lblMessage2.Visible = false;
                    lblWrongAcc.Visible = false;
                    break;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            if (Clients.isAccountNumberTaken(txtAccountNumber.Text)) {
                Clients client = new Clients();
                client.fillClientWithDesiredRecord(txtAccountNumber.Text);
                entransactionMode mode = new entransactionMode();
                if (lblTransactionProcess.Text == "deposit:")
                    mode = entransactionMode.deposit;
                else
                    mode = entransactionMode.withdraw;
                if (client.balance == 0.0m && mode == entransactionMode.withdraw) {
                    if (DialogResult.OK == MessageBox.Show("There are no funds in your bank account to withdraw يا فقير", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)) {
                        return;
                    }
                }
                FrmTransactionProcess frmTrans = new FrmTransactionProcess(mode, client);
                frmTrans.ShowDialog();
            } else {
                lblMessage2.Visible = true;
                lblWrongAcc.Text = txtAccountNumber.Text;
                lblWrongAcc.Visible = true;
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e) {
            processForm(entransactionMode.deposit);
        }

        private void btnWithdraw_Click(object sender, EventArgs e) {
            processForm(entransactionMode.withdraw);
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnTotalBalances_Click(object sender, EventArgs e) {
            FrmTotalBalances frm = new FrmTotalBalances();
            frm.ShowDialog();
        }
    }
}

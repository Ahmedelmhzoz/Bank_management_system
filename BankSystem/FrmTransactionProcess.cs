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
    public partial class FrmTransactionProcess : Form {
        entransactionMode currentMode = entransactionMode.deposit;
        public FrmTransactionProcess(entransactionMode transMode, Clients client) {
            InitializeComponent();
      
            personCard1.setupClient(client);
            currentMode = transMode;
            if (transMode == entransactionMode.deposit) {
                lblTransactionProcess.Text = "Deposit fund: ";
                numericalMoney.Maximum = 1000000;
                btnDoProcess.Text = "Deposit";
            } else {
                lblTransactionProcess.Text = "Withdraw fund: ";
                btnDoProcess.Text = "Withdraw";
                numericalMoney.Maximum = Convert.ToInt32(personCard1.Balance);
            }
        }

        private void btnDoProcess_Click(object sender, EventArgs e) {
            if (currentMode == entransactionMode.deposit) {
                personCard1.renewBalance(numericalMoney.Value);
            } else {
                personCard1.renewBalance(-numericalMoney.Value);
            }
        }

        private void numericalMoney_Validating(object sender, CancelEventArgs e) {
            if (numericalMoney.Value > numericalMoney.Maximum) {
                e.Cancel = true;
                errorProvider1.SetError(numericalMoney, "Amount exceeds Maximum limit!");
                numericalMoney.Focus();
            } else {
                errorProvider1.SetError(numericalMoney, "");
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

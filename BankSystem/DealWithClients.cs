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
    public partial class DealWithClients : Form {
        public DealWithClients() {
            InitializeComponent();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e) {
            string accountNumber = dgvClients.returnCurrentRowAccNumber();

            if (MessageBox.Show($"Are you sure that u want to delete this Client [Account number: {accountNumber}]",
                "Delete client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (Clients.deleteAClient(accountNumber)) {
                    MessageBox.Show("Client is deleted successfully (-:", "Process went Successfully", MessageBoxButtons.OK
                        ,MessageBoxIcon.Information);
                    dgvClients.updateResult();
                } else {
                    MessageBox.Show("Client wasn't deleted )-:", "Process went wrong", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                }
            }
        }
    }
}

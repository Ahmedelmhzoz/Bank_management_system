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
    public partial class ClientsList : Form {
        public ClientsList() {
            InitializeComponent();
        }

        private void ClientsList_Load(object sender, EventArgs e) {
            lblClientsNum.Text = dgvClients1.clientsNumInString;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e) {
            string accNum = dgvClients1.returnCurrentAccNumber();
            Clients client = new Clients();
            client.fillClientWithDesiredRecord(accNum);
            FrmClientDetails details = new FrmClientDetails(client);
            details.ShowDialog();
        }
    }
}

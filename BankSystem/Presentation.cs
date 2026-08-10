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
    public partial class Presentation : Form {
        public Presentation() {
            InitializeComponent();
        }


        private void btnShowClients_Click(object sender, EventArgs e) {
            ClientsList cf = new ClientsList();
            cf.ShowDialog();
        }

        private void AlterClientClick(object sender, EventArgs e) {
            DealWithClients dealWithClients = new DealWithClients();
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
    }
}

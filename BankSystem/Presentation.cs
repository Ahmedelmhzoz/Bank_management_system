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
            Button btn = (Button)sender;
            DealWithClients dealWithClients = new DealWithClients();
            dealWithClients.setProcess(btn.Text);
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

        private void FindCToolStripMenuItem_Click(object sender, EventArgs e) {
            DealWithClients dealWithClients = new DealWithClients();
            dealWithClients.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            FrmClientProcess frm = new FrmClientProcess("Add new client");

            frm.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmClientProcess frm = new FrmClientProcess();

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }
    }
}

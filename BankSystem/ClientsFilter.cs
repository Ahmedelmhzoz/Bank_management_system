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
    public partial class ClientsFilter : UserControl {
        public ClientsFilter() {
            InitializeComponent();
        }

        private void ClientsFilter_Load(object sender, EventArgs e) {
            cbSearchCategories.SelectedIndex = 0;
            txtSearch.Visible = false;
        }
        public void updateResult() {
            DataTable dt = Clients.getCurrentSearchResult(cbSearchCategories.Text, txtSearch.Text);
            dgvFilteredClients.refreshData(dt);
        }

        private void cbSearchCategories_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbSearchCategories.Text == "None") {
                txtSearch.Visible = false;
                dgvFilteredClients.refreshData(Clients.getAllClients());
                return;
            }
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            updateResult();
        }

        public string returnCurrentRowAccNumber() {
            return dgvFilteredClients.returnCurrentAccNumber();
        }

    }
}

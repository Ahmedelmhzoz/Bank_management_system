using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem {
    public partial class dgvClients : UserControl {
        public dgvClients() {
            InitializeComponent();
        }
        private void dgvClients_Load(object sender, EventArgs e) {
            dgvClientsList.AutoGenerateColumns = false;
            dgvClientsList.DataSource = Clients.getAllClients();
            dgvClientsList.RowTemplate.Height = 70;
        }

        public void refreshData(DataTable newData) {
            dgvClientsList.DataSource = newData;
        }

        public string returnCurrentAccNumber() {
            return dgvClientsList.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

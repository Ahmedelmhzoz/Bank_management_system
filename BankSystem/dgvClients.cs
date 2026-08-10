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

        public string clientsNumInString { get { return dgvClientsList.Rows.Count.ToString(); } }

        public void refreshData(DataTable newData) {
            dgvClientsList.DataSource = newData;
        }

        public string returnCurrentAccNumber() {
            return dgvClientsList.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvClientsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 4) {
                // أضفنا (?) بعد e.Value لمنع الـ NullReferenceException
                if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString())) {
                    e.Value = "Didn't make any transaction yet";
                    e.FormattingApplied = true;
                }

            }
        }
    }
}

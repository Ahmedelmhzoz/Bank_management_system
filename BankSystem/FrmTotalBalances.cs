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
    public partial class FrmTotalBalances : Form {
        public FrmTotalBalances() {
            InitializeComponent();
        }

        private void FrmTotalBalances_Load(object sender, EventArgs e) {
            lblClientNum.Text = lblClientsNum.Text = dgvClients1.clientsNumInString;
            lblTotalBalances.Text = dgvClients1.totalBalances.ToString();
        }
    }
}

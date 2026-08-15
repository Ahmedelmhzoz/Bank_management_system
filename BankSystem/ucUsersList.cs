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
    public partial class ucUsersList : UserControl {
        public ucUsersList() {
            InitializeComponent();
        }

        private void ucUsersList_Load(object sender, EventArgs e) {
            dgvUsersList.AutoGenerateColumns = false;
            dgvUsersList.DataSource = Users.getAllUsers();
            dgvUsersList.RowTemplate.Height = 70;
        }
        public void refreshData() {
            dgvUsersList.DataSource = Users.getCurrentSearchResult(txtUsername.Text);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            refreshData();
        }
        public string returnCurrentUsername() {
            return dgvUsersList.CurrentRow.Cells[0].Value.ToString();
        }
        public int getUsersNumber() {
            return dgvUsersList.Rows.Count;
        }

        private void dtailsToolStripMenuItem_Click(object sender, EventArgs e) {
            string username = dgvUsersList.CurrentRow.Cells[0].Value.ToString();
            Users user = new Users();
            user.findUserAndGetData(username);
            FrmUserDetails frm = new FrmUserDetails(user);
            frm.ShowDialog();
        }
    }
}

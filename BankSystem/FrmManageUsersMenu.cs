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
    public partial class FrmManageUsersMenu : Form {

        Users currentUser = null;

        FrmDealWithUsers frmDealWithUsers = null;

        public void setButtonsVisiblityByPermission() {
            if (currentUser == null)
                return;
            GeneralMethods.setButtonsVisiblityByPermission(this.Controls, currentUser.permissionNum);

           
        }
        public FrmManageUsersMenu(Users user, FrmDealWithUsers frmDeal) {
            InitializeComponent();
            currentUser = user;
            frmDealWithUsers = frmDeal;
        }

        private void FrmManageUsersMenu_Load(object sender, EventArgs e) {
            setButtonsVisiblityByPermission();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            FrmUserProcess frm = new FrmUserProcess();
            frm.ShowDialog();
        }

        private void FindUpdateDeleteClick(object sender, EventArgs e) {
            Button btn = (Button)sender;
            frmDealWithUsers.setProcess(btn.Text);
            frmDealWithUsers.ShowDialog();
        }

        private void btnShowUsers_Click(object sender, EventArgs e) {
            FrmUsersList frm = new FrmUsersList();
            frm.ShowDialog();
        }
    }
}

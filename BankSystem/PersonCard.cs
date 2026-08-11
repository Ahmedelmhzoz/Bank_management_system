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
    public partial class PersonCard : UserControl {
        public PersonCard() {
            InitializeComponent();
            lblNewBalance.Visible = false;
            lblnewBalanceTitle.Visible = false;
        }
        Clients client = new Clients();
        public decimal Balance { 
            get {
                if (lblBalance.Text != "Didn't make any transaction yet") 
                    return Convert.ToDecimal(lblBalance.Text);                 
                else
                    return 0;
            } 
            set { lblBalance.Text = value.ToString(); } 
        }
        public void setupClient(Clients clint) {
            client = clint;
            lblAccNumber.Text = client.accountNumber;
            lblPinCode.Text = client.pinCode;
            lblName.Text = client.clientName;
            lblPhone.Text = client.phone;
            string Balance = "";
            if (client.balance == 0.0m)
                Balance = "Didn't make any transaction yet";
            else
                Balance = client.balance.ToString();
            lblBalance.Text = Balance;
        }
        public void renewBalance(decimal newBalance) { // newBalance - > numerical value
            if (lblBalance.Text != "Didn't make any transaction yet") {
                lblNewBalance.Visible = true;
                lblnewBalanceTitle.Visible = true;
                lblBalance.BackColor = Color.OrangeRed;
                lblNewBalance.Text = (newBalance + client.balance).ToString();
            } else {
                lblBalance.BackColor = Color.Green;
                lblBalance.Text = (newBalance + client.balance).ToString();
            }
           
            client.balance = newBalance + client.balance;
            if (client.Save()) {
                MessageBox.Show("Client balance is updated successfully (-:", "Successful process", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            } else {
                MessageBox.Show("There is error happened while saving )-:", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
    }
}

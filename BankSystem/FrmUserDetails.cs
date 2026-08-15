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
    public partial class FrmUserDetails : Form {
        public FrmUserDetails(Users user) {
            InitializeComponent();
            profileCard1.loadData(user);
        }
    }
}

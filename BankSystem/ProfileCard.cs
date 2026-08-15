using BankBusiness;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSystem {
    public partial class ProfileCard : UserControl {
        Users user = null;
        public ProfileCard() {
            InitializeComponent();
        }

        public void loadData(Users usr) {
            user = usr;
            if (!string.IsNullOrEmpty(user.imagePath)) {
                pbUserPic.Image = Image.FromFile(user.imagePath);
                pbUserPic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                pbUserPic.Visible = false;
            }
            lblUsername.Text = user.username;
            updateCheckBoxes();
        }
        void updateCheckBoxes() {
            if (user == null) return; 
            foreach (Control ctrl in this.Controls) {
                if (ctrl is CheckBox box) {
                    int processPermission = GeneralMethods.convertTagEnumToInt(box.Tag.ToString());
                    if ((user.permissionNum & processPermission) == processPermission) {
                        box.Checked = true;
                    }
                    else {
                        box.Checked = false;
                    }
                   box.Enabled = false;
                }
            }
        }
        public void putImage(string path) {
            pbUserPic.Image = Image.FromFile(path);
            pbUserPic.SizeMode = PictureBoxSizeMode.Zoom;
            user.imagePath = path;
            if (!user.Save()) {
                MessageBox.Show("Error happend");
            }
            else {
                pbUserPic.Visible = true;
            }
        }
    }
}

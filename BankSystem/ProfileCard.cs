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
                btnUpdateOrSetImage.Text = "Set image";
            }
            lblUsername.Text = user.username;
            updateCheckBoxes();
        }
        int convertTagEnumToInt(string permissionEnumInString) {
            if (Enum.TryParse(permissionEnumInString, out enProcessesPermissions permission)) {
                return (int)permission;
            }
            else {
                return 0;
            }
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
        private void ucUserProfile_Load(object sender, EventArgs e) {
           
        }

        private void btnUpdateOrSetImage_Click(object sender, EventArgs e) {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Choose image";
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "PNG File (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                pbUserPic.Image = Image.FromFile(openFileDialog1.FileName);
                pbUserPic.SizeMode = PictureBoxSizeMode.Zoom;
                user.imagePath = openFileDialog1.FileName.ToString();
                if (!user.Save()) {
                    MessageBox.Show("Error happend");
                } else {
                    pbUserPic.Visible = true;
                }
            }
        }
    }
}

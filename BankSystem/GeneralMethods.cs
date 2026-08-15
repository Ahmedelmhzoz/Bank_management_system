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
    public static class GeneralMethods {
        public static int convertTagEnumToInt(string permissionEnumInString) {
            if (Enum.TryParse(permissionEnumInString, out enProcessesPermissions permission)) {
                return (int)permission;
            }
            else {
                return 0;
            }
        }

        public static void setButtonsVisiblityByPermission(Control.ControlCollection frmControls, int userPermissions) {
            foreach (Control control in frmControls) {
                if (control is Button btn) {
                    if (btn.Tag != null) {
                        int processPermission = GeneralMethods.convertTagEnumToInt(btn.Tag.ToString());
                        if ((userPermissions & processPermission) == processPermission) {
                            btn.Enabled = true;
                        }
                    }
                }
            }
        }

    }
}

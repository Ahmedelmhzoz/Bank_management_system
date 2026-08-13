using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

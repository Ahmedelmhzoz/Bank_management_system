using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static BankData.DataAccess;

namespace BankBusiness
{
    public class Clients {
        public static DataTable getAllClients() {
            return DataAccess.getClients();
        }
        public static DataTable getCurrentSearchResult(string searchCatigory, string currentTxt) {
            enSearchCategory searchMode = enSearchCategory.accountNumber;
            switch (searchCatigory) {
                case "Account number": searchMode = enSearchCategory.accountNumber; break;
                case "Client name": searchMode = enSearchCategory.clientName; break;
                case "Phone": searchMode = enSearchCategory.clientPhone; break;
                default: break;
            }
            return DataAccess.searchResultByCategory(searchMode, currentTxt);
        }
        public static bool deleteAClient(string AccountNumber) {
            return DataAccess.deleteClient(AccountNumber);
        }
    }
}

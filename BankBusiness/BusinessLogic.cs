using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static BankData.DataAccess;

namespace BankBusiness
{
    public class Clients {
        enum enMode { addClient = 0, updateClient = 1 } 
        public string accountNumber {  get; set; }
        public string clientName { get; set; }
        public string pinCode { get; set; }
        public string phone {  get; set; }

        enMode currentMode;
        public Clients() {
            accountNumber = "";
            clientName = "";
            pinCode = "";
            phone = "";
            currentMode = enMode.addClient;
        }
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
        bool addNewClient() {
            return DataAccess.addClient(accountNumber, clientName, phone, pinCode);
        }
        public static bool isAccountNumberTaken(string accountNumber) {
            return DataAccess.isAccountNumExists(accountNumber);
        }
        bool updateAClient() {
            return true;

        }
        public bool Save() {
            switch (currentMode) { 
                case enMode.addClient: 
                      if (addNewClient()) {
                            currentMode = enMode.updateClient;
                            return true;
                      }
                      return false;
                default: return updateAClient();
            }
        }
    }
}

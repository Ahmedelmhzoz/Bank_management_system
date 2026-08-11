using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public static class DataAccess {
        static string connectionSettings = "Server=.;Database=BankDB;User ID = sa;password=123456;";
        public enum enSearchCategory { accountNumber = 0, clientName = 1, clientPhone = 2}
        public static DataTable getClients() {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = "Select * from Clients";
            SqlCommand cmd = new SqlCommand(query, conn);
            try {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    dt.Load(reader);
                }
                reader.Close();

            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return dt;
        }

        public static DataTable searchResultByCategory(enSearchCategory mode, string currentText) {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionSettings);
            string[] searchModes = { "accountNumber", "clientName", "phone" };
            string searchMode = searchModes[(int)mode];
            string query = $"Select * from Clients where {searchMode} Like @CurrentText + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CurrentText", currentText);
             try {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    dt.Load(reader);
                }
                reader.Close();

            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return dt;
        }
        public static bool deleteClient(string AccountNumber) {
            bool isDeleted = false;
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = "delete from Clients where accountNumber = @an";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@an", AccountNumber);
            try {
                conn.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0) {
                    isDeleted = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isDeleted;
        }
        public static bool addClient(string accNum, string name, string phone, string pinCode) {
            bool isAdded = false;
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = "Insert into Clients Values (@AN, @PC, @N, @P, null)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AN", accNum);
            cmd.Parameters.AddWithValue("@PC", (string.IsNullOrEmpty(pinCode) ? DBNull.Value : (object)pinCode));
            cmd.Parameters.AddWithValue("@N", name);
            cmd.Parameters.AddWithValue("@P", phone);
            try {
                conn.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0) {
                    isAdded = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isAdded;
        }
        public static bool isAccountNumExists(string accNum) {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = $"Select found = 1 from Clients where accountNumber = @AC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AC", accNum);
            try {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) {
                    isFound = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isFound;
        }
        public static bool findClient(string accNum, ref string pinCode, ref string name, ref string phone, ref decimal balance) {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = $"Select * from Clients where accountNumber = @AC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AC", accNum);
            try {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    isFound = true;
                    if (reader[1] != DBNull.Value) {
                        pinCode = reader[1].ToString();
                    }
                    else {
                        pinCode = "No pinCode assigned yet";
                    }
                    name = reader[2].ToString();
                    phone = reader[3].ToString();
                    if (reader[4] != DBNull.Value)
                        balance = Convert.ToDecimal(reader[4]);
                }
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isFound;
        }
        public static bool updateClient(string accNum, string pinCode, string name, string phone, decimal balance) {
            bool isUpdated = false;
            SqlConnection conn = new SqlConnection(connectionSettings);
            string query = "update Clients set pinCode = @PC, clientName = @N, phone = @P, " +
                "balance = @b where accountNumber = @AN";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AN", accNum);
            cmd.Parameters.AddWithValue("@PC", (string.IsNullOrEmpty(pinCode) ? DBNull.Value : (object)pinCode));
            cmd.Parameters.AddWithValue("@N", name);
            cmd.Parameters.AddWithValue("@P", phone);
            if (balance != 0.0m) 
                cmd.Parameters.AddWithValue("@b", balance);
            
            else 
                cmd.Parameters.AddWithValue("@b", DBNull.Value);
            
            try {
                conn.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0) {
                    isUpdated = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                conn.Close();
            }
            return isUpdated;
        }
    }
}

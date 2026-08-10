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
    }
}

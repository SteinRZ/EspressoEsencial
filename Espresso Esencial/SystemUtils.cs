using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Espresso_Esencial
{
    internal static class SystemUtils
    {
        public static SqlConnection Connection { get; set; }
        public static string Username { get; set; }
        public static bool ConnectToDatabase(string username, string password, out string errorMsg)
        {
            errorMsg = String.Empty;
            Connection = new SqlConnection($"Data Source=DESKTOP-73A333L\\MSSQLSERVERPEPSI;Initial Catalog=Espresso_Esencial;User ID={username};Password={password}");
            try
            {
                Connection.Open();
            }
            catch(Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
            Username = username;
            return true;
        }
        public static IDataReader MakeQuery(string query)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, SystemUtils.Connection);
                return sqlCommand.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

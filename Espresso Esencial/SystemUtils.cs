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
        public static void GenericUpdate(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            try
            {
                using (SqlCommand update = new SqlCommand($"UPDATE {grid.Name} SET {grid.Columns[e.ColumnIndex].Name} = @valor WHERE {grid.Columns[0].Name} = @id"))
                {
                    update.Connection = SystemUtils.Connection;
                    update.Parameters.AddWithValue("@valor", grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    update.Parameters.AddWithValue("@id", grid.Rows[e.RowIndex].Cells[0].Value);
                    if (MessageBox.Show("¿Estás seguro de cambiar el registro?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        DataTable dt = grid.DataSource as DataTable;
                        dt.RejectChanges();
                        return;
                    }
                    update.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteFromTable(ref DataGridView grid)
        {
            try
            {
                List<int> markedForDeletion = new List<int>();
                if (grid.SelectedRows.Count == 0) return;
                if (MessageBox.Show($"¿Estás seguro de eliminar [{grid.SelectedRows.Count}] registro(s)?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                int counter = 0;
                for (int i = 0; i < grid.SelectedRows.Count; i++)
                {
                    markedForDeletion.Add(grid.SelectedRows[i].Index);
                    using (SqlCommand delete = new SqlCommand($"DELETE FROM {grid.Name} WHERE {grid.Columns[0].Name} = @id"))
                    {
                        delete.Connection = SystemUtils.Connection;
                        delete.Parameters.AddWithValue("@id", grid.SelectedRows[i].Cells[0].Value);
                        counter += delete.ExecuteNonQuery();
                    }
                }
                foreach(int i in markedForDeletion)
                {
                    grid.Rows.RemoveAt(i);
                }
                MessageBox.Show($"Se eliminaron {counter} registros.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

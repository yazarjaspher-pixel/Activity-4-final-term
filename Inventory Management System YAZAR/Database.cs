using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_YAZAR
{
    internal class Database
    {
        public static string yazarDbPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\yazardb.accdb"));
        public static string yazarConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + yazarDbPath + ";";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(yazarConnString);
        }

        public static void AddLog(int yazarUserId, string yazarActivity)
        {
            try
            {
                using (OleDbConnection yazarConn = GetConnection())
                {
                    yazarConn.Open();
                    string yazarQuery = "INSERT INTO ActivityLogs (UserID, Activity, LogDate) VALUES (?, ?, ?)";

                    using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                    {
                        yazarCmd.Parameters.AddWithValue("?", yazarUserId);
                        yazarCmd.Parameters.AddWithValue("?", yazarActivity);
                        yazarCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        yazarCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not save activity log: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool DeleteProduct(int yazarProductId)
        {
            try
            {
                using (OleDbConnection yazarConn = GetConnection())
                {
                    yazarConn.Open();
                    string yazarQuery = "DELETE FROM Products WHERE ProductID = ?";

                    using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                    {
                        yazarCmd.Parameters.AddWithValue("?", yazarProductId);
                        yazarCmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not delete product: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

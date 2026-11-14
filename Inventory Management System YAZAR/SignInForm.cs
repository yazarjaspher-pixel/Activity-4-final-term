using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_YAZAR
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnYazarSignIn_Click(object sender, EventArgs e)
        {
            string yazarUsername = txtYazarUsername.Text.Trim();
            string yazarPassword = txtYazarPassword.Text;

            if (yazarUsername == "" || yazarPassword == "")
            {
                MessageBox.Show("Please enter your username and password.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yazarUserId = 0;
            string yazarStoredHash = "";
            string yazarFullName = "";
            string yazarRole = "";
            bool yazarIsActive = false;
            bool yazarFound = false;

            try
            {
                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();
                    string yazarQuery = "SELECT UserID, PasswordHash, FullName, UserRole, IsActive FROM Users WHERE Username = ?";

                    using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                    {
                        yazarCmd.Parameters.AddWithValue("?", yazarUsername);

                        using (OleDbDataReader yazarReader = yazarCmd.ExecuteReader())
                        {
                            if (yazarReader.Read())
                            {
                                yazarFound = true;
                                yazarUserId = Convert.ToInt32(yazarReader["UserID"]);
                                yazarStoredHash = yazarReader["PasswordHash"].ToString();
                                yazarFullName = yazarReader["FullName"].ToString();
                                yazarRole = yazarReader["UserRole"].ToString();
                                yazarIsActive = Convert.ToBoolean(yazarReader["IsActive"]);
                            }
                        }
                    }
                }
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Database error: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yazarFound == false || PasswordHelper.VerifyPassword(yazarPassword, yazarStoredHash) == false)
            {
                MessageBox.Show("Invalid username or password.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yazarIsActive == false)
            {
                MessageBox.Show("This account is not active. Please contact the admin.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database.AddLog(yazarUserId, "Signed in");
            MessageBox.Show("Welcome, " + yazarFullName + "!", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtYazarUsername.Clear();
            txtYazarPassword.Clear();

            InventoryForm yazarInventory = new InventoryForm(yazarUserId, yazarFullName, yazarRole);
            yazarInventory.Show();
            this.Hide();
        }

        private void lnkYazarRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm yazarRegister = new RegisterForm();
            yazarRegister.Show();
            this.Hide();
        }
    }
}

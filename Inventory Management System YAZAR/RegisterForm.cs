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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnYazarRegister_Click(object sender, EventArgs e)
        {
            string yazarFullName = txtYazarFullName.Text.Trim();
            string yazarUsername = txtYazarUsername.Text.Trim();
            string yazarPassword = txtYazarPassword.Text;
            string yazarConfirmPassword = txtYazarConfirmPassword.Text;

            if (yazarFullName == "" || yazarUsername == "" || yazarPassword == "" || yazarConfirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yazarPassword != yazarConfirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yazarPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();

                    string yazarCheckQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                    using (OleDbCommand yazarCheckCmd = new OleDbCommand(yazarCheckQuery, yazarConn))
                    {
                        yazarCheckCmd.Parameters.AddWithValue("?", yazarUsername);
                        int yazarUserCount = Convert.ToInt32(yazarCheckCmd.ExecuteScalar());

                        if (yazarUserCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another one.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string yazarPasswordHash = PasswordHelper.HashPassword(yazarPassword);
                    string yazarInsertQuery = "INSERT INTO Users (Username, PasswordHash, FullName, UserRole, IsActive) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand yazarInsertCmd = new OleDbCommand(yazarInsertQuery, yazarConn))
                    {
                        yazarInsertCmd.Parameters.AddWithValue("?", yazarUsername);
                        yazarInsertCmd.Parameters.AddWithValue("?", yazarPasswordHash);
                        yazarInsertCmd.Parameters.AddWithValue("?", yazarFullName);
                        yazarInsertCmd.Parameters.AddWithValue("?", "Staff");
                        yazarInsertCmd.Parameters.AddWithValue("?", true);
                        yazarInsertCmd.ExecuteNonQuery();
                    }

                    using (OleDbCommand yazarIdCmd = new OleDbCommand("SELECT @@IDENTITY", yazarConn))
                    {
                        int yazarNewUserId = Convert.ToInt32(yazarIdCmd.ExecuteScalar());
                        Database.AddLog(yazarNewUserId, "Registered a new account");
                    }
                }

                MessageBox.Show("Account created successfully! You can now sign in.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Database error: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkYazarSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form yazarSignIn = Application.OpenForms["SignInForm"];
            if (yazarSignIn != null)
            {
                yazarSignIn.Show();
            }
        }
    }
}

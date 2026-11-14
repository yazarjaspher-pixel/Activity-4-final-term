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
    public partial class InventoryForm : Form
    {
        private int yazarUserId;
        private string yazarFullName;
        private bool yazarLoggingOut = false;
        private string yazarStatusQuery = "IIF(Quantity = 0, 'Out of Stock', IIF(Quantity <= ReorderLevel, 'Low Stock', 'In Stock'))";

        public InventoryForm(int yazarId, string yazarName, string yazarUserRole)
        {
            InitializeComponent();
            yazarUserId = yazarId;
            yazarFullName = yazarName;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            lblYazarUserInfo.Text = "Logged in as: " + yazarFullName;
            lblYazarWelcome.Text = "Welcome, " + yazarFullName + "!";
            LoadProducts("");
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            pnlYazarDashboard.Visible = true;
            pnlYazarProducts.Visible = false;
            lblYazarPageTitle.Text = "DASHBOARD";
            btnYazarDashboard.BackColor = Color.White;
            btnYazarProducts.BackColor = SystemColors.Control;
            LoadDashboard();
        }

        private void ShowProducts()
        {
            pnlYazarDashboard.Visible = false;
            pnlYazarProducts.Visible = true;
            lblYazarPageTitle.Text = "PRODUCTS";
            btnYazarDashboard.BackColor = SystemColors.Control;
            btnYazarProducts.BackColor = Color.White;
        }

        private int GetCount(string yazarQuery)
        {
            using (OleDbConnection yazarConn = Database.GetConnection())
            {
                yazarConn.Open();
                using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                {
                    return Convert.ToInt32(yazarCmd.ExecuteScalar());
                }
            }
        }

        private void LoadDashboard()
        {
            try
            {
                lblYazarTotalCount.Text = GetCount("SELECT COUNT(*) FROM Products").ToString();
                lblYazarInStockCount.Text = GetCount("SELECT COUNT(*) FROM Products WHERE Quantity > 0 AND Quantity > ReorderLevel").ToString();
                lblYazarLowStockCount.Text = GetCount("SELECT COUNT(*) FROM Products WHERE Quantity > 0 AND Quantity <= ReorderLevel").ToString();
                lblYazarOutStockCount.Text = GetCount("SELECT COUNT(*) FROM Products WHERE Quantity = 0").ToString();
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not load dashboard: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts(string yazarSearch)
        {
            try
            {
                string yazarQuery = "SELECT ProductID, ProductCode AS [ID], ProductName AS [PRODUCT NAME], Category AS [CATEGORY], Description AS [DESCRIPTION], Quantity AS [QUANTITY], ReorderLevel AS [REORDER LEVEL], Price AS [UNIT PRICE], Supplier AS [SUPPLIER], DateAdded AS [DATE ADDED], " + yazarStatusQuery + " AS [STATUS] FROM Products";

                if (yazarSearch != "")
                {
                    yazarQuery = yazarQuery + " WHERE ProductCode LIKE ? OR ProductName LIKE ? OR Category LIKE ? OR Supplier LIKE ? OR Description LIKE ?";
                }

                yazarQuery = yazarQuery + " ORDER BY ProductCode";

                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();
                    using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                    {
                        if (yazarSearch != "")
                        {
                            yazarCmd.Parameters.AddWithValue("?", "%" + yazarSearch + "%");
                            yazarCmd.Parameters.AddWithValue("?", "%" + yazarSearch + "%");
                            yazarCmd.Parameters.AddWithValue("?", "%" + yazarSearch + "%");
                            yazarCmd.Parameters.AddWithValue("?", "%" + yazarSearch + "%");
                            yazarCmd.Parameters.AddWithValue("?", "%" + yazarSearch + "%");
                        }

                        OleDbDataAdapter yazarAdapter = new OleDbDataAdapter(yazarCmd);
                        DataTable yazarTable = new DataTable();
                        yazarAdapter.Fill(yazarTable);
                        dgvYazarProducts.DataSource = yazarTable;

                        lblYazarTotalProducts.Text = "Total Products: " + yazarTable.Rows.Count;
                    }
                }
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not load products: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvYazarProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvYazarProducts.Columns["ProductID"] == null)
            {
                return;
            }

            dgvYazarProducts.Columns["ProductID"].Visible = false;
            dgvYazarProducts.Columns["UNIT PRICE"].DefaultCellStyle.Format = "N2";
            dgvYazarProducts.Columns["DATE ADDED"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvYazarProducts.Columns["DESCRIPTION"].FillWeight = 180;

            if (dgvYazarProducts.Columns["colYazarEdit"] != null)
            {
                dgvYazarProducts.Columns.Remove("colYazarEdit");
            }

            if (dgvYazarProducts.Columns["colYazarDelete"] != null)
            {
                dgvYazarProducts.Columns.Remove("colYazarDelete");
            }

            DataGridViewButtonColumn yazarEditColumn = new DataGridViewButtonColumn();
            yazarEditColumn.Name = "colYazarEdit";
            yazarEditColumn.HeaderText = "";
            yazarEditColumn.Text = "Edit";
            yazarEditColumn.UseColumnTextForButtonValue = true;
            dgvYazarProducts.Columns.Add(yazarEditColumn);

            DataGridViewButtonColumn yazarDeleteColumn = new DataGridViewButtonColumn();
            yazarDeleteColumn.Name = "colYazarDelete";
            yazarDeleteColumn.HeaderText = "";
            yazarDeleteColumn.Text = "Delete";
            yazarDeleteColumn.UseColumnTextForButtonValue = true;
            dgvYazarProducts.Columns.Add(yazarDeleteColumn);
        }

        private void RefreshAll()
        {
            LoadProducts(txtYazarSearch.Text.Trim());
            LoadDashboard();
        }

        private void btnYazarDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnYazarProducts_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void btnYazarSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtYazarSearch.Text.Trim());
        }

        private void txtYazarSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadProducts(txtYazarSearch.Text.Trim());
                e.SuppressKeyPress = true;
            }
        }

        private void btnYazarRefresh_Click(object sender, EventArgs e)
        {
            txtYazarSearch.Clear();
            LoadProducts("");
            LoadDashboard();
        }

        private void btnYazarAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm yazarProductForm = new ProductForm(0, yazarUserId);
            if (yazarProductForm.ShowDialog() == DialogResult.OK)
            {
                RefreshAll();
            }
        }

        private void dgvYazarProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string yazarColumnName = dgvYazarProducts.Columns[e.ColumnIndex].Name;
            int yazarProductId = Convert.ToInt32(dgvYazarProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
            string yazarProductCode = dgvYazarProducts.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string yazarProductName = dgvYazarProducts.Rows[e.RowIndex].Cells["PRODUCT NAME"].Value.ToString();

            if (yazarColumnName == "colYazarEdit")
            {
                ProductForm yazarProductForm = new ProductForm(yazarProductId, yazarUserId);
                if (yazarProductForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshAll();
                }
            }
            else if (yazarColumnName == "colYazarDelete")
            {
                DialogResult yazarAnswer = MessageBox.Show("Are you sure you want to delete this product?\n\n" + yazarProductCode + " - " + yazarProductName, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (yazarAnswer == DialogResult.Yes)
                {
                    if (Database.DeleteProduct(yazarProductId))
                    {
                        Database.AddLog(yazarUserId, "Deleted product " + yazarProductCode + " - " + yazarProductName);
                        MessageBox.Show("Product deleted successfully.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshAll();
                    }
                }
            }
        }

        private void btnYazarLogout_Click(object sender, EventArgs e)
        {
            DialogResult yazarAnswer = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yazarAnswer == DialogResult.Yes)
            {
                Database.AddLog(yazarUserId, "Logged out");
                yazarLoggingOut = true;
                this.Close();
            }
        }

        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (yazarLoggingOut == true)
            {
                Form yazarSignIn = Application.OpenForms["SignInForm"];
                if (yazarSignIn != null)
                {
                    yazarSignIn.Show();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}

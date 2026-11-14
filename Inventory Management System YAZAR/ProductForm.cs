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
    public partial class ProductForm : Form
    {
        private int yazarProductId;
        private int yazarUserId;

        public ProductForm(int yazarId, int yazarUser)
        {
            InitializeComponent();
            yazarProductId = yazarId;
            yazarUserId = yazarUser;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (yazarProductId == 0)
            {
                lblYazarHeader.Text = "ADD PRODUCT";
                btnYazarSave.Text = "Save";
                btnYazarDeleteProduct.Visible = false;
                txtYazarProductId.Text = GenerateProductCode();
                dtpYazarDateAdded.Value = DateTime.Now;
            }
            else
            {
                lblYazarHeader.Text = "PRODUCT INFORMATION";
                btnYazarSave.Text = "Update";
                btnYazarDeleteProduct.Visible = true;
                LoadProduct();
            }
        }

        private string GenerateProductCode()
        {
            int yazarNextNumber = 1;

            try
            {
                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();
                    using (OleDbCommand yazarCmd = new OleDbCommand("SELECT MAX(ProductID) FROM Products", yazarConn))
                    {
                        object yazarResult = yazarCmd.ExecuteScalar();
                        if (yazarResult != DBNull.Value && yazarResult != null)
                        {
                            yazarNextNumber = Convert.ToInt32(yazarResult) + 1;
                        }
                    }
                }
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not create product ID: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "P" + yazarNextNumber.ToString("000");
        }

        private void LoadProduct()
        {
            try
            {
                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();
                    string yazarQuery = "SELECT * FROM Products WHERE ProductID = ?";

                    using (OleDbCommand yazarCmd = new OleDbCommand(yazarQuery, yazarConn))
                    {
                        yazarCmd.Parameters.AddWithValue("?", yazarProductId);

                        using (OleDbDataReader yazarReader = yazarCmd.ExecuteReader())
                        {
                            if (yazarReader.Read())
                            {
                                txtYazarProductId.Text = yazarReader["ProductCode"].ToString();
                                txtYazarProductName.Text = yazarReader["ProductName"].ToString();
                                cboYazarCategory.Text = yazarReader["Category"].ToString();
                                txtYazarSupplier.Text = yazarReader["Supplier"].ToString();
                                txtYazarQuantity.Text = yazarReader["Quantity"].ToString();
                                txtYazarUnitPrice.Text = Convert.ToDecimal(yazarReader["Price"]).ToString("0.00");
                                dtpYazarDateAdded.Value = Convert.ToDateTime(yazarReader["DateAdded"]);
                                txtYazarReorderLevel.Text = yazarReader["ReorderLevel"].ToString();
                                txtYazarDescription.Text = yazarReader["Description"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Could not load product: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazarSave_Click(object sender, EventArgs e)
        {
            string yazarCode = txtYazarProductId.Text.Trim();
            string yazarName = txtYazarProductName.Text.Trim();
            string yazarSupplier = txtYazarSupplier.Text.Trim();
            string yazarDescription = txtYazarDescription.Text.Trim();
            int yazarQuantity;
            decimal yazarPrice;
            int yazarReorderLevel;

            if (yazarName == "" || cboYazarCategory.SelectedIndex == -1 || yazarSupplier == "" || txtYazarQuantity.Text.Trim() == "" || txtYazarUnitPrice.Text.Trim() == "" || txtYazarReorderLevel.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all the product information.", "Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtYazarQuantity.Text.Trim(), out yazarQuantity) == false || yazarQuantity < 0)
            {
                MessageBox.Show("Quantity must be a whole number (0 or more).", "Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (decimal.TryParse(txtYazarUnitPrice.Text.Trim(), out yazarPrice) == false || yazarPrice < 0)
            {
                MessageBox.Show("Unit Price must be a valid amount.", "Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtYazarReorderLevel.Text.Trim(), out yazarReorderLevel) == false || yazarReorderLevel < 0)
            {
                MessageBox.Show("Reorder Level must be a whole number (0 or more).", "Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection yazarConn = Database.GetConnection())
                {
                    yazarConn.Open();

                    if (yazarProductId == 0)
                    {
                        string yazarInsertQuery = "INSERT INTO Products (ProductCode, ProductName, Category, Supplier, Quantity, Price, DateAdded, ReorderLevel, Description) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OleDbCommand yazarCmd = new OleDbCommand(yazarInsertQuery, yazarConn))
                        {
                            yazarCmd.Parameters.AddWithValue("?", yazarCode);
                            yazarCmd.Parameters.AddWithValue("?", yazarName);
                            yazarCmd.Parameters.AddWithValue("?", cboYazarCategory.Text);
                            yazarCmd.Parameters.AddWithValue("?", yazarSupplier);
                            yazarCmd.Parameters.AddWithValue("?", yazarQuantity);
                            yazarCmd.Parameters.Add("?", OleDbType.Currency).Value = yazarPrice;
                            yazarCmd.Parameters.Add("?", OleDbType.Date).Value = dtpYazarDateAdded.Value.Date;
                            yazarCmd.Parameters.AddWithValue("?", yazarReorderLevel);
                            yazarCmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = yazarDescription;
                            yazarCmd.ExecuteNonQuery();
                        }

                        Database.AddLog(yazarUserId, "Added product " + yazarCode + " - " + yazarName);
                        MessageBox.Show("Product added successfully!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string yazarUpdateQuery = "UPDATE Products SET ProductName = ?, Category = ?, Supplier = ?, Quantity = ?, Price = ?, DateAdded = ?, ReorderLevel = ?, Description = ? WHERE ProductID = ?";

                        using (OleDbCommand yazarCmd = new OleDbCommand(yazarUpdateQuery, yazarConn))
                        {
                            yazarCmd.Parameters.AddWithValue("?", yazarName);
                            yazarCmd.Parameters.AddWithValue("?", cboYazarCategory.Text);
                            yazarCmd.Parameters.AddWithValue("?", yazarSupplier);
                            yazarCmd.Parameters.AddWithValue("?", yazarQuantity);
                            yazarCmd.Parameters.Add("?", OleDbType.Currency).Value = yazarPrice;
                            yazarCmd.Parameters.Add("?", OleDbType.Date).Value = dtpYazarDateAdded.Value.Date;
                            yazarCmd.Parameters.AddWithValue("?", yazarReorderLevel);
                            yazarCmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = yazarDescription;
                            yazarCmd.Parameters.AddWithValue("?", yazarProductId);
                            yazarCmd.ExecuteNonQuery();
                        }

                        Database.AddLog(yazarUserId, "Updated product " + yazarCode + " - " + yazarName);
                        MessageBox.Show("Product updated successfully!", "Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception yazarEx)
            {
                MessageBox.Show("Database error: " + yazarEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazarClear_Click(object sender, EventArgs e)
        {
            txtYazarProductName.Clear();
            cboYazarCategory.SelectedIndex = -1;
            txtYazarSupplier.Clear();
            txtYazarQuantity.Clear();
            txtYazarUnitPrice.Clear();
            dtpYazarDateAdded.Value = DateTime.Now;
            txtYazarReorderLevel.Clear();
            txtYazarDescription.Clear();
            txtYazarProductName.Focus();
        }

        private void btnYazarDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult yazarAnswer = MessageBox.Show("Are you sure you want to delete this product?\n\n" + txtYazarProductId.Text + " - " + txtYazarProductName.Text, "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (yazarAnswer == DialogResult.Yes)
            {
                if (Database.DeleteProduct(yazarProductId))
                {
                    Database.AddLog(yazarUserId, "Deleted product " + txtYazarProductId.Text + " - " + txtYazarProductName.Text);
                    MessageBox.Show("Product deleted successfully.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnYazarClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

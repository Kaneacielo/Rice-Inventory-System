using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RiceInventory
{
    public partial class Form3 : Form
    {
        private const string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=inventorydb";

        public Form3()
        {
            InitializeComponent();
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, ItemName, Quantity, Price FROM inventory";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewInventory.DataSource = dataTable;


                        dataGridViewInventory.Columns["Id"].Visible = false;

                        foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                        {
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            if (quantity <= 5)
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                            }
                        }

                        if (HasLowQuantityItems(dataTable))
                        {
                            MessageBox.Show("Warning: Some items have a quantity of 5 or below.", "Low Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error loading inventory data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasLowQuantityItems(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int quantity = Convert.ToInt32(row["Quantity"]);
                if (quantity <= 5)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("INSERT INTO inventory (ItemName, Quantity, Price) VALUES (@ItemName, @Quantity, @Price);", connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                        command.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInventoryData();
                        ClearTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInventory.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewInventory.SelectedCells[0].RowIndex;
                    int itemId = Convert.ToInt32(dataGridViewInventory.Rows[selectedRowIndex].Cells["Id"].Value);

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand("UPDATE inventory SET ItemName = @ItemName, Quantity = @Quantity, Price = @Price WHERE Id = @Id;", connection))
                        {
                            command.Parameters.AddWithValue("@Id", itemId);
                            command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                            command.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                            command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                            command.ExecuteNonQuery();

                            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadInventoryData();
                            ClearTextBoxes();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInventory.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewInventory.SelectedCells[0].RowIndex;
                    int itemId = Convert.ToInt32(dataGridViewInventory.Rows[selectedRowIndex].Cells["Id"].Value);

                    DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand("DELETE FROM inventory WHERE Id = @Id;", connection))
                            {
                                command.Parameters.AddWithValue("@Id", itemId);

                                command.ExecuteNonQuery();

                                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadInventoryData();
                                ClearTextBoxes();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void ClearTextBoxes()
        {
            txtItemName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }
    }
}

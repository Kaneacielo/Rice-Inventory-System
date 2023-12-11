using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RiceInventory
{
    public partial class Form2 : Form
    {
        private Dictionary<Panel, string> panelItemMap;
        private Dictionary<string, int> quantities = new Dictionary<string, int>();
        private GroupBox groupBoxSelectedItems;
        private Label labelSelectedItemsTitle;
        private TextBox textBoxSelectedItems;


        public Form2()
        {
            InitializeComponent();

            panelItemMap = new Dictionary<Panel, string>()
            {
                { panelC4, "C4" },
                { panelCrystal, "Crystal" },
                { panelJasmine, "Jasmine" },
                { panelSinandomeng, "Sinandomeng" },
                { panelPinawa, "Pinawa" }
            };

            foreach (var panel in panelItemMap.Keys)
            {
                panel.Click += Panel_Click;
            }

            InitializeSelectedItemsSection();
        }

        private void InitializeSelectedItemsSection()
        {
            groupBoxSelectedItems = new GroupBox();
            groupBoxSelectedItems.Text = "Selected Items";
            groupBoxSelectedItems.Location = new Point(20, 200);
            groupBoxSelectedItems.Size = new Size(250, 150);
            Controls.Add(groupBoxSelectedItems);

            labelSelectedItemsTitle = new Label();
            labelSelectedItemsTitle.Text = "Items:";
            labelSelectedItemsTitle.Location = new Point(10, 20);
            groupBoxSelectedItems.Controls.Add(labelSelectedItemsTitle);

            textBoxSelectedItems = new TextBox();
            textBoxSelectedItems.Multiline = true;
            textBoxSelectedItems.ScrollBars = ScrollBars.Vertical;
            textBoxSelectedItems.Location = new Point(10, 40);
            textBoxSelectedItems.Size = new Size(230, 90);
            textBoxSelectedItems.ReadOnly = true;
            groupBoxSelectedItems.Controls.Add(textBoxSelectedItems);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;

            if (panelItemMap.TryGetValue(clickedPanel, out string itemName))
            {
                int quantity = GetQuantityInput(itemName);
                if (quantity > 0)
                {
                    quantities[itemName] = quantity;
                    SubtractQuantityFromInventory(itemName, quantity);
                    SaveReceiptToDatabase(itemName, quantity);
                    UpdateSelectedItemsTextBox();
                }
            }
        }

        private int GetQuantityInput(string itemName)
        {
            using (Form quantityForm = new Form())
            {
                quantityForm.Text = $"Enter Quantity for {itemName}";
                quantityForm.StartPosition = FormStartPosition.CenterScreen;

                Label quantityLabel = new Label();
                quantityLabel.Text = "Quantity:";
                quantityLabel.Location = new Point(10, 20);
                quantityForm.Controls.Add(quantityLabel);

                NumericUpDown quantityNumericUpDown = new NumericUpDown();
                quantityNumericUpDown.Location = new Point(10, 50);
                quantityForm.Controls.Add(quantityNumericUpDown);

                Button submitButton = new Button();
                submitButton.Text = "Submit";
                submitButton.Location = new Point(10, 80);
                submitButton.Click += (sender, e) =>
                {
                    quantities[itemName] = (int)quantityNumericUpDown.Value;
                    quantityForm.DialogResult = DialogResult.OK;
                    quantityForm.Close();
                };
                quantityForm.Controls.Add(submitButton);

                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    return (int)quantityNumericUpDown.Value;
                }
            }

            return 0;
        }

        private void SubtractQuantityFromInventory(string itemName, int quantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password='';database=inventorydb"))
                {
                    connection.Open();

                    string selectQuery = "SELECT Quantity FROM inventory WHERE ItemName = @ItemName";
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@ItemName", itemName);
                        int currentQuantity = Convert.ToInt32(selectCommand.ExecuteScalar());

                        if (quantity <= currentQuantity)
                        {
                            string updateQuery = "UPDATE inventory SET Quantity = Quantity - @Quantity WHERE ItemName = @ItemName";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                updateCommand.Parameters.AddWithValue("@ItemName", itemName);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error: Quantity to be subtracted exceeds available quantity ({currentQuantity}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReceiptToDatabase(string itemName, int quantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password='';database=inventorydb"))
                {
                    connection.Open();

                    string selectPriceQuery = "SELECT Price FROM inventory WHERE ItemName = @ItemName";
                    using (MySqlCommand selectPriceCommand = new MySqlCommand(selectPriceQuery, connection))
                    {
                        selectPriceCommand.Parameters.AddWithValue("@ItemName", itemName);
                        decimal itemPrice = Convert.ToDecimal(selectPriceCommand.ExecuteScalar());

                        string insertQuery = "INSERT INTO records (ItemName, QuantityBought, TotalPrice, PurchaseDate) VALUES (@ItemName, @QuantityBought, @TotalPrice, @PurchaseDate)";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@ItemName", itemName);
                            insertCommand.Parameters.AddWithValue("@QuantityBought", quantity);

                            decimal totalPrice = quantity * itemPrice;
                            insertCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);

                            insertCommand.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error saving receipt to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSelectedItemsTextBox()
        {
            textBoxSelectedItems.Text = string.Join(Environment.NewLine, quantities.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

            this.Hide();
        }
    }
}

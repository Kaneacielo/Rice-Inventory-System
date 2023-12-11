using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RiceInventory
{
    public partial class Form4 : Form
    {
        private const string ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=inventorydb";

        public Form4()
        {
            InitializeComponent();
            LoadRecordsData();
        }

        private void LoadRecordsData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT RecordId, ItemName, QuantityBought, TotalPrice, PurchaseDate FROM records";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewRecords.DataSource = dataTable;


                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error loading records data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }
    }
}

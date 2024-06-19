using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HMS
{
    public partial class Billing : Form
    {
        // For connection 
        string path = "HOTELRESTO.db3";
        string cs = @"URI=file:" + Application.StartupPath + "\\HOTELRESTO.db3";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Billing()
        {
            InitializeComponent();
        }

        // Show data in data grid view
        private void data_show()
        {
            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM Billing";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetInt32(1), dr.GetInt32(0)); // Changed order to match BillingID, TotalAmount
            }

            con.Close();
        }

        // Create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Billing (TotalAmount INTEGER, BillingID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL);";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database already exists");
                return;
            }
        }

        // Insert data
        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO Billing (TotalAmount) VALUES (@totalAmount);"; // AUTOINCREMENT does not need BillingID
                string TOTALAMOUNT = totalAmountText.Text;

                cmd.Parameters.AddWithValue("@totalAmount", TOTALAMOUNT);

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Billing ID";
                dataGridView1.Columns[1].Name = "Total Amount";

                cmd.ExecuteNonQuery();
                data_show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot insert data: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }
        }

        // Update data
        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "UPDATE Billing SET TotalAmount = @totalAmount WHERE BillingID = @billingID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@totalAmount", totalAmountText.Text);
                cmd.Parameters.AddWithValue("@billingID", billingIDText.Text);

                cmd.ExecuteNonQuery();
                data_show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot update data: " + ex.Message);
                return;
            }
        }

        // Delete data
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM Billing WHERE BillingID = @billingID";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@billingID", billingIDText.Text);

                cmd.ExecuteNonQuery();
                data_show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot delete data: " + ex.Message);
                return;
            }
        }

        // Load event
        private void Billing_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show(); // Show existing data on load
        }

        // Other event handlers can remain unchanged
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void list_Click(object sender, EventArgs e) { }

        private void billingIDText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

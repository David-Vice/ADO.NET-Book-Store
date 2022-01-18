using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_WinForm_HW1.ButtonForms
{
    public partial class Sell : Form
    {
        private string getTable = $@"SELECT Book.Name as Book, CONCAT(Manager.Name,' ',Manager.Lastname) as Manager, Movement.MovementDate, Book.StockPrice as StockPrice, Book.SellPrice as SellPrice, Movement.NumberSold, Book.SellPrice*Movement.NumberSold as Total
                                     FROM [Movement]
                                     JOIN [Book] ON Book.Id = Movement.BookId
                                     JOIN [Manager] ON Manager.Id = Movement.ManagerId";

        public Sell()
        {
            InitializeComponent();
        }

        private void MakeSell_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show(getTable);

            DataTable books = Query.Show("SELECT Book.Name FROM [Book];");
            foreach (DataRow row in books.Rows)
            {
                bookCB.Items.Add(row[0].ToString());
            }
        }

        private void productCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string findPrice = $@"SELECT Book.StockPrice FROM Book WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand command1 = new SqlCommand(findPrice, Main.connection);
            stockNumLabel.Text = Convert.ToString(command1.ExecuteScalar());

            string findSellPrice = $@"SELECT Book.SellPrice FROM Book WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand commandSell = new SqlCommand(findSellPrice, Main.connection);
            sellNumLabel.Text = Convert.ToString(commandSell.ExecuteScalar());

            string findQuantity = $@"SELECT Book.Quantity FROM Book WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand command2 = new SqlCommand(findQuantity, Main.connection);
            quantNumLabel.Text = Convert.ToString(command2.ExecuteScalar());
        }

        private void quantTB_TextChanged(object sender, EventArgs e)
        {
            if (quantTB.Text != string.Empty)
            totalNumLabel.Text = Convert.ToString(Convert.ToInt32(sellNumLabel.Text) * Convert.ToInt32(quantTB.Text));
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            string insertQuery = $@"INSERT INTO [Movement] (BookId,ManagerId,NumberSold,MovementDate)
                                    SELECT Book.Id,Manager.Id,{quantTB.Text}, CAST( GETDATE() AS Date )
                                    FROM [Book],[Manager]
                                    WHERE
                                    Book.Name = '{bookCB.SelectedItem}' 
                                    AND
                                    Manager.Id = {Main.ManagerId} ";
            SqlCommand insertCommand = new SqlCommand(insertQuery, Main.connection);
            insertCommand.ExecuteNonQuery();

            string oldProductQuantity = $@"SELECT Book.Quantity FROM Book WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand commandOldProductQuantity = new SqlCommand(oldProductQuantity, Main.connection);
            int oldProductValue = Convert.ToInt32(commandOldProductQuantity.ExecuteScalar());

            string newProductQuantity = $@"UPDATE Book
                                        SET Book.Quantity = {oldProductValue - Convert.ToInt32(quantTB.Text)}
                                        WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_WinForm_HW1.ButtonForms
{
    public partial class Aside : Form
    {
        private string getTable = $@"SELECT Aside.Id, Book.Name as Book, CONCAT(Buyer.Name,' ',Buyer.Lastname) as Buyer, Aside.Quantity
                                     FROM Aside
                                     JOIN Book ON Book.Id = Aside.BookId
                                     JOIN Buyer ON Buyer.Id = Aside.BuyerId;";

        public Aside()
        {
            InitializeComponent();
        }
        private void Book_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show(getTable);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            DataTable buyers = Query.Show("SELECT CONCAT(Buyer.Name,' ',Buyer.Lastname) as Buyer FROM [Buyer];");
            foreach (DataRow row in buyers.Rows)
            {
                buyerCB.Items.Add(row[0].ToString());
            }
            DataTable books = Query.Show("SELECT Book.Name FROM [Book];");
            foreach (DataRow row in books.Rows)
            {
                bookCB.Items.Add(row[0].ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [Aside] (BuyerId,BookId,Quantity)
                              SELECT Buyer.Id,Book.Id,'{quantTB.Text}' 
                              FROM Book, Buyer
                              WHERE Book.Name = '{bookCB.SelectedItem}' AND CONCAT(Buyer.Name,' ',Buyer.Lastname) = '{buyerCB.SelectedItem}';";
            SqlCommand command = new SqlCommand(query, Main.connection);
            command.ExecuteNonQuery();

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string queryDelete = $@"DELETE FROM Aside WHERE Aside.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();
        }

        private void bookCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string findQuantity = $@"SELECT Book.Quantity FROM Book WHERE Book.Name = '{bookCB.SelectedItem}';";
            SqlCommand command2 = new SqlCommand(findQuantity, Main.connection);
            quantNumLabel.Text = Convert.ToString(command2.ExecuteScalar());
        }
    }
}

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
    public partial class Book : Form
    {
        private string getTable = $@"SELECT Book.Id, Book.Name, Author.Name as Author, Genre.Name as Genre, Series.Name as Series, Book.Pages, Book.Year, Book.StockPrice, Book.SellPrice, Book.Quantity
                                     FROM Book 
                                     JOIN Author ON Book.AuthorId = Author.Id
                                     JOIN Genre ON Book.GenreId = Genre.Id
                                     JOIN Series ON Book.SeriesId = Series.Id;";

        public Book()
        {
            InitializeComponent();
        }
        private void Book_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show(getTable);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            DataTable authors = Query.Show("SELECT Author.Name FROM [Author];");
            foreach (DataRow row in authors.Rows)
            {
                auhtorCB.Items.Add(row[0].ToString());
            }
            DataTable genres = Query.Show("SELECT Genre.Name FROM [Genre];");
            foreach (DataRow row in genres.Rows)
            {
                genreCB.Items.Add(row[0].ToString());
            }
            DataTable series = Query.Show("SELECT Series.Name FROM [Series];");
            foreach (DataRow row in series.Rows)
            {
                seriesCB.Items.Add(row[0].ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [Book] (Name,AuthorId,GenreId,SeriesId,Pages,Year,StockPrice,SellPrice,Quantity)
                              SELECT '{nameTB.Text}',Author.Id,Genre.Id,Series.Id,'{pagesTB.Text}','{yearTB.Text}','{stockpriceTB.Text}','{sellpriceTB.Text}','{quantTB.Text}' 
                              FROM Author,Genre,Series 
                              WHERE Author.Name = '{auhtorCB.SelectedItem}' AND Genre.Name = '{genreCB.SelectedItem}' AND Series.Name = '{seriesCB.SelectedItem}';";
            SqlCommand command = new SqlCommand(query, Main.connection);
            command.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string queryUpdate = $@"UPDATE Book
                                    SET Book.{dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name} = '{dataGridView1.CurrentCell.Value}'
                                    WHERE Book.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandUpdate = new SqlCommand(queryUpdate, Main.connection);
            commandUpdate.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string queryDeleteConstr = $@"DELETE FROM Movement WHERE Movement.BookId = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDeleteConstr = new SqlCommand(queryDeleteConstr, Main.connection);
            commandDeleteConstr.ExecuteNonQuery();

            string queryDelete = $@"DELETE FROM Book WHERE Book.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}

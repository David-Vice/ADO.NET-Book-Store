using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using ADO.NET_WinForm_HW1.ButtonForms;

namespace ADO.NET_WinForm_HW1
{
    public partial class Main : Form
    {
        public static SqlConnection connection { get; set; }
        public static int ManagerId { get; set; }
        public Main(SqlConnection _connection, int managerId)
        {
            InitializeComponent();

            connection = _connection;
            ManagerId = managerId;

            DataTable managerInfo = Query.Show($"SELECT Manager.Name, Manager.Lastname FROM Manager WHERE Manager.Id = {managerId};");
            DataRow row0 = managerInfo.Rows[0];
            welcomeLabel.Text = $"Current manager: {row0[0]} {row0[1]}";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            paramCB.SelectedIndex = 0;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string searchQuery1 = ($@"SELECT Book.Name, Author.Name as Author, Genre.Name as Genre, Series.Name as Series, Book.Pages, Book.Year, Book.StockPrice, Book.SellPrice, Book.Quantity
                                      FROM Book 
                                      JOIN Author ON Book.AuthorId = Author.Id
                                      JOIN Genre ON Book.GenreId = Genre.Id
                                      JOIN Series ON Book.SeriesId = Series.Id ");
            string searchQuery2 = ";";
            if (paramCB.SelectedItem.ToString()=="Name")
            {
                searchQuery2 = $@" WHERE Book.Name LIKE '%{searchTB.Text}%';";
            }
            else if(paramCB.SelectedItem.ToString() == "Author")
            {
                searchQuery2 = $@" WHERE Author.Name LIKE '%{searchTB.Text}%';";
            }
            else if (paramCB.SelectedItem.ToString() == "Genre")
            {
                searchQuery2 = $@" WHERE Genre.Name LIKE '%{searchTB.Text}%';";
            }
            else if (paramCB.SelectedItem.ToString() == "Series")
            {
                searchQuery2 = $@" WHERE Series.Name LIKE '%{searchTB.Text}%';";
            }
            dataGV.DataSource = Query.Show(searchQuery1+searchQuery2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchTB.Text = "";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ParentForm.Visible = true;
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }

        private void genreButton_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.ShowDialog();
        }

        private void seriesButton_Click(object sender, EventArgs e)
        {
            Series series = new Series();
            series.ShowDialog();
        }

        private void buyerButton_Click(object sender, EventArgs e)
        {
            Buyer buyer = new Buyer();
            buyer.ShowDialog();
        }

        private void setAsideButton_Click(object sender, EventArgs e)
        {
            Aside aside = new Aside();
            aside.ShowDialog();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ShowDialog();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void applyName_Click(object sender, EventArgs e)
        {
            string newProductQuantity = $@"UPDATE Manager SET Manager.Name = '{newNameTB.Text}'
                                        WHERE Manager.Id = {ManagerId};";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();
        }

        private void applyLastname_Click(object sender, EventArgs e)
        {
            string newProductQuantity = $@"UPDATE Manager SET Manager.Lastname = '{newLastnameTB.Text}'
                                        WHERE Manager.Id = {ManagerId};";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();
        }

        private void applyUsername_Click(object sender, EventArgs e)
        {
            string newProductQuantity = $@"UPDATE Manager SET Manager.Login = '{newUsername.Text}'
                                        WHERE Manager.Id = {ManagerId};";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();
        }

        private void applyPassword_Click(object sender, EventArgs e)
        {
            string newProductQuantity = $@"UPDATE Manager SET Manager.Password = '{newPassword.Text}'
                                        WHERE Manager.Id = {ManagerId};";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queryDeleteConstr = $@"DELETE FROM Movement WHERE Movement.ManagerId = {ManagerId};";
            SqlCommand commandDeleteConstr = new SqlCommand(queryDeleteConstr, Main.connection);
            commandDeleteConstr.ExecuteNonQuery();

            string queryDelete = $@"DELETE FROM Manager WHERE Manager.Id = {ManagerId};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();

            this.Close();
        }
    }
}

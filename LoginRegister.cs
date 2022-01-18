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
using ADO.NET_WinForm_HW1.ButtonForms;

namespace ADO.NET_WinForm_HW1
{
    public partial class LoginRegister : Form
    {
        public static SqlConnection connection { get; set; }

        public LoginRegister()
        {
            InitializeComponent();
            string ConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security = true;";
            connection = new SqlConnection(ConStr);
            connection.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = $@"SELECT Manager.Password FROM Manager WHERE Manager.Login = '{loginTB.Text}';";
            SqlCommand commandLogin = new SqlCommand(login, connection);
            string loginResult = Convert.ToString(commandLogin.ExecuteScalar());

            if(loginResult == passTB.Text)
            {
                label3.Text = "Successfully logged in!";
                label3.ForeColor = Color.Green;

                string manager = $@"SELECT Manager.Id FROM Manager WHERE Manager.Login = '{loginTB.Text}' AND Manager.Password = '{passTB.Text}';";
                SqlCommand commandManager = new SqlCommand(manager, connection);
                int managerId = Convert.ToInt32(commandManager.ExecuteScalar());

                Main main = new Main(connection, managerId);
                main.ShowDialog();
            }
            else
            {
                label3.Text = "Wrong login or password!";
                label3.ForeColor = Color.Red;
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void LoginRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}

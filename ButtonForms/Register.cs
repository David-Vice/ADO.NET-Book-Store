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
    public partial class Register : Form
    {
        public static SqlConnection connection { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DataTable regInfo = Query.Show($"SELECT Manager.Login FROM Manager WHERE Manager.Login = '{loginTB.Text}';");

            if(regInfo.Rows.Count>=1)
            {
                infoLabel.Text = "This login already exists!";
                infoLabel.ForeColor = Color.Red;
            }
            else
            {
                string query = $@"INSERT INTO [Manager] (Name, Lastname, Login, Password)
                              VALUES('{nameTB.Text}','{lastnameTB.Text}','{loginTB.Text}','{passTB.Text}')";
                SqlCommand command = new SqlCommand(query, LoginRegister.connection);
                command.ExecuteNonQuery();

                infoLabel.Text = "Registration completed!";
                infoLabel.ForeColor = Color.Green;
            }
        }
    }
}

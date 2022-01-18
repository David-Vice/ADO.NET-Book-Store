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
    public partial class Series : Form
    {
        private string getTable = "SELECT Id, Name FROM Series;";

        public Series()
        {
            InitializeComponent();
        }

        private void Series_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show(getTable);
            dataGridView1.Columns[0].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [Series] (Name)
                              VALUES('{nameTB.Text}')";
            SqlCommand command = new SqlCommand(query, Main.connection);
            command.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string queryUpdate = $@"UPDATE Series
                                    SET Series.{dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name} = '{dataGridView1.CurrentCell.Value}'
                                    WHERE Series.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandUpdate = new SqlCommand(queryUpdate, Main.connection);
            commandUpdate.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string queryDelete = $@"DELETE FROM Series WHERE Series.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}

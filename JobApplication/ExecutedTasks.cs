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

namespace JobApplication
{
    public partial class ExecutedTasks : Form
    {
        public ExecutedTasks()
        {
            BindingSource bs = new BindingSource();
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JobAppDB.mdf;Integrated Security=True";
            InitializeComponent();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Confirmed where Execution = '+'",connection);
            DataTable tab = new DataTable();
            tab.Load(command.ExecuteReader());
            bs.DataSource = tab.DefaultView;
            dataGridView1.DataSource = bs;

        }
    }
}

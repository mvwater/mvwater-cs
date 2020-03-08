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

namespace mvwater_netfw
{
    public partial class dbEstablishConnection : Form
    {
        public dbEstablishConnection()
        {
            InitializeComponent();
        }

        private void dbEstablishConnection_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //put code here to connect to database using provided information
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    public class estConnection
    {
        public void EstablishConnection(string serverName, string databaseName, string userName, string password)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=serverName;Initial Catalog=databaseName;User ID=UserName;Password=password";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection opened successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed to open!");
            }
        }
        public string FormConnectionString()
        {
            //grab the proper information from the form
            //declare applicable vars
            string serverType;
            string serverName;
            string UserName;
            string password;

            //fill the strings with form information
            serverType = "Microsoft SQL Server";
            serverName = "mvad-water";
            UserName = "mvwateradmin";
            password = "*THISISNOTAVALIDPASSWORDTHATCANBEUSEDHERE";

            //form the connection string
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=serverName;Initial Catalog=databaseName;User ID=UserName;Password=password";
            return connectionString;
        }
    }
}

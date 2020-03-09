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

            //detect what's inside of textBox3
            string settingsFile = string.Empty;
            settingsFile = formXmlDoc.Text;

            var readSettings = new parseXml();
            string[] settingsArray = new string[4];
            //settingsFile is the name of the file in the formXmlDoc element of the desktop software
            settingsArray = readSettings.settingsParser(settingsFile);

            //declare some variables for imos
            //shove that array information into individually manipulatable objects
            string databaseType = string.Empty;
            string serverName = string.Empty;
            string username = string.Empty;
            string password = string.Empty;

            databaseType = settingsArray[0];
            serverName = settingsArray[1];
            username = settingsArray[2];
            password = settingsArray[3];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //nothing to see here...
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
                string exceptionHumanReadable = string.Empty;
                exceptionHumanReadable = ex.ToString();
                MessageBox.Show("Connection failed to open!");
                MessageBox.Show(exceptionHumanReadable);
            }
        }
        public string FormConnectionString()
        {
            //grab the proper information from the form
            //declare applicable vars
            string serverType = string.Empty;
            string serverName = string.Empty;
            string UserName = string.Empty;
            string password = string.Empty;

            //fill the strings with form information
            serverType = "Microsoft SQL Server";
            serverName = "mvad-water";
            UserName = "mvwateradmin";
            password = "*THISISNOTAVALIDPASSWORDTHATCANBEUSEDHERE";

            //form the connection string
            string connectionString = null;
            //SqlConnection cnn;
            connectionString = "Data Source=serverName;Initial Catalog=databaseName;User ID=UserName;Password=password";
            return connectionString;
        }
    }
}

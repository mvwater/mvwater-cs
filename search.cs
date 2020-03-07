using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Assemblies;

namespace mvwater_netfw
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //put code here to search by provided information

            //grab the field entries from the form
            string searchType;
            string searchQuery;
            searchType = formSearchBy.Text;
            searchQuery = formSearchQuery.Text;

            //clean inputs for sql to use
            string sqlSearchType;
            string sqlSearchQuery;

            try
            {
                if (searchType == "Address")
                {
                    sqlSearchType = "address";
                }
                else if (searchType == "Account Number")
                {
                    sqlSearchType = "account";
                }
            }
            catch
            {
                //messageBox with error message
                string errorMessage = "Error 1: Invalid search query type.";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                //display the MessageBox
                result = MessageBox.Show(errorMessage, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }

            //construct the sql statements
            string Command = "SELECT * FROM account WHERE [sqlSearchType] = '[sqlSearchQuery]';";

            //retrieve the connection string
            var epsilon = new estConnection();
            epsilon.FormConnectionString();

            //apply the connection string to the pre-query script


            using (SqlConnection myConnection = new SqlConnection())
            {
                using (SqlDataAdapter myDataAdapter = new SqlDataAdapter(Command, myConnection))
                {
                    DataTable dtResult = new DataTable();
                    myDataAdapter.Fill(dtResult);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

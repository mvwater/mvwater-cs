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
    public partial class dbDropConnection : Form
    {
        public dbDropConnection()
        {
            InitializeComponent();
        }

        private void dbDropConnection_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            cnn = new SqlConnection(connectionString);
            cnn.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvwater_netfw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            var alpha = new Status1();
            alpha.mainStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newAboutBox = new AboutBox1();
            newAboutBox.Show();
        }

        private void establishConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbEstablishConnection newConnectionBox = new dbEstablishConnection();
            newConnectionBox.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            search newSearchBox = new search();
            newSearchBox.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            search newSearchBox = new search();
            newSearchBox.Show();
        }

        private void newSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search newSearchBox = new search();
            newSearchBox.Show();
        }

        private void dropConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbDropConnection newDroppedConn = new dbDropConnection();
            newDroppedConn.Show();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dbEstablishConnection newConnectionBox = new dbEstablishConnection();
            newConnectionBox.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            dbEstablishConnection newConnectionBox = new dbEstablishConnection();
            newConnectionBox.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dbDropConnection newDroppedConn = new dbDropConnection();
            newDroppedConn.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            dbDropConnection newDroppedConn = new dbDropConnection();
            newDroppedConn.Show();
        }
    }
}

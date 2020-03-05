using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvwatercs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void menu1ToolStripItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected MenuItem_1");
        }
    }
}

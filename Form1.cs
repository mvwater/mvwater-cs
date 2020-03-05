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

        public void CreateSimpleMenu()
        {
            //create a high level menu container
            MenuStrip strip = new MenuStrip();

            //create a top level menu item called "File"
            //let F be the access key
            //this is just a windows default YAY!
            ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");

            //create one sub menu item on this menu
            fileItem.DropDownItems.Add("First menu item");

            //create another sub menu item on that same meu
            fileItem.DropDownItems.Add("Second menu item");

            //add the high level menu item to the menu container
            strip.Items.Add(fileItem);

            //add menu to form
            this.Controls.Add(strip);

            InitializeComponent();
        }
        private void menu1ToolStripItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected MenuItem_1");
        }
    }
}

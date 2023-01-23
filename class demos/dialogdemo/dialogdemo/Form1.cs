using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogdemo
{
    public partial class MainForm : Form
    {
        private string boxtext = "";
        private Dialog myDialog = new Dialog();
        public MainForm()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            myDialog.userInput = boxtext;
    
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                boxtext = myDialog.userInput;
                label1.Text = boxtext;
                label1.Visible = true;

            }


        }
}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class SettingsDialog : Form
    {
        public int givenInteger;
        public int givenCount;
        public SettingsDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.inputInteger.Text = string.Empty;
            this.inputCount.Text = string.Empty;
            error.Visible = false;


        }

        private void OK_Click(object sender, EventArgs e)
        {


            int number = 0;
            int count = 0;
            try
            {
                number = Convert.ToInt32(inputInteger.Text);
                count = Convert.ToInt32(inputCount.Text);
             

                // Check if given integer is an integer, postive and within range
                // and  // Check if given count is an integer, postive and within range
                if ((number % 1 == 0 && number >= 0 && number <= 1000000000) && (count % 1 == 0 && count > 0 && count <= 100))
                {
                    this.DialogResult = DialogResult.OK;
                    givenInteger = number;
                    givenCount = count;
                    error.Visible = false;



                }
                else
                {
                    error.Visible = true;
                }

            }
            catch (FormatException fe)
            {


                error.Visible = true;
            }
            catch (OverflowException Oe)
            {


                error.Visible = true;
            }
        }

        
    }
}

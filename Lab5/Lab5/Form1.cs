using Lab5.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab5
{
    public partial class MainForm : Form
    {
        
        private SettingsDialog settings = new SettingsDialog();
        private DialogResult showDialogResult;

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        

        private bool isPalindrome(int n)
        {
            int remainder, reversed = 0, original;
            original = n;
            while(n  != 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n = n / 10;
            }

            if (original == reversed)
                return true;
            else
                return false;
        }
        private int[] getPalindromes(int number, int count)
        {
            int[] array = new int[count];
            int i = 0;
            while(i < count)
            {
                if(isPalindrome(number))
                {
                    array[i] = number;
                    i++;
                }
                    
              number++;
            
            }
            return array;
        }

        private void Generate_Click(object sender, EventArgs e)
        {

            showDialogResult = settings.ShowDialog();
            Console.WriteLine(showDialogResult.ToString());

            if (showDialogResult == DialogResult.OK)
            {
                listBox1.DataSource = getPalindromes(settings.givenInteger, settings.givenCount);

            }
            else if (showDialogResult == DialogResult.Cancel)
            {
                if (listBox1.DataSource != null)
                {
                    listBox1.DataSource = null;
                    listBox1.Items.Clear();
                }
            }

        }

       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab6

{

    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private bool ErroCheckFile(string key, string sourcePath, string destPath, string encryptionType)
        { 

            // Similar to both encrypt and decrypt
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a key.", "Error",
     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            else if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("Could not open a source or a destination file.", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return  true;
            }

            // Independent to decryption files
            if (encryptionType == "decrypt")
            {
                if (!sourcePath.Contains(".enc"))
                {
                    MessageBox.Show("Not a .enc file.", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return  true;
                }
            }

            else if (File.Exists(destPath))
            {
                if (MessageBox.Show("Output file exists. Overwrite?", "File Exists",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Invalidate(true);
                    return true;
                }
               
            }

            return false;
        }
        private void ApplyEncryption(string key, FileStream fin, FileStream fout)
        {

            int rbyte;
            int pos = 0;    //position in key string
            int length = key.Length; //length of key
            byte kbyte, ebyte; //encrypted byte

            while ((rbyte = fin.ReadByte()) != -1)
            {
                kbyte = (byte)key[pos];
                ebyte = (byte)(rbyte ^ kbyte);
                fout.WriteByte(ebyte);
                ++pos;
                if (pos == length)
                    pos = 0;
            }
        }
       private string RemoveExtenstion(string sourcePath, string extension)
        {
            int index = sourcePath.IndexOf(extension);
            string destPath = (index < 0)
                ? sourcePath
                : sourcePath.Remove(index, extension.Length);

            return destPath;
        }
        private void decrypt_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text;
            // Create destination path for decryption
            string destPath = RemoveExtenstion(filePathTextBox.Text, ".enc");
            string sourcePath = filePathTextBox.Text;
            if (!ErroCheckFile(key, sourcePath, destPath, "decrypt"))
            {
            
                try
                { 
                        Console.WriteLine("this is destPath" + destPath);
                       FileStream infile = new FileStream(filePathTextBox.Text, FileMode.Open);
                      FileStream  outfile = new FileStream(destPath, FileMode.Create);

                        
                        MessageBox.Show("Operation completed successfully.");
                        ApplyEncryption(key, infile, outfile);

                        if (infile != null) infile.Close();
                        if (outfile != null) outfile.Close();
            
                }
                catch(Exception ee)
                {
                  MessageBox.Show("Could not open a source or a destination file.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text;
            // Create a destination path for encryption
            string destPath = filePathTextBox.Text + ".enc";
            string sourcePath = filePathTextBox.Text;
            if (!ErroCheckFile(key,sourcePath , destPath, "encrypt"))
            {
              try
                {
                        FileStream infile = new FileStream(filePathTextBox.Text,
            FileMode.Open);
                       FileStream  outfile = new FileStream(destPath,
            FileMode.Create);

                        
                        MessageBox.Show("Operation completed successfully.");
                        ApplyEncryption(key, infile, outfile);

                        if (infile != null) infile.Close();
                        if (outfile != null) outfile.Close();
     
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Could not open a source or a destination file.", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                filePathTextBox.Text = openFileDialog1.FileName;
         

        }
    }
}

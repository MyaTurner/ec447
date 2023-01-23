using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Font myFont;
        private double result = 0;
        private string errorMessage = "Invalid or missing value!";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Cyan;
            this.Text = "Mya Turner - Lab3";
            myFont = new Font("Heisei Kaku Gothic W3", 30);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResizeRedraw = true;
            this.resultBox.ReadOnly = true;

            // Put textbox formating inside the form class, not the functions!!
            this.resultBox.TextAlign = HorizontalAlignment.Right;
            this.input.TextAlign = HorizontalAlignment.Right;
            this.resultBox.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Clear button
        private void button5_Click(object sender, EventArgs e)
        {
            result = 0;
            this.resultBox.Text = result.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Add
        private void button2_Click(object sender, EventArgs e)
        {
            double i = 0;
            try
            {
                i = Convert.ToDouble(input.Text);
                result += i;
                this.resultBox.Text = result.ToString();
                this.input.Text = string.Empty;
            }
            catch (FormatException fe)
            {
               
                MessageBox.Show(errorMessage);
            }
       
            
        }
        // Sub
        private void button1_Click(object sender, EventArgs e)
        {
            double i = 0;
            try
            {
                i = Convert.ToDouble(input.Text);
                result -= i;
                this.resultBox.Text = result.ToString();
                this.input.Text = string.Empty;
            }
            catch (FormatException fe)
            {

                MessageBox.Show(errorMessage);
            }
            

        }

        // Mul
        private void button3_Click(object sender, EventArgs e)
        {
            double i = 0;
            try
            {
                i = Convert.ToDouble(input.Text);
                result *= i;
                this.resultBox.Text = result.ToString();
                this.input.Text = string.Empty;
            }
            catch (FormatException fe)
            {

                MessageBox.Show(errorMessage);
            }
           

        }

        // Div
        private void button4_Click(object sender, EventArgs e)
        {
            double i = 0;
            try
            {
                i = Convert.ToDouble(input.Text);
                result /= i;
                this.resultBox.Text = result.ToString();
                this.input.Text = string.Empty;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(errorMessage);
            }
           

        }
    }
}

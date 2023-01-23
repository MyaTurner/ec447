using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Make sure to put panel first and then buttons!
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        // Use paint event NOT on paint event!!!
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            const int nLines = 100;
            Font font = new Font("Arial", 16);
            int cy = font.Height;
            panel1.Height = nLines * cy;
            Graphics g = e.Graphics;
            for (int i = 0; i < nLines; ++i)
                g.DrawString(i.ToString(), font, Brushes.Black,
                0, i * cy);
            font.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }
    }
}

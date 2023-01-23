using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        private bool showAlign = false;

        private int roundToNearest40(int num)
        {
         
            return ((int)Math.Round(num / 40.0)) * 40;
        }
        public Form1()
        {
            InitializeComponent();
        }

        // Make sure to add reference in properties tab on Form1.cs!
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            int GRID = 40;
            int x = GRID;
            int y = GRID;
             Graphics g = e.Graphics;
            while (x < ClientRectangle.Width)
            {
                g.DrawLine(Pens.Black, x, 0, x, ClientRectangle.Height);
                x += GRID;
            }
            while (y < ClientRectangle.Height)
            {
                g.DrawLine(Pens.Black, 0, y, ClientRectangle.Width, y);
                y += GRID;
            }

            const int WIDTH = 20;
            const int HEIGHT = 20;

            if (showAlign)
            {
                int newX;
                int newY;
                foreach (Point p in this.coordinates)
                {
                    newX = roundToNearest40(p.X);
                    newY = roundToNearest40(p.Y);

                    g.FillEllipse(Brushes.Red,
                    newX - WIDTH / 2, newY - WIDTH / 2,
                    WIDTH, HEIGHT);
                }
            }
            else
            {
                foreach (Point p in this.coordinates)
                {
                    g.FillEllipse(Brushes.Red,
                    p.X - WIDTH / 2, p.Y - WIDTH / 2,
                    WIDTH, HEIGHT);

                }
            }
 

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                this.coordinates.Add(p);
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                this.coordinates.Clear();
                this.Invalidate();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool showAlign = (button1.Tag as bool?) ?? true;
            //button1.Tag = !showAlign;


            button1.Text = showAlign ? "Align" : "Original";
            showAlign = !showAlign;
            this.Invalidate();

        }
    }
}

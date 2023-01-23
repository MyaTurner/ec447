using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTest1
{
    public partial class Form1 : Form
    {
        //dimensions
        private const float clientSize = 100;
        private const float lineLength = 80;
        private const float block = lineLength / 3;
        private const float offset = 10;
        private const float delta = 5;
        private enum CellSelection { N, O, X };
        private CellSelection[,] grid = new
        CellSelection[3, 3];
        private float scale; //current scale factor
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyTransform(g);
            //draw board
            g.DrawLine(Pens.Black, block, 0, block,
            lineLength);
            g.DrawLine(Pens.Black, 2 * block, 0, 2 * block,
            lineLength);
            g.DrawLine(Pens.Black, 0, block, lineLength,
            block);
            g.DrawLine(Pens.Black, 0, 2 * block, lineLength, 2 * block);
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (grid[i, j] == CellSelection.O)
                        DrawO(i, j, g);
                    else if (grid[i, j] == CellSelection.X) 
                        DrawX(i, j, g);
        }

        private void ApplyTransform(Graphics g)
        {
            scale = Math.Min(ClientRectangle.Width /
            clientSize, ClientRectangle.Height / clientSize);
            if (scale == 0f) return;
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(offset, offset);
        }
        private void DrawX(int i, int j, Graphics g)
        {
            g.DrawLine(Pens.Black, i * block + delta, j * block + delta,
(i * block) + block - delta, (j * block) + block - delta);
            g.DrawLine(Pens.Black, (i * block) + block - delta,
            j * block + delta, (i * block) + delta,
            (j * block) + block - delta);
        }
        private void DrawO(int i, int j, Graphics g)
        {
            g.DrawEllipse(Pens.Black, i * block + delta,
            j * block + delta,
            block - 2 * delta, block - 2 * delta);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

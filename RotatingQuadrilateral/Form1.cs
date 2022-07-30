using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotatingQuadrilateral
{
    public partial class Form1 : Form
    {        
        static readonly Pen pen = new Pen(Color.Black, 2);
        private Graphics g;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Draw(this.CreateGraphics());
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw(g);
        }

        public void Draw(Graphics g)
        {            
            int xStart = this.Width / 3;
            int yStart = this.Height / 3;

            g.Clear(Form1.DefaultBackColor);

            g.DrawLine(pen, xStart, yStart, xStart + 90, yStart - 15);
            g.DrawLine(pen, xStart + 90, yStart - 15, xStart + 100, yStart + 40);
            g.DrawLine(pen, xStart + 100, yStart + 40, xStart + 50, yStart + 65);
            g.DrawLine(pen, xStart + 50, yStart + 65, xStart, yStart);
        }
    }
}

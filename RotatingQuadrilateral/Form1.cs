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

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        public void Draw()
        {            
            int xStart = this.Width / 3;
            int yStart = this.Height / 3;            
            
            Graphics line1 = this.CreateGraphics();
            Graphics line2 = this.CreateGraphics();
            Graphics line3 = this.CreateGraphics();
            Graphics line4 = this.CreateGraphics();

            line1.Clear(Form1.DefaultBackColor);

            line1.DrawLine(pen, xStart, yStart, xStart + 90, yStart - 15);
            line2.DrawLine(pen, xStart + 90, yStart - 15, xStart + 100, yStart + 40);
            line3.DrawLine(pen, xStart + 100, yStart + 40, xStart + 50, yStart + 65);
            line4.DrawLine(pen, xStart + 50, yStart + 65, xStart, yStart);
        }
    }
}

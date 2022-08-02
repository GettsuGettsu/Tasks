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
        private PointF circleTopLeft;
        private PointF circleCenter;
        private PointF pointA;
        private PointF pointB;
        private PointF pointC;
        private PointF pointD;

        private readonly float radius = 50;
        private float angle1 = 7;
        private float angle2 = 107;
        private float angle3 = 190;
        private float angle4 = 208;
        private float rotationAngle = 2;

        private bool isRotate;

        private static readonly Pen pen = new Pen(Color.Black, 1.5f);

        public Form1()
        {
            InitializeComponent();

            InitializePoints(angle1, angle2, angle3, angle4);            
                        
            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
            this.Resize += Form1_Resize;
            this.MouseDoubleClick += Form1_MouseDoubleClick;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isRotate = false;
            //throw new NotImplementedException();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            InitializePoints(angle1, angle2, angle3, angle4);
            Draw(this.CreateGraphics());
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int iteration = 0;
            isRotate = true;
            
            //
            //
            // must be rewritten!!!!
            //
            //
            while (isRotate)
            {
                angle1 += rotationAngle;
                angle2 += rotationAngle;
                angle3 += rotationAngle;
                angle4 += rotationAngle;
                InitializePoints(angle1 % 360, angle2 % 360, angle3 % 360, angle4 % 360);
                Draw(this.CreateGraphics());
                System.Threading.Thread.Sleep(16);

                iteration++;
                if (iteration % 10000 == 0)
                {
                    iteration = 0;
                    GC.Collect();
                }
            }
            // end
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        {
            g.Clear(Form1.DefaultBackColor);

            g.DrawLine(pen, pointA, pointB);
            g.DrawLine(pen, pointB, pointC);
            g.DrawLine(pen, pointC, pointD);
            g.DrawLine(pen, pointD, pointA);
        }

        private void InitializePoints(float angle1, float angle2, float angle3, float angle4)
        {
            circleTopLeft = new PointF(this.Width / 4, this.Height / 2 - this.Height / 4);
            circleCenter = new PointF(circleTopLeft.X + radius, circleTopLeft.Y + radius);

            //if ((angle1 + angle3 < 180 && angle1 != 0 && angle3 != 0) || (angle2 + angle4 < 180 && angle2 != 0 && angle4 != 0))
            //{
            //    MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Close();
            //}
            pointA = GetPoint(angle1);
            pointB = GetPoint(angle2);
            pointC = GetPoint(angle3);
            pointD = GetPoint(angle4);
        }

        private PointF GetPoint(float degree)
        {
            float x = (float)(circleCenter.X + radius * Math.Round(Math.Cos(ConvertToRadian(degree)), 5));
            float y = (float)(circleCenter.Y + radius * Math.Round(Math.Sin(ConvertToRadian(degree)), 5));

            return new PointF(x, y);
        }

        private float LineLength(PointF point1, PointF point2)
        {
            float x = point2.X - point1.X;
            float y = point2.Y - point1.Y;
            float length = (float)Math.Sqrt(x * x + y * y);

            return length;
        }

        private static float ConvertToRadian(float degree)
        {
            return (float)(degree * Math.PI / 180);
        }
    }
}

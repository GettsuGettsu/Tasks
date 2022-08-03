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
        private BackgroundWorker backgroundWorker1;
        private Label label1 = new Label();
        private Button button1 = new Button();

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

        private bool startRotate = true;

        private static readonly Pen pen = new Pen(Color.Black, 1.5f);

        public Form1()
        {
            InitializeComponent();

            label1.Text = "Click on form to start/stop rotating.";
            label1.Font = new Font("Arial", 14f);
            label1.Width = TextRenderer.MeasureText(label1.Text, label1.Font).Width + 3;
            label1.Location = new Point((this.Width - label1.Width) / 2, 5);

            button1.Text = "Change direcrion";
            button1.Font = new Font("Arial", 10f);
            button1.Width = TextRenderer.MeasureText(button1.Text, button1.Font).Width + 13;
            button1.Height = TextRenderer.MeasureText(button1.Text, button1.Font).Height + 13;
            button1.Location = new Point(5, this.Height - button1.Height - 45);
            button1.Click += Button1_Click;

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;

            InitializePoints(angle1, angle2, angle3, angle4);
                        
            this.Paint += Form1_Paint;
            this.Resize += Form1_Resize;
            this.MouseClick += Form1_MouseClick;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            this.Controls.Add(label1);
            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rotationAngle *= -1;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int iteration = 0;            

            while (!startRotate)
            {
                angle1 = ToCircleDegrees(angle1 - rotationAngle);
                angle2 = ToCircleDegrees(angle2 - rotationAngle);
                angle3 = ToCircleDegrees(angle3 - rotationAngle);
                angle4 = ToCircleDegrees(angle4 - rotationAngle);

                InitializePoints(angle1, angle2, angle3, angle4);
                Draw(this.CreateGraphics());

                System.Threading.Thread.Sleep(16);

                iteration++;
                if (iteration % 10000 == 0)
                {
                    iteration = 0;
                    GC.Collect();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point((this.Width - label1.Width) / 2, 3);
            button1.Location = new Point(5, this.Height - button1.Height - 45);

            InitializePoints(angle1, angle2, angle3, angle4);
            
            if (startRotate)
                Draw(this.CreateGraphics());
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (startRotate)
            {
                startRotate = false;
                backgroundWorker1.RunWorkerAsync();
            }
            else startRotate = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        {
            g.Clear(Form1.DefaultBackColor);

            try
            {
                g.DrawLine(pen, pointA, pointB);
                g.DrawLine(pen, pointB, pointC);
                g.DrawLine(pen, pointC, pointD);
                g.DrawLine(pen, pointD, pointA);
            }
            catch { }
        }

        private bool InitializePoints(float angle1, float angle2, float angle3, float angle4)
        {
            circleTopLeft = new PointF(this.Width / 2 - radius, this.Height / 2 - radius);
            circleCenter = new PointF(circleTopLeft.X + radius, circleTopLeft.Y + radius);

            pointA = GetPoint(angle1);
            pointB = GetPoint(angle2);
            pointC = GetPoint(angle3);
            pointD = GetPoint(angle4);

            return true;
        }

        private PointF GetPoint(float degree)
        {
            float x = (float)(circleCenter.X + radius * Math.Round(Math.Cos(ConvertToRadian(-degree)), 5));
            float y = (float)(circleCenter.Y + radius * Math.Round(Math.Sin(ConvertToRadian(-degree)), 5));

            return new PointF(x, y);
        }

        //private float LineLength(PointF point1, PointF point2)
        //{
        //    float x = point2.X - point1.X;
        //    float y = point2.Y - point1.Y;
        //    float length = (float)Math.Sqrt(x * x + y * y);

        //    return length;
        //}

        private static float ToCircleDegrees(float angle)
        {
            return angle % 360;
        }

        private static float ConvertToRadian(float degree)
        {
            return (float)(degree * Math.PI / 180);
        }
    }
}

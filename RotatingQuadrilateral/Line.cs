using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingQuadrilateral
{
    public class Line
    {
        #region Fields
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        #endregion

        #region Properties
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        #endregion

        #region Methods
        private void DrawLine()
        {
            //Pen pen = new Pen(Color.Black, 2);
            //Graphics g = this.CreateGraphics();            

            //g.DrawLine(pen, X1, Y1, X2, Y2);
        }
        #endregion
    }
}

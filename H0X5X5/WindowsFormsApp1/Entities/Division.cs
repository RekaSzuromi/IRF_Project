using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Abstractions;

namespace WindowsFormsApp1.Entities
{
    public class Division : Operations
    {
        public override void DrawImage(Graphics g)
        {
            //ELLIPSE1
            // Create location and size of ellipse.
            int x1 = 40;
            int y1 = 5;

            // Fill  first ellipse on screen.
            g.FillEllipse(new SolidBrush(BackColor), x1, y1, Width, Height);

            //RECTANGLE
            // Create rectangle.
            Rectangle rect = new Rectangle(20, 30, 60, 15);

            // Draw rectangle to screen.
            g.FillRectangle((new SolidBrush(BackColor)), rect);

            //ELLIPSE2
            // Create location and size of ellipse.
            int x2 = 40;
            int y2 = 50;

            // Fill second ellipse on screen.
            g.FillEllipse(new SolidBrush(BackColor), x2, y2, Width, Height);

        }
    }
}

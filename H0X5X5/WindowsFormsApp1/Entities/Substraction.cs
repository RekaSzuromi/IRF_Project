using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Abstractions;

namespace WindowsFormsApp1.Entities
{
    public class Substraction : Operations
    {
        public override void DrawImage(Graphics g)
        {
            //RECTANGLE
            // Create rectangle.
            Rectangle rect = new Rectangle(400, 30, 60, 15);

            // Draw rectangle to screen.
            g.FillRectangle((new SolidBrush(Color.Green)), rect);
        }
    }
}

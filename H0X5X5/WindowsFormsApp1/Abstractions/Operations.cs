using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Abstractions
{
    public abstract class Operations : Label
    {
        public Operations()
        {
            AutoSize = false;
            Width = 20;
            Height = 20;
            BackColor = Color.Green;
            


        }

        private void Operations_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        public abstract void DrawImage(Graphics g);
    }
}

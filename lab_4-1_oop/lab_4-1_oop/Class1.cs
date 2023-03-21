using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_1_oop
{
    internal class Circle
    {
        private int x { get; set; }
        private int y { get; set; }

        public bool isSelected = false;

        private int diametr;

        public Circle(int x, int y, int diametr) { this.x = x; this.y = y; this.diametr = diametr; }

        public void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isSelected)
            {
                g.DrawEllipse(new Pen(Color.Black), x - diametr / 2, y - diametr / 2, this.diametr, this.diametr);
            }
            else
            {
                g.DrawEllipse(new Pen(Color.Red), x - diametr / 2, y - diametr / 2, this.diametr, this.diametr);
            }
        }

        public bool isInArea(int X, int Y)
        {
            if (Math.Sqrt(Math.Pow(Math.Abs(this.x - X), 2) + Math.Pow(Math.Abs(this.y - Y), 2)) < this.diametr / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

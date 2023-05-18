using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Figures
{
    internal class Circle : Figure
    {
        public Circle(int x, int y, Color color, int size) : base(x, y, color, size) {}

        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isSelected)
            {
                g.FillEllipse(new SolidBrush(color), x - size / 2, y - size / 2, this.size, this.size);
                g.DrawEllipse(new Pen(Color.Black, 3), x - size / 2, y - size / 2, this.size, this.size);
                
            }
            else
            {
                g.FillEllipse(new SolidBrush(color), x - size / 2, y - size / 2, this.size, this.size);
            }
        }

        public override bool isInArea(int X, int Y)
        {
            if (Math.Sqrt(Math.Pow(Math.Abs(this.x - X), 2) + Math.Pow(Math.Abs(this.y - Y), 2)) < this.size / 2)
            {
                return true;
            }
            return false;
        }

        public override bool isAvailableLocation(int size, int w, int h, int dx, int dy)
        {
            if (this.y + size / 2 + dy <= h && this.y - size / 2 + dy >= 55 && this.x + size / 2 + dx < w && this.x - size / 2 + dx > 0)
            {
                return true;
            }
            return false;
        }
    }
}

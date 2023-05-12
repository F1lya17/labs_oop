using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Figures
{
    internal class Square : Figure
    {
        public Square(int x, int y, Color color, int size) : base(x, y, color, size) { }

        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isSelected)
            {
                g.FillRectangle(Brushes.Red, x - size / 2, y - size / 2, size, size);
                g.DrawRectangle(new Pen(Color.Black), x - size / 2, y - size / 2, this.size, this.size);
            }
            else
            {
                g.FillRectangle(new SolidBrush(color), x - size / 2, y - size / 2, size, size);
            }
        }

        public override bool isInArea(int X, int Y)
        {
            if (this.x - size / 2 <= X && X <= this.x + size / 2 && this.y - size / 2 <= Y && Y <= this.y + size / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool isAvailableMoveX(int w, char s)
        {
            if (s == 'd' && this.x + this.size / 2 + 4 < w)
            {
                return true;
            }
            else if (s == 'a' && this.x - this.size / 2 - 4 > 0)
            {
                return true;
            }
            else if (s == 'w' || s == 's')
            {
                return true;
            }
            return false;
        }

        public override bool isAvailableMoveY(int h, char s)
        {
            if (s == 's' && this.y + this.size / 2 + 4 < h)
            {
                return true;
            }
            else if (s == 'w' && this.y - this.size / 2 - 4 >= 55)
            {
                return true;
            }
            else if (s == 'a' || s == 'd')
            {
                return true;
            }
            return false;
        }
    }
}

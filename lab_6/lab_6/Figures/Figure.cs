using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Figures
{
    internal abstract class Figure
    {
        public int x;
        public int y;
        public Color color;

        public bool isSelected = false;

        public int size = 50;

        public Figure(int x, int y, Color color, int size) { this.x = x; this.y = y; this.color = color; this.size = size; }
        abstract public void draw(PaintEventArgs e);
        abstract public bool isInArea(int X, int Y);
        abstract public bool isAvailableMoveX(int w, char s);
        abstract public bool isAvailableMoveY(int h, char s);
        public void move(int dx, int dy, int w, int h, char s)
        {
            if (isAvailableMoveX(w, s) && isAvailableMoveY(h, s))
            {
                this.x += dx;
                this.y += dy;
            };
        }
    }
}

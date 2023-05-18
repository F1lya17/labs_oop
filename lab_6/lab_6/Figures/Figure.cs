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
        abstract public bool isAvailableLocation(int size, int w, int h, int dx, int dy);
        public void ScaleChange(int newSize)
        {
            this.size = newSize;
        }
        public void ColorChange(Color newColor)
        {
            this.color = newColor;
        }
        public void SelectChange(bool isSelec)
        {
            this.isSelected = isSelec;
        }
        public void move(int dx, int dy, int w, int h)
        {
            if (isAvailableLocation(this.size, w, h, dx, dy))
            {
                this.x += dx;
                this.y += dy;
            };
        }
    }
}

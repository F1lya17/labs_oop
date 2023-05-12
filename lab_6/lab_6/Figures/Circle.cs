﻿using System;
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
                g.FillEllipse(Brushes.Red, x - size / 2, y - size / 2, this.size, this.size);
                g.DrawEllipse(new Pen(Color.Black), x - size / 2, y - size / 2, this.size, this.size);
                
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

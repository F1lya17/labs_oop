using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Figures
{
    internal class Triangle : Figure
    {
        private float radius;
        private Point point1;
        private Point point2;
        private Point point3;

        public Triangle(int x, int y, Color color, int size) : base(x, y, color, size)
        {
            radius = (float)(size / Math.Sqrt(3));
            this.point1 = new Point(this.x, (int)(this.y - this.radius));
            this.point2 = new Point((int)(this.x + this.size * 0.5), (int)(this.y + this.radius * 0.5));
            this.point3 = new Point((int)(this.x - this.size * 0.5), (int)(this.y + this.radius * 0.5));
        }

        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            point1 = new Point(this.x, (int)(this.y - this.radius));
            point2 = new Point((int)(this.x + this.size * 0.5), (int)(this.y + this.radius * 0.5));
            point3 = new Point((int)(this.x - this.size * 0.5), (int)(this.y + this.radius * 0.5));
            if (isSelected)
            {
                g.FillPolygon(Brushes.Red, new[] { point1, point2, point3, point1 });
                g.DrawLines(new Pen(Color.Black, 3), new[] { point1, point2, point3, point1 });
            }
            else
            {
                g.FillPolygon(new SolidBrush(color), new[] { point1, point2, point3, point1 });
            }
        }

        public override bool isInArea(int X, int Y)
        {
            if ((point1.X - X) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - Y) >= 0 &&
                (point2.X - X) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - Y) >= 0 &&
                (point3.X - X) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - Y) >= 0)
            {
                return true;
            }
            if ((point1.X - X) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - Y) < 0 &&
                (point2.X - X) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - Y) < 0 &&
                (point3.X - X) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - Y) < 0)
            {
                return true;
            }
            return false;
        }
        public override bool isAvailableMoveX(int w, char s)
        {
            if (s == 'd' && point2.X + 4 < w)
            {
                return true;
            }
            else if (s == 'a' && point3.X - 4 > 0)
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
            if (s == 's' && point3.Y + 4 < h)
            {
                return true;
            }
            else if (s == 'w' && point1.Y - 4 >= 55)
            {
                return true;
            }
            else if (s == 'a' || s == 'd')
            {
                return true;
            }
            return false;
        }
        public override void ScaleChange(int newSize)
        {
            this.size = newSize;
        }

        public override void ColorChange(Color newColor)
        {
            this.color = newColor;
        }
        public override void SelectChange(bool isSelec)
        {
            this.isSelected = isSelec;
        }

        public override bool isAvailableLocation(int size, int w, int h)
        {
            if (point2.X <= w && point3.X >= 0 && point3.Y <= h && point1.Y >= 55)
            {
                return true;
            }
            return false;
        }
    }
}

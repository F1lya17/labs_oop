using lab_6.factory;
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
                g.FillPolygon(new SolidBrush(color), new[] { point1, point2, point3, point1 });
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
        public override void move(int dx, int dy, int w, int h)
        {
            if (isAvailableLocation(this.size, w, h, dx, dy))
            {
                this.x += dx;
                this.y += dy;
            };
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

        public override bool isAvailableLocation(int size, int w, int h, int dx, int dy)
        {
            if (point2.X + dx <= w && point3.X + dx >= 0 && point3.Y + dy <= h && point1.Y + dy >= 55)
            {
                return true;
            }
            return false;
        }
        public override void save(StreamWriter sw)
        {
            sw.WriteLine("T" + "\n" + x + "\n" + y + "\n" + color.ToArgb() + "\n" + size + "\n" + this.isSelected);
        }
        public override void load(StreamReader sw, FigureFactory factory)
        {
            int x = int.Parse(sw.ReadLine());
            int y = int.Parse(sw.ReadLine());
            Color color = Color.FromArgb(int.Parse(sw.ReadLine()));
            int size = int.Parse(sw.ReadLine());
            string isSelectedString = sw.ReadLine();
            bool isSelected;
            if (isSelectedString == "True")
            {
                isSelected = true;
            }
            else
            {
                isSelected = false;
            }
            this.x = x;
            this.y = y;
            this.color = color;
            this.size = size;
            this.isSelected = isSelected;
        }
    }
}

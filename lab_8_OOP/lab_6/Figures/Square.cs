using lab_6.factory;
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
        public Square(int x, int y, Color color, int size) : base(x, y, color, size) { name = "Square"; }

        public override void draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isSelected)
            {
                g.FillRectangle(new SolidBrush(color), x - size / 2, y - size / 2, size, size);
                g.DrawRectangle(new Pen(Color.Black, 3), x - size / 2, y - size / 2, this.size, this.size);
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
        public override void move(int dx, int dy, int w, int h)
        {
            if (isAvailableLocation(this.size, w, h, dx, dy))
            {
                this.x += dx;
                this.y += dy;
                notifyEveryone();
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
            if (this.y + size / 2 + dy <= h && this.y - size / 2 + dy >= 55 && this.x + size / 2 + dx < w && this.x - size / 2 + dx > 192)
            {
                return true;
            }
            return false;
        }
        public override void save(StreamWriter sw)
        {
            sw.WriteLine("S" + "\n" + x + "\n" + y + "\n" + color.ToArgb() + "\n" + size + "\n" + this.isSelected);
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

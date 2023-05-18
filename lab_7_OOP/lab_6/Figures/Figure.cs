using lab_6.factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        abstract public void ScaleChange(int newSize);
        abstract public void ColorChange(Color newColor);
        abstract public void SelectChange(bool isSelec);
        abstract public bool isAvailableLocation(int size, int w, int h, int dx, int dy);
        abstract public void move(int dx, int dy, int w, int h);
        abstract public void load(StreamReader sw, FigureFactory factory);
        abstract public void save(StreamWriter sw);
    }
}

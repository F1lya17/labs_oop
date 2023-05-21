using lab_6.factory;
using lab_6.Observers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.Figures
{
    internal abstract class Figure : CObject
    {
        List<CObserver> observers = new List<CObserver>();
        public int x;
        public int y;
        public Color color;
        public string name;

        public bool isSelected = false;

        public int size = 50;
        public void AddObserver(CObserver obj)
        {
            observers.Add(obj);
        }

        public void notifyEveryone()
        {
            foreach (CObserver obs in observers)
            {
                obs.onSubjectChanged(this);
            }
        }

        public Figure(int x, int y, Color color, int size) { this.x = x; this.y = y; this.color = color; this.size = size; }
        abstract public void draw(PaintEventArgs e);
        abstract public bool isInArea(int X, int Y);
        abstract public void ScaleChange(int newSize);
        abstract public void ColorChange(Color newColor);
        abstract public void SelectChange(bool isSelec);
        abstract public bool isAvailableLocation(int size, int w, int h, int dx, int dy);
        abstract public void move(int dx, int dy, int w = 800, int h = 451);
        abstract public void load(StreamReader sw, FigureFactory factory);
        abstract public void save(StreamWriter sw);
    }
}

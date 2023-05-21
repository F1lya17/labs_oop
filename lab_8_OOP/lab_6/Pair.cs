using lab_6.Figures;
using lab_6.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Pair : CObserver
    {
        public Point first;
        public Figure second;
        public Pair(Point first, Figure second)
        {
            this.first = first;
            this.second = second;
        }
        public void onSubjectChanged(CObject o)
        {
            Figure f = o as Figure;
            if (f != null)
            {
                int dx = f.x - first.X;
                int dy = f.y - first.Y;
                first.X += dx;
                first.Y += dy;
                second.move(dx, dy);
            }
        }
    }
}

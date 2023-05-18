using lab_6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.factory
{
    internal class MyFigureFactory : FigureFactory
    {
        public override Figure createFigure(string code)
        {
            Figure f = null;
            switch (code)
            {
                case "C":
                    f = new Circle(0, 0, Color.Red, 50);
                    break;
                case "S":
                    f = new Square(0, 0, Color.Red, 50);
                    break;
                case "T":
                    f = new Triangle(0, 0, Color.Red, 50);
                    break;
                case "G":
                    f = new FGroup(0, 0, Color.Red, 50);
                    break;
                default: break;
            }
            return f;
        }
    }
}

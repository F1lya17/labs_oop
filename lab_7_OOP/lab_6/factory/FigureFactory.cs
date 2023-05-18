using System;
using lab_6.Figures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6.factory
{
    internal abstract class FigureFactory
    {
        abstract public Figure createFigure(string code);
    }
}

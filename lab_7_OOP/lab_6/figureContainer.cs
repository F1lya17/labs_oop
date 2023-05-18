using lab_6.factory;
using lab_6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class figureContainer: Mycontainer<Figure>
    {
        public void loadFigures(string filename, FigureFactory factory)
        {
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            int count = int.Parse(line);
            for (int i = 0; i < count; i++)
            {
                string s = sr.ReadLine();
                Figure figure = factory.createFigure(s);
                if (figure != null)
                {
                    figure.load(sr, factory);
                    this.pushBack(figure);
                }
            }
            sr.Close();
        }
    }
}

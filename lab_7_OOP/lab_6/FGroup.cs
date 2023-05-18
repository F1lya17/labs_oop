using lab_6.Figures;
using lab_6.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class FGroup : Figure
    {
        public Mycontainer<Figure> figuresGroup = new Mycontainer<Figure>();
        public FGroup(int x, int y, Color color, int size) : base(x, y, color, size) { }

        public void addFigure(Figure f)
        {
            figuresGroup.pushBack(f);
        }
        public override void draw(PaintEventArgs e)
        {
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                figuresGroup[i].draw(e);
            }
        }

        public override void move(int dx, int dy, int w, int h)
        {
            if (isAvailableLocation(this.size, w, h, dx, dy))
            {
                for (int i = 0; i < figuresGroup.Count; i++)
                {
                    figuresGroup[i].move(dx, dy, w, h);
                }
            }
        }

        public override bool isInArea(int X, int Y)
        {
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                if (figuresGroup[i].isInArea(X, Y))
                {
                    return true;
                }
            }
            return false;
        }
        public override void ScaleChange(int newSize)
        {
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                figuresGroup[i].ScaleChange(newSize);
            }
        }

        public override void ColorChange(Color newColor)
        {
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                figuresGroup[i].ColorChange(newColor);
            }
        }
        public override void SelectChange(bool isSelec)
        {
            this.isSelected = isSelec;
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                figuresGroup[i].SelectChange(isSelec);
            }
        }
        public override bool isAvailableLocation(int size, int w, int h, int dx, int dy)
        {
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                if (!figuresGroup[i].isAvailableLocation(size, w, h, dx, dy))
                {
                    return false;
                }
            }
            return true;
        }

        public override void save(StreamWriter sw)
        {
            sw.WriteLine("G" + "\n" + figuresGroup.Count + "\n" + this.isSelected);
            for (int i = 0; i < figuresGroup.Count; i++)
            {
                figuresGroup[i].save(sw);
            }
        }
        public override void load(StreamReader sw, FigureFactory factory)
        {
            int count = int.Parse(sw.ReadLine());
            string isSelectedString = sw.ReadLine();
            this.isSelected = isSelectedString == "True";
            for (int i = 0; i < count; i++)
            {
                string s = sw.ReadLine();
                Figure figure = factory.createFigure(s);
                if (figure != null)
                {
                    figure.load(sw, factory);
                    this.addFigure(figure);
                }
            }
        }
    }
}

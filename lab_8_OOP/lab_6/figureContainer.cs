using lab_6.factory;
using lab_6.Figures;
using lab_6.Observers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_6
{
    internal class figureContainer: Mycontainer<Figure>, CObject, CObserver
    {
        List<CObserver> observers;
        public figureContainer(): base()
        {
            observers = new List<CObserver>();
        }
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
        public void onSubjectChanged(CObject o)
        {
            for (int i = 0; i < this.Count; ++i)
            {
                this[i].isSelected = false;
            }
            tree tmp = (tree)o;
            for (int i = 0; i < this.Count; ++i)
            {
                if (tmp.treeView.Nodes[i].Checked == true)
                {
                    this[i].SelectChange(true);
                }
                else
                {
                    this[i].SelectChange(false);
                }
            }
        }
    }
}

using lab_6.factory;
using lab_6.Figures;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        bool isCtrlPressed = false;
        string figure = "Круг";
        Color colorFill = Color.Blue;
        int figureSize = 50;
        FigureFactory fact;
        string filename = "";
        tree treeHandler;
        Figure[] pairFigure = new Figure[2];
        List<Pair> drawLines = new List<Pair>();
        public Form1()
        {
            InitializeComponent();
            circleItem.Checked = true;
            treeHandler = new tree(treeView1);
            fact = new MyFigureFactory();

            container.AddObserver(treeHandler);
            treeHandler.AddObserver(container);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isInArea(e.X, e.Y))
                    {
                        container[i].SelectChange(true);
                        for (int j = 0; j < container.Count; j++)
                        {
                            if (j != i)
                            {
                                container[j].SelectChange(false);
                            }
                        }
                        container.notifyEveryone();
                        if (pairFigure[0] == null)
                        {
                            pairFigure[0] = container[i];
                        }
                        else if (pairFigure[0] == container[i])
                        {
                            pairFigure[0] = null;
                        }
                        else
                        {
                            bool isDeleteLine = false;
                            pairFigure[1] = container[i];
                            Point point1 = new Point(pairFigure[0].x, pairFigure[0].y);
                            FGroup f1 = pairFigure[0] as FGroup;
                            if (f1 != null)
                            {
                                point1 = new Point(f1.figuresGroup[0].x, f1.figuresGroup[0].y);
                            }
                            
                            Point point2 = new Point(pairFigure[1].x, pairFigure[1].y);
                            FGroup f2 = pairFigure[0] as FGroup;
                            if (f2 != null)
                            {
                                point2 = new Point(f2.figuresGroup[1].x, f2.figuresGroup[1].y);
                            }
                            for (int j = 0; j < drawLines.Count; j++)
                            {
                                if (drawLines[j].first == point1 && drawLines[j].second == pairFigure[1] || drawLines[j].first == point2 && drawLines[j].second == pairFigure[0])
                                {
                                    drawLines.RemoveAt(j);
                                    isDeleteLine = true;
                                }
                            }
                            if (!isDeleteLine)
                            {
                                drawLines.Add(new Pair(point1, pairFigure[1]));
                                if (f1 != null)
                                {
                                    f1.figuresGroup[0].AddObserver(drawLines[drawLines.Count - 1]);
                                }
                                else
                                {
                                    pairFigure[0].AddObserver(drawLines[drawLines.Count - 1]);
                                }
                            }
                            pairFigure[0] = null;
                            pairFigure[1] = null;
                        }
                        this.Refresh();
                        return;
                    }
                }
            }
            bool isNew = true;
            pairFigure[0] = null;
            pairFigure[1] = null;
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isInArea(e.X, e.Y))
                {
                    container[i].SelectChange(true);
                    for (int j = 0; j < container.Count; j++)
                    {
                        if (j != i && !isCtrlPressed)
                        {
                            container[j].SelectChange(false);
                        }
                    }
                    container.notifyEveryone();
                    this.Refresh();
                    return;
                }
            }
            
            if (figure == "Круг")
            {
                Circle c = new Circle(e.X, e.Y, colorFill, figureSize);
                if (c.isAvailableLocation(figureSize, this.ClientSize.Width, this.ClientSize.Height, 0, 0))
                {
                    container.pushBack(c);
                }
            }
            else if (figure == "Квадрат")
            {
                Square s = new Square(e.X, e.Y, colorFill, figureSize);
                if (s.isAvailableLocation(figureSize, this.ClientSize.Width, this.ClientSize.Height, 0, 0))
                {
                    container.pushBack(s);
                }
            }
            else if (figure == "Треугольник")
            {
                Triangle t = new Triangle(e.X, e.Y, colorFill, figureSize);
                if (t.isAvailableLocation(figureSize, this.ClientSize.Width, this.ClientSize.Height, 0, 0))
                {
                    container.pushBack(t);
                }
            }


            if (container.Count == 1)
            {
                container[0].SelectChange(true);
            }
            container.notifyEveryone();
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < container.Count; i++)
            {
                container[i].draw(e);
            }
            for (int i = 0; i < drawLines.Count; i++)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(Color.Black, 2); 
                pen.CustomEndCap = new AdjustableArrowCap(6, 6);
                g.DrawLine(pen, drawLines[i].first, new Point(drawLines[i].second.x, drawLines[i].second.y));
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        for (int j = 0; j < drawLines.Count;j++)
                        {
                            if (container[i] == drawLines[j].second || new Point(container[i].x, container[i].y) == drawLines[j].first)
                            {
                                drawLines.RemoveAt(j);
                                j--;
                            }
                        }
                        container.remove(i);
                        i--;
                    }
                }
                if (container.Count > 0)
                {
                    container[0].SelectChange(true);
                }
                container.notifyEveryone();
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlPressed = true;
                
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(0, -5, this.ClientSize.Width, this.ClientSize.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(0, 5, this.ClientSize.Width, this.ClientSize.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.A)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(-5, 0, this.ClientSize.Width, this.ClientSize.Height);
                    }
                }
            }
            if (e.KeyCode == Keys.D)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(5, 0, this.ClientSize.Width, this.ClientSize.Height);
                    }
                }
            }
            this.Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlPressed = false;
            }
        }

        private void sizeBar_ValueChanged(object sender, EventArgs e)
        {
            figureSize = sizeBar.Value;
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isSelected)
                {
                    if (container[i].isAvailableLocation(figureSize, this.ClientSize.Width, this.ClientSize.Height, 0, 0))
                    {
                        container[i].ScaleChange(figureSize);
                    }
                }
            }
            this.Refresh();
        }

        private void circleItem_Click(object sender, EventArgs e)
        {
            circleItem.Checked = true;
            squareItem.Checked = false;
            triangleItem.Checked = false;
            figure = "Круг";
        }

        private void triangleItem_Click(object sender, EventArgs e)
        {
            circleItem.Checked = false;
            squareItem.Checked = false;
            triangleItem.Checked = true;
            figure = "Треугольник";
        }

        private void squareItem_Click(object sender, EventArgs e)
        {
            circleItem.Checked = false;
            squareItem.Checked = true;
            triangleItem.Checked = false;
            figure = "Квадрат";
        }

        private void chColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorDialog1.FullOpen = true;
                colorFill = colorDialog1.Color;
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].ColorChange(colorFill);
                    }
                }
                this.Refresh();
            }
        }

        private void group_Click(object sender, EventArgs e)
        {
            FGroup g = new FGroup(0, 0, colorFill, figureSize);
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isSelected)
                {
                    g.addFigure(container[i]);
                    container.remove(i);
                    i--;
                }
            }
            g.isSelected = true;
            container.pushBack(g);
            container.notifyEveryone();
        }

        private void ungroup_Click(object sender, EventArgs e)
        {
            int length = container.Count;
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isSelected)
                {
                    FGroup? g = container[i] as FGroup;
                    if (g != null)
                    {
                        for (int j = 0; j < g.figuresGroup.Count; j++)
                        {
                            container.pushFront(g.figuresGroup[j]);
                            i++;
                        }
                        container.remove(i);
                        i--;
                    }
                }
            }
            container.notifyEveryone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                container.loadFigures(filename, fact);
                this.Refresh();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(container.Count);
                for (int i = 0; i < container.Count; i++)
                {
                    container[i].save(sw);
                }
                sw.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                foreach (TreeNode tn in treeHandler.treeView.Nodes)
                {
                    recursiveDiselect(tn);
                }
                TreeNode tmp = e.Node;
                while (tmp.Parent != null)
                {
                    tmp = tmp.Parent;
                }
                tmp.Checked = true;
                recursiveSelect(tmp);
                treeHandler.notifyEveryone();
            }
            this.Refresh();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                foreach (TreeNode tn in treeHandler.treeView.Nodes)
                {
                    recursiveDiselect(tn);
                }
                TreeNode tmp = e.Node;
                while (tmp.Parent != null)
                {
                    tmp = tmp.Parent;
                }
                tmp.Checked = true;
                recursiveSelect(tmp);
                treeHandler.notifyEveryone();
            }
            this.Refresh();
        }

        private void recursiveDiselect(TreeNode treeNode)
        {
            treeNode.Checked = false;
            foreach (TreeNode tn in treeNode.Nodes)
            {
                recursiveDiselect(tn);
            }
        }

        private void recursiveSelect(TreeNode treeNode)
        {
            treeNode.Checked = true;
            foreach (TreeNode tn in treeNode.Nodes)
            {
                recursiveSelect(tn);
            }
        }
    }
}
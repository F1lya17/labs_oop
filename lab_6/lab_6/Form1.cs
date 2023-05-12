using lab_6.Figures;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        bool isCtrlPressed = false;
        bool isCtrlAvailable = false;
        string figure = "Круг";
        Color colorFill = Color.Blue;
        int figureSize = 50;
        public Form1()
        {
            InitializeComponent();
            circleItem.Checked = true;
            noItem.Checked = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            bool isNew = true;
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].isInArea(e.X, e.Y))
                {
                    container[i].isSelected = true;
                    for (int j = 0; j < container.Count; j++)
                    {
                        if (j != i && !isCtrlPressed)
                        {
                            container[j].isSelected = false;
                        }
                    }
                    this.Refresh();
                    return;
                }
            }
            
            if (figure == "Круг")
            {
                Circle c = new Circle(e.X, e.Y, colorFill, figureSize);
                container.pushBack(c);
            }
            else if (figure == "Квадрат")
            {
                Square s = new Square(e.X, e.Y, colorFill, figureSize);
                container.pushBack(s);
            }
            else if (figure == "Треугольник")
            {
                Triangle t = new Triangle(e.X, e.Y, colorFill, figureSize);
                container.pushBack(t);
            }


            if (container.Count < 2)
            {
                container[0].isSelected = true;
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < container.Count; i++)
            {
                container[i].draw(e);
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
                        container.remove(i);
                        i--;
                    }
                }
                if (container.Count > 0)
                {
                    container[0].isSelected = true;
                }
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                if (isCtrlAvailable)
                {
                    isCtrlPressed = true;
                }
                return;
            }
            if (e.KeyCode == Keys.W)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(0, -5, this.ClientSize.Width, this.ClientSize.Height, 'w');
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(0, 5, this.ClientSize.Width, this.ClientSize.Height, 's');
                    }
                }
            }
            if (e.KeyCode == Keys.A)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(-5, 0, this.ClientSize.Width, this.ClientSize.Height, 'a');
                    }
                }
            }
            if (e.KeyCode == Keys.D)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].isSelected)
                    {
                        container[i].move(5, 0, this.ClientSize.Width, this.ClientSize.Height, 'd');
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

        private void yesItem_Click(object sender, EventArgs e)
        {
            isCtrlAvailable = true;
            yesItem.Checked = true;
            noItem.Checked = false;
        }

        private void noItem_Click(object sender, EventArgs e)
        {
            isCtrlAvailable = false;
            yesItem.Checked = false;
            noItem.Checked = true;
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
            }
        }
    }
}
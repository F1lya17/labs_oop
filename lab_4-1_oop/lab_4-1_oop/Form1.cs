namespace lab_4_1_oop
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            bool isNew = true;
            List<int> cr = new List<int>();
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].isInArea(e.X, e.Y))
                {
                    if (!sevCircles.Checked)
                    {
                        circles[i].isSelected = true;
                        for (int j = 0; j < circles.Count; j++)
                        {
                            if (j != i && !flag)
                            {
                                circles[j].isSelected = false;
                            }
                        }
                        this.Refresh();
                        return;
                    }
                    else
                    {
                        circles[i].isSelected = true;
                        cr.Add(i);
                        isNew = false;
                    }
                }
            }
            if (!isNew)
            {
                for (int j = 0; j < circles.Count; j++)
                {
                    if (!cr.Contains(j) && !flag)
                    {
                        circles[j].isSelected = false;
                    }
                }
                this.Refresh();
                return;
            }
            Circle c = new Circle(e.X, e.Y, 50);
            circles.Add(c);
            if (circles.Count < 2)
            {
                circles[0].isSelected = true;
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].draw(e);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].isSelected)
                    {
                        circles.RemoveAt(i);
                    }
                }
                if (circles.Count > 0)
                {
                    circles[0].isSelected = true;
                }
                this.Refresh();
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                if (ctrl.Checked)
                {
                    flag = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                flag = false;
            }
        }
    }
}
using System.Runtime.InteropServices.ObjectiveC;

namespace lab_4_2_OOP
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        public Form1()
        {
            InitializeComponent();
            model.observers += new System.EventHandler(this.updateForm);
            model.observers.Invoke(model, EventArgs.Empty);
        }

        private void updateForm(object sender, EventArgs e)
        {
            numericUpDownA.Value = model.getValueA();
            textBoxA.Text = model.getValueA().ToString();
            trackBarA.Value = model.getValueA();

            numericUpDownB.Value = model.getValueB();
            textBoxB.Text = model.getValueB().ToString();
            trackBarB.Value = model.getValueB();

            numericUpDownC.Value = model.getValueC();
            textBoxC.Text = model.getValueC().ToString();
            trackBarC.Value = model.getValueC();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Int32.Parse(textBoxA.Text));
            }
        }

        private void trackBarA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }

        private void textBoxB_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(Int32.Parse(textBoxC.Text));
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Int32.Parse(textBoxB.Text));
            }
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (textBoxA.Text != "")
            {
                model.setValueA(Int32.Parse(textBoxA.Text));
            }
            else
            {
                model.setValueA(model.getValueA());
            }
        }

        private void numericUpDownA_Leave(object sender, EventArgs e)
        {
            if (Decimal.ToInt32(numericUpDownA.Value) > 0)
            {
                model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
            }
            else
            {
                model.setValueA(0);
            }
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (textBoxB.Text != "")
            {
                model.setValueB(Int32.Parse(textBoxB.Text));
            }
            else
            {
                model.setValueB(model.getValueB());
            }
        }

        private void numericUpDownB_Leave(object sender, EventArgs e)
        {
            if (Decimal.ToInt32(numericUpDownB.Value) > 0)
            {
                model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
            }
            else
            {
                model.setValueB(0);
            }
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            if (textBoxC.Text != "")
            {
                model.setValueC(Int32.Parse(textBoxC.Text));
            }
            else
            {
                model.setValueC(model.getValueC());
            }
        }

        private void numericUpDownC_Leave(object sender, EventArgs e)
        {
            if (numericUpDownC.Value != null && numericUpDownC.Value != 0)
            {
                model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
            }
            else
            {
                model.setValueC(model.getValueC());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.destroy();
        }
    }
}
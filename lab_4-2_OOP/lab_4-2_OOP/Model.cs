using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_2_OOP
{
    internal class Model
    {
        private int valueA = 0;
        private int valueB = 0;
        private int valueC = 0;
        public System.EventHandler observers;

        public void setValueA(int value)
        {
            if (value > 100)
            {
                this.valueA = 100;
            }
            else if (value < 0)
            {
                this.valueA = 0;
            }
            else
            {
                this.valueA = value;
                if (this.valueA > this.valueB)
                {
                    this.valueB = this.valueA;
                    if (this.valueB > this.valueC)
                    {
                        this.valueC = this.valueA;
                    }
                }
                observers.Invoke(this, EventArgs.Empty);
            }
        }

        public void setValueB(int value)
        {
            if (value > this.valueC || value < this.valueA)
            {
                if (Math.Abs(this.valueC - value) < Math.Abs(this.valueA - value))
                {
                    this.valueB = this.valueC;
                }
                else
                {
                    this.valueB = this.valueA;
                }
            }
            else
            {
                this.valueB = value;
            }
            observers.Invoke(this, EventArgs.Empty);
        }

        public void setValueC(int value)
        {
            if (value > 100)
            {
                this.valueC = 100;
            }
            else if (value < 0)
            {
                this.valueC = 0;
            }
            else
            {
                this.valueC = value;
                if (this.valueC < this.valueB)
                {
                    this.valueB = this.valueC;
                    if (this.valueB < this.valueA)
                    {
                        this.valueA = this.valueB;
                    }
                }
                observers.Invoke(this, EventArgs.Empty);
            }
        }

        public int getValueA()
        {
            return this.valueA;
        }

        public int getValueB()
        {
            return this.valueB;
        }

        public int getValueC()
        {
            return this.valueC;
        }
    }
}

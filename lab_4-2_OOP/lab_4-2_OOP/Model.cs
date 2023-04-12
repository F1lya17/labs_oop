using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using lab_4_2_OOP.Properties;

namespace lab_4_2_OOP
{
    internal class Model
    {
        private int valueA = 0;
        private int valueB = 0;
        private int valueC = 0;
        public System.EventHandler observers;

        public Model()
        {
            FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            this.valueA = bw.ReadInt32();
            this.valueB = bw.ReadInt32();
            this.valueC = bw.ReadInt32();
            fs.Close();
        }
        public void destroy()
        {
            FileStream fs = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(this.valueA);
            bw.Write(this.valueB);
            bw.Write(this.valueC);
            fs.Close();
        }


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
            }
            observers.Invoke(this, EventArgs.Empty);
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
            }

            observers.Invoke(this, EventArgs.Empty);
        }

        public void setOnlyValueA(int value)
        {
            this.valueA = value;
        }

        public void setOnlyValueB(int value)
        {
            this.valueB = value;
        }

        public void setOnlyValueC(int value)
        {
            this.valueC = value;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Mycontainer<T>
    {
        private const int defaultCapacity = 4;

        public T[] arr;

        private int size;

        private static readonly T[] emptyArr = new T[0];

        public int Capacity
        {
            get
            {
                return (int)arr.Length;
            }
            set
            {
                if (value < size)
                {
                    return;
                }

                if (value == arr.Length)
                {
                    return;
                }

                if (value > 0)
                {
                    T[] tmp_arr = new T[value];

                    if (size > 0)
                    {
                        Array.Copy(arr, tmp_arr, size);
                    }

                    arr = tmp_arr;
                }
                else
                {
                    arr = emptyArr;
                }
            }
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= size)
                {
                    return default(T);
                }

                return arr[index];
            }
            set
            {
                if (index >= size)
                {
                    return;
                }

                arr[index] = value;
            }
        }

        public Mycontainer()
        {
            arr = new T[0];
            size = 0;
        }

        public Mycontainer(int capacity)
        {
            arr = new T[capacity];
            size = capacity;
        }

        public void pushBack(T value)
        {
            if (size == arr.Length)
            {
                increaseBuf();
            }
            arr[size++] = value;
        }

        public void pushFront(T value)
        {
            if (size == arr.Length)
            {
                increaseBuf();
            }
            for (int i = size++; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = value;
        }
        public void pushIn(T value, int index)
        {
            if (index >= size)
            {
                return;
            }
            if (size == arr.Length)
            {
                increaseBuf();
            }
            for (int i = size++; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = value;
        }
        public int find(T obj)
        {
            for (int i = 0; i < size; ++i)
            {
                if (arr[i].Equals(obj))
                {
                    return (int)i;
                }
            }
            return -1;
        }
        public T remove(int index)
        {
            if (index >= size)
            {
                return default(T);
            }
            size--;
            T tmp = arr[index];
            for (int i = index; i < size; i++)
            {
                arr[i] = arr[i + 1];
            }
            if (size == arr.Length / 2)
            {
                decreaseBuf();
            }
            return tmp;
        }
        public void clear()
        {
            arr = emptyArr;
            size = 0;
        }
        private void increaseBuf()
        {
            Capacity = ((arr.Length == 0) ? defaultCapacity : (int)(arr.Length * 2));
        }
        private void decreaseBuf()
        {
            Capacity = size * 3 / 2;
        }

    }
}

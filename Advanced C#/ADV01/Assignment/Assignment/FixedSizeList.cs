using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        T[] arr;
        int index;
        public FixedSizeList(int n)
        {
            arr = new T[n];
            index = 0;
        }
        public void Add(T item)
        {
            if (index == arr.Length)
            {
                throw new Exception("FixedSizeList overflow");
            }
            arr[index++] = item;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= this.index)
                throw new Exception("Index out of range");
            return arr[index];
        }


    }
}

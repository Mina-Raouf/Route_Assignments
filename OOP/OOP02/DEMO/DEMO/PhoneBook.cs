using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;
        public PhoneBook(int size)
        {
            names=new string[size];
            numbers=new long[size];
            this.size = size;
        }
        public int Size { get { return size; } }
        public long this [string name]
        {
            get
            {
                for(int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                for(int i = 0; i < size; i++)
                {
                    if(names[i] == name)
                    {
                        numbers[i] = value;
                        return;
                    }
                }
                for(int i = 0; i < size; i++)
                {
                    if (names[i] is null)
                    {
                        names[i] = name;
                        numbers[i] = value;
                        return;
                    }
                }
            }
        
        }
        public string this[int i]
        {
            get
            {
                return $"{names[i]} :: {numbers[i]} ";
            }
        }

    }
}

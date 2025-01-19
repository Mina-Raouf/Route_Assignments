using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        T MinRange { get; set; }
        T MaxRange { get; set; }

        public Range(T MinRange,T MaxRange)
        {
            this.MinRange = MinRange;
            this.MaxRange = MaxRange;
        }
        public bool IsInRange(T Value)
        {
            return Value.CompareTo(MinRange) > -1 && Value.CompareTo(MaxRange) < 1;
        }
        public int Length()
        {
            if(typeof(T) != typeof(int))
            {
                Console.WriteLine("Not allowed for this type");
                return -1;
            }
            dynamic L = MinRange;
            dynamic R = MaxRange;
            return (int)(R - L + 1);
        }


    }
}

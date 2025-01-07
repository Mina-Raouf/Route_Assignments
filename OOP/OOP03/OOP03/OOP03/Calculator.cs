using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Calculator
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }
        static public int Add(int x,int y,int z) 
        {
            return x + y + z; 
        }

        public static double Add(double x,double y)
        {
            return x + y;
        }
    }
}

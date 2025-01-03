using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal struct Point
    {
        // Atrributes
        private int x, y;

        // Constructor :
        // Name like stuct Name 
        // No Return value
        // should be non-private except in singleton


        // auto generated
        //public Point()
        //{
        //    x = default;
        //    y = default;
        //}
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X = {x} :: Y = {y}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Rectangle
    {
        public int length { get; set; }
        public int width { get; set; }
        public Rectangle()
        {
            length=width=0;
        }
        public Rectangle(int l,int h)
        {
            length = l;
            width = h;
        }
        public Rectangle(int l)
        {
            length=width= l;
        }
    }
}

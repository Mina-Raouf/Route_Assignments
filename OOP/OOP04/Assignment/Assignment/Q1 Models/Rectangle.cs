using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1_Models
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public Rectangle(double Height, double Width)
        {
            Area = Height * Width;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of the Rectangle = {Area}");
        }
    }
}

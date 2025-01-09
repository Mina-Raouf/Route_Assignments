using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1_Models
{
    internal class Circle : ICircle
    {
        public double Area { get; set ; }
        public Circle(double Raduis)
        {
            Area = Raduis * Raduis * 3.14;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of the Circle = {Area}");
        }
    }
}

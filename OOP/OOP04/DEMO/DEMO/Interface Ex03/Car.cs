using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface_Ex03
{
    internal class Car : Vehicle, IMoveable
    {
        public override int Speed { get; set; }

        public void Backward()
        {
            
        }

        public void Forward()
        {
        }

        public void Left()
        {
        }

        public void Right()
        {
        }
    }
}

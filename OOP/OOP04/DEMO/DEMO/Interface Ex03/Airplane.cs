using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface_Ex03
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
    {
        public override int Speed { get; set; }
        void IMoveable.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }
        // If there is two functions with the same name but different interfaces must be private 
        // and access to them by reference of each interface 
        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}

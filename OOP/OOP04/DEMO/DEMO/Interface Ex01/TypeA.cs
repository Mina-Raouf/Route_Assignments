using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface_Ex01
{
    class TypeA : IType
    {
        private int Attribute;

        public int MyProperty {
            get
            {
                return Attribute;
            }
            set
            {
                Attribute = value;
            }
        }

        public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}

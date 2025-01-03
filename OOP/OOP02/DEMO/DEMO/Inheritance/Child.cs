using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Inheritance
{
    internal class Child:Parent
    {
        // by default child made a constructor chainning on parameterless parent consturctor
        
        public int Z { get; set; }
        public Child(int x,int y ,int z):base(x,y)
        {
            Z = z;
        }

        public new string ToString()
        {
            return $"{base.ToString()} Z ={Z}";
        }

        public override int Product()
        {
            return base.Product()*Z;
        }

        // override vs new
        //override permits childs to override function again
        // new should have virtual keyword to override with other childs
    }
}

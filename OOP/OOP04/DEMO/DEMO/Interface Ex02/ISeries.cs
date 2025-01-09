using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface_Ex02
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }
    }

    abstract class Series

    {
        public abstract int Current { get; set; }
        public abstract void GetNext();
        public abstract void Reset();
    }

}

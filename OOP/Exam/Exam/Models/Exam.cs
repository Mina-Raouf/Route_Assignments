using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }

       abstract public void Create();
       abstract public void Start();
    }
}

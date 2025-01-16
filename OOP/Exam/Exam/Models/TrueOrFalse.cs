using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class TrueOrFalse:Question
    {
        public TrueOrFalse()
        {
            Answers = new Answer[2] { 
                 new Answer {Id=1,Text="True" },
                 new Answer{ Id=2,Text="False"} };
        }
    }
}

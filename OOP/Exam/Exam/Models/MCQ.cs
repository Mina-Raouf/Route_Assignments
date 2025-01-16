using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class MCQ:Question
    {
        public MCQ()
        {
            Answers = new Answer[3] { new Answer {Id=1 },
                      new Answer {Id=2 },
                      new Answer {Id=3 }};
        }
    }
}

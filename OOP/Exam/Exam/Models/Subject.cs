using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam exam { get; set; }

    }
}

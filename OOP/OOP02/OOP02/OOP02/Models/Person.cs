using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Models
{
    internal struct Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name = {Name} :: Age = {Age}";
        }
    }
}

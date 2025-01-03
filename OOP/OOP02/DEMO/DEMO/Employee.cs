using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class Employee
    {
        
        // Encalpsulation : Separate Data from its Use
        int Id;
        string? name;
        decimal Salary;
        public Employee(int Id,string ?name,decimal Salary)
        {
            this.Id = Id;
            this.name = Name;
            this.Salary = Salary;
        }
        // full property :: propfull
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value is null ? null : value.Length <= 10 ? value : value.Substring(0, 10);
            }
        }
        // auto property : prop
        public decimal Deduction { get; set; }
    }
}

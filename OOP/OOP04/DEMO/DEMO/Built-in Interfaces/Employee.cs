using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Built_in_Interfaces
{
    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Department? department { get; set; }


        public Employee()
        {
            
        }
        // Copy consturctor : for deep copy
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id;
            this.Name = employeeCopy.Name;
            this.Salary = employeeCopy.Salary;
            this.department = (Department?)employeeCopy?.department?.Clone();
        }

        public object Clone()
        {
            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = (string?)this.Name?.Clone(),
            //    // Memory Enhancement : same name no clone 
            //    Salary = this.Salary,
            //    department = (Department?)this.department?.Clone()
            //};
            return new Employee(this);
        }


        // +Ve: this. Salary > obj.Salary
        // -Ve: this. Saalry < obj.Salary
        // 0: this. Salary = obj.Salary

        public int CompareTo(object? obj)
        {
            Employee? other = (Employee?)obj; // Explicit Casting  
            return this.Salary.CompareTo(other?.Salary);
            //if (other is null)
            //    return 1;
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //    return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:c}";
        }

    }
}

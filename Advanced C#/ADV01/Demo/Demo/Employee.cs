using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    internal class EmployeeComparerById : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Id.CompareTo(y?.Id ?? 0) ?? (y is null ? 0 : -1);
        }
    }

    internal class Employee : IEquatable<Employee>, IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
            // NOTE: with ? will use CompareTo object? 
        }

        public override bool Equals(object? obj)
        {
            // 1. is operator
            if (obj is Employee other)
            {
                return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
            }
            // 2. as operator
            //Employee? other = obj as Employee;
            //if (other == null) return false;
            //return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;

            return false;
            //Employee? other = (Employee?)obj;// Unsafe may throw exception
            //if (other is null) return false;
            //return this.Id == other?.Id && this.Name == other?.Name && this.Salary == other?.Salary;
        }
        public bool Equals(Employee? other)
        {
            if (other == null) return false;
            return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Name, this.Salary);
        }

    }
}

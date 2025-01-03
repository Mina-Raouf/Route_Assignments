using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Models
{
    [Flags]
    enum Privileges
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8,SecurityOfficer=15
    }
    enum Gender
    {
        Male,Female
    }
    internal class Employee //:IComparable 
    {
        public Employee()
        {
            
        }
        public Employee(int id ,string name, double salary, Privileges securityLevel, Gender gender,HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            this.hiringDate = hiringDate;
            this.gender = gender;
        }
        public int Id { get; set; }
        public string Name { get ; set ; }

        public Privileges SecurityLevel { get; set; }
        public double Salary { get ; set; }

        public HiringDate hiringDate { get; set; }=new HiringDate();

        public Gender gender { get ; set; }

        public override string ToString()
        {
            
            return $"Id = {Id} , Name = {Name} , SecurityLevel = {SecurityLevel},Salary = {string.Format(Salary.ToString())},HiringDate = {hiringDate}, Gender = {gender}";
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public double GetSalary()
        {
            return Salary;
        }

        public void SetSalary(string salary)
        {
            double newSalary=0;
            bool valid = double.TryParse(salary, out newSalary);
            if (!valid)
            {
                Salary = 3000;
                Console.WriteLine("Invalid Salary");
            }
            else { Salary = newSalary; }
        }

        public Privileges GetSecurityLevel()
        {
            return SecurityLevel;
        }
        public void SetSecurityLevel(string securitylevel)
        {
            Privileges newSecurityLevel;
            bool valid = Enum.TryParse(securitylevel, true, out newSecurityLevel);
            if (valid)
            {
                SecurityLevel = newSecurityLevel;
            }
            else
            {
                Console.WriteLine("Invalid Security Level");
            }
        }

        public Gender GetGender()
        {
            return gender;
        }

        public void SetGender(string gender)
        {
            Gender value;
            if(Enum.TryParse(gender, true, out value))
            {
                this.gender= value;
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
        }
        
        //public int CompareTo(object? obj)
        //{
        //    if (obj == null) return 1;
        //    Employee other = obj as Employee;
        //    return hiringDate.CompareTo(other.hiringDate);
        //}
    }
}

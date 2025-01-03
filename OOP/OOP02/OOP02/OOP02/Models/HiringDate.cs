using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Models
{
    internal class HiringDate//:IComparable
    {
        public HiringDate()
        {
            
        }
        public HiringDate(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    if (obj == null) return 1;

        //    HiringDate other = obj as HiringDate;
        //    int total01 = day + month * 30 + year * 365;
        //    int total02 = other.day + other.month * 30 + other.year * 365;

        //    return total01.CompareTo(total02);

        //}


        static public bool LessThan(HiringDate a, HiringDate b)
        {
            
            if (a.year < b.year) return true;

            if (a.year == b.year && a.month < b.month) return true;
            return a.year==b.year && a.month==b.month&&a.day < b.day;

        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Duration
    {

        #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; } 
        #endregion

        public Duration()
        {

        }
        #region 3-Define All Required Constructors to Produce this output:
        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Duration(int total)
        {
            Hours = total / 3600;
            total = total % 3600;
            Minutes = total / 60;
            Seconds = total % 60;
        }

        #endregion

        #region 2-Override All System. Object Members (To String, Equals,GetHasCode) .
        public override string ToString()
        {
            return $"Hours = {Hours}, Minutes = {Minutes}, Seconds = {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            Duration? duration = obj as Duration;
            if (duration == null) return false;
            return duration.Hours == Hours && duration.Minutes == Minutes && duration.Seconds == Seconds;
        }

        public override int GetHashCode()
        {
            return Hours * 60 * 60 + Minutes * 60 + Seconds;
        }

        #endregion


        #region 4-Implement All required Operators overloading to enable this Code:
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration((a.Hours + b.Hours) * 60 * 60 + (a.Minutes + b.Minutes) * 60 + a.Seconds + b.Seconds);
        }

        public static Duration operator +(Duration d, int x)
        {
            return new Duration(d.Hours * 60 * 60 + d.Minutes * 60 + d.Seconds + x);
        }

        public static Duration operator +(int x, Duration d)
        {
            return new Duration(d.Hours * 60 * 60 + d.Minutes * 60 + d.Seconds + x);
        }
        public static Duration operator ++(Duration d)
        {
            return d + 1;
        }
        public static Duration operator --(Duration d)
        {
            return d + (-1);
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration((a.Hours - b.Hours) * 60 * 60 + (a.Minutes - b.Minutes) * 60 + a.Seconds - b.Seconds);
        }

        public static bool operator >(Duration a, Duration b)
        {
            int totalA = a.Hours * 60 * 60 + a.Minutes * 60 + a.Seconds;
            int totalB = b.Hours * 60 * 60 + b.Minutes * 60 + b.Seconds;
            return totalA > totalB;
        }
        public static bool operator <(Duration a, Duration b)
        {
            int totalA = a.Hours * 60 * 60 + a.Minutes * 60 + a.Seconds;
            int totalB = b.Hours * 60 * 60 + b.Minutes * 60 + b.Seconds;
            return totalA < totalB;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            return !(a > b);
        }
        public static bool operator >=(Duration a, Duration b)
        {
            return !(a < b);
        }
        public static implicit operator bool(Duration d)
        {
            return (d?.Hours > 0 || d?.Minutes > 0 || d?.Seconds > 0);
        }

        public static explicit operator Duration(DateTime d)
        {
            return new Duration()
            {
                Hours = d.Hour,
                Minutes = d.Minute,
                Seconds = d.Second,
            };
        }
    } 
    #endregion
}

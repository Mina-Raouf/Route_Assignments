using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Binary Operators
        // Operator Overloading must be non-private Class Member
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex() { Real = (Left?.Real ?? 0) + (Right?.Real ?? 0), Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0) };
        }
        // null propagational operator : ?  --> left!=null ? left.Real : null 
        // null coalesing operator : ?? 
        #endregion

        #region Unary
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0),
            };
        }
        #endregion

        #region Relational Operators
        static public bool operator >(Complex a, Complex b)
        {
            if (a?.Real == b?.Real)
            {
                return a?.Imag > b?.Imag;
            }
            return a?.Real > b?.Real;
        }
        static public bool operator <(Complex a, Complex b)
        {
            if (a?.Real == b?.Real)
            {
                return a?.Imag < b?.Imag;
            }
            return a?.Real < b?.Real;
        }
        #endregion

        #region Casting Operators 
        public static /*int*/ explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        public static implicit operator string(Complex c)
        {
            return c?.ToString() ?? "(0,0)";
        } 
        #endregion
        public override string ToString()
        {
            return $"({Real},{Imag}i)";
        }
    }
}

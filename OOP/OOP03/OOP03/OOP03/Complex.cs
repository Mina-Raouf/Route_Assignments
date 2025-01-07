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

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };
        }
    }
}

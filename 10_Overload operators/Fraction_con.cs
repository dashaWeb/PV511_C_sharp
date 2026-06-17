using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Overload_operators
{
    partial class Fraction
    {
        public static Fraction operator +(Fraction one, Fraction two)
        {
            //int num = one.Num * two.Denum + two.Num * one.Denum;
            //int denum = one.Denum * two.Denum;
            //Fraction res = new Fraction(num, denum);
            //return res;

            return new Fraction(one.Num * two.Denum + two.Num * one.Denum, one.Denum * two.Denum);
        }

        // == & !=
        public static bool operator ==(Fraction one, Fraction two)
        {
            if (ReferenceEquals(one, two))
                return true;
            if (one is null || two is null)
                return false;
            return one.Equals(two);
        }
        public static bool operator !=(Fraction one, Fraction two)
        {
            return !(one == two);
        }

        // true & false
        public static bool operator true(Fraction one)
        {
            return one.Num != 0;
        }
        public static bool operator false(Fraction one)
        {
            return one.Num == 0;
        }

        public static Fraction operator ++(Fraction one)
        {
            Fraction fr = new Fraction(1, 1);
            return one + fr;
        }

        // перетворення типів explicit(явне), implicit(неявне)
        public static explicit operator int(Fraction one)
        {
            return one.Num / one.Denum;
        }
        public static implicit operator double(Fraction one)
        {
            return (double)one.Num / one.Denum;
        }
    }
}




// a = 5, b = 10; res = a + b

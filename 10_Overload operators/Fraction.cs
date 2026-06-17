using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Overload_operators
{
    // static operator(method) --> +,-,*; +=, -=, ...
    // перетворення типів explicit(явне), implicit(неявне)
    // слід перевантажувати парами == i !=, < i >, <= i >=, true i false;
    // [] - через властивість

    partial class Fraction
    {
        public int Num { get; set; }
        public int Denum { 
            get => denum; 
            set => denum = value != 0 ? value : 1; }
        private int denum;
        public Fraction(int num, int denum)
        {
            Num = num;
            Denum = denum;
        }
        public override string ToString()
        {
            return $"{Num}/{Denum}";
        }
        public override bool Equals(object? obj)
        {
            Fraction other = obj as Fraction;
            if (other == null)
                return false;
            return this.Num * other.Denum == this.Denum * other.Num;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Num;
                    case 1:
                        return Denum;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Num = value;
                        break;
                    case 1:
                        Denum = value;
                        break;       
                }
            }

        }
    }
}

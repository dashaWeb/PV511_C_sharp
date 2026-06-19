using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class Smartphone : Device
    {
        public Smartphone(string brand = "NoBrand", int year = 2020)
            : base(brand, year)
        {

        }

        public override bool HasBattery => true;

        public void demo()
        {
            Console.WriteLine($"Check brand {brand} Year : {base.Year}");
            Console.WriteLine($"Check {base.Weight}, Price : {base.Price}");
        }
    }
}

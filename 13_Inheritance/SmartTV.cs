using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class SmartTV :TV
    {
        //new string brand;
        public SmartTV(string brand = "NoBrand", int year = 2020, int diadonal = 42)
            :base(brand,year,diadonal)
        {
           
        }
        new public void PrintModel()
        {
            base.PrintModel();
            Console.WriteLine($"Smart TV {Brand} can surf in internet");
        }
    }
}

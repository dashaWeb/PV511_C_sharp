using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class TV : Device
    {
        public int Diagonal { get; set; } = 42;
        public override bool HasBattery => false;
        public TV(string brand = "NoBrand", int year = 2020, int diagonal = 42)
            :base(brand,year)
        {
            //this.Year = year;
            //this.brand = brand;
            this.Diagonal = diagonal;
        }
        // not virtual
        public void PrintModel()
        {
            Console.WriteLine($"{this.GetType().Name} {Brand} can show tv-channels");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Diagonal : {Diagonal}";
        }
    }
}

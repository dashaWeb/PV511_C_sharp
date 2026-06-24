using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception
{
    class SteamerDuck:Duck, IFly
    {
        //new public void Fly()
        //{
        //    Console.WriteLine($"Steamer duck can not fly");
        //}
        public override void Fly()
        {
            Console.WriteLine($"Steamer duck can not fly");
        }
    }
}

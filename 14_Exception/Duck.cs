using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception
{
    class Duck : ISwim, IMove, IFly
    {
        // 1 way - одна реалізація для усіх інтерфейсів
        //public int Speed => 3;

        // 2 way - явна реалізація
        int IMove.Speed => 3;
        int IFly.Speed => 10;

        public int Weight { get; set; }

        public void Move()
        {
            Console.WriteLine($"Suck with weight {Weight} can walk with speed {((IMove)this).Speed}");
        }

        virtual public void Fly()
        {
            Console.WriteLine($"Duck can fly with {((IFly)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }
    }
}

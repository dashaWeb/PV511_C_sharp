using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Interviwer // subscriber
    {
        public string  Name { get; set; }
        public void DoSomething(string desc) // метод, що може бути обробником події (підходить під делегат PositionDelegate)
        {
            Console.WriteLine($"Interviwer {Name} notified abou {desc}");
        }
    }
}

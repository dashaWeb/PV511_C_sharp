using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventHandler_with_args
{
    class Interviwer // subscriber
    {
        public string Name { get; set; }
        public void DoSomething(object sender, MyArgs args) // метод, що може бути обробником події (підходить під делегат PositionDelegate)
        {
            Console.WriteLine($"Interviwer {Name} notified abou {args.Description} Date {args.Date.ToShortDateString()} with Company {(sender as Company)?.Name}");
        }
    }
}

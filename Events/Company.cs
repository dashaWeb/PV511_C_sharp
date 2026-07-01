using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void PositionDelegate(string description); // 1) визначили тип делегату для події NewPosition у класі Company
    class Company // publisher
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; // 2) подія = екземпляр делегату
        public void AddPosition(string description) // 3) bussiness logic method
        {
            NewPosition?.Invoke(description); // 4) ініціювання (запуск) події NewPosition -- виклик методів приєднаних до делегату 
        }
    }
}

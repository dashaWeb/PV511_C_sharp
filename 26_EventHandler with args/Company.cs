using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventHandler_with_args
{
    //delegate void PositionDelegate(string description); // 1) визначили тип делегату для події NewPosition у класі Company
    class MyArgs : EventArgs
    {
        public string Description { get; set; }
        public DateTime Date => DateTime.Today;
    }
    class Company // publisher
    {
        public string Name { get; set; }
        //public event PositionDelegate NewPosition; // 2) подія = екземпляр делегату
        public event EventHandler<MyArgs> NewPosition; // 2) подія = екземпляр делегату
        public void AddPosition(string description) // 3) bussiness logic method
        {
            MyArgs args = new MyArgs()
            {
                Description = description
            };
            NewPosition?.Invoke(this, args); // 4) ініціювання (запуск) події NewPosition -- виклик методів приєднаних до делегату 
        }
    }
}

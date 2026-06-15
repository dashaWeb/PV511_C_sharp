using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static_field___method
{
    // static, const, readonly
    enum Position { None, Manager = 1, Developer, QA, Economist, Director}
    class Employee
    {
        public string Name { get; set; } = "Noname";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }

        private static int lastId;
        public readonly int ID = ++lastId;

        public static int LastId { get => lastId; }
        public static bool SomePosition(Employee emp1, Employee emp2) => emp1.Position == emp2.Position;
        public override string ToString() => $"ID : {ID,-5} Name : {Name,-10} Position : {Position,-5} Birth : {Birth.ToShortDateString(),-20} Age: {Age}";
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
        static Employee()
        {
            Console.WriteLine("\t\t Static ctor");
            lastId = new Random().Next(1, 10) * 1000;
        }
    }
}

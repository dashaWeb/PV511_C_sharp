using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    abstract class Device
    {
        protected string brand; // буде видно у дочірньому
        public string Brand { 
            get => brand; 
            set => brand = value ?? "Nobrand"; 
        }
        private int year;
        public int Year { 
            get=> year; 
            set => year = value <= DateTime.Today.Year ? value : throw new Exception("Bad year of device"); 
        }
        public Device(string brand ="NoBrand", int year = 2020)
        {
            Brand = brand;
            Year = year;
        }
        //public virtual bool HasBattery { get => false; }
        public abstract bool HasBattery { get; }

        internal int Price { get; set; }
        protected internal int Weight { get; set; }
        public override string ToString()
        {
            return $"Device : {this.GetType().Name, -10} Brand : {Brand,-15} Year : {Year,-10} Has Battery : {HasBattery, -10} Price : {Price} Weight : {Weight}";
        }
    }
}

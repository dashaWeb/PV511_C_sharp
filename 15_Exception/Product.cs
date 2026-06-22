using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    class Product
    {
        string name;
        double price;
        DateTime dateIn;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Name must be not null or writespace");
                if (!value.All(c => char.IsLetter(c)))
                {
                    Exception ex = new Exception("Bad name :: must be all letters");
                    ex.Data.Add("Value", value);
                    ex.Data["TimeStamp"] = DateTime.Now;
                    throw ex;
                }
            }
        }
        public DateTime DateIn
        {
            get => dateIn;
            set
            {
                dateIn = value <= DateTime.Now ? value : throw new BadProductDateException("Error date of product", value);
            }
        }

        public void InputName()
        {
            while (true)
            {
                Console.WriteLine("Input product name :: ");
                string input = Console.ReadLine();
                try
                {
                    Name = input;
                    break;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                    throw;
                }
            }
        }
    }
}

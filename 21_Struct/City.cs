using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Struct
{
    struct City : IComparable, IComparable<City>
    {
        const int DefaultPopulation = 100_000;
        const int MaxPopulation = 10_000_000;
        private int population;
        public string Name { get; set; } //= "Noname" error;
        public int Population
        {
            get => population;
            set => population = value <= MaxPopulation ? value : MaxPopulation;
            
        }
        public City(string name, int population = DefaultPopulation)
            :this()
        {
            Name = name;
            this.Population = population;
        }
        public override string ToString()
        {
            return $"City : {Name,-10} Population : {population,-15}";
        }

        public int CompareTo(object? obj) // not productive boxing unboxing
        {
            Console.WriteLine("CompareTo");
            if (!(obj is City)) // not City
                throw new ArgumentException("CompareTo() : object is not City");
            City city = (City)obj; // unboxing
            //if (this.population < city.population)
            //    return -1;
            //if (this.population > city.population)
            //    return 1;
            //return 0;

            //return this.population - city.population;
            return this.population.CompareTo(city.population);
        }

        public int CompareTo(City other)
        {
            Console.WriteLine("CompareTo<>");
            return this.population.CompareTo(other.population);
        }
    }

    struct ComparerByName : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    struct ComparerByNameDesc : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}

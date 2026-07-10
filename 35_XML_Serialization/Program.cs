using _35_XML_Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        //BinaryFormatter bf = new BinaryFormatter();
        string fname = "car.xml";
        Car car = new Car(122, "Toyota", 2.3);
        Car car2 = new Car(300, "BMW", 3.0);

        XmlSerializer xs = new XmlSerializer(typeof(Car));
        using(FileStream fs = new FileStream(fname, FileMode.Create))
        {
            xs.Serialize(fs, car);

            fs.Position = 0;

            Car recCar = xs.Deserialize(fs) as Car;
            Console.WriteLine("Recovered car :: " + recCar);
        }

        string fnameCars = "listCars.xml";
        List<Car> cars = new List<Car>()
        {
            car,
            car2
        };
        XmlSerializer xsL = new XmlSerializer(typeof(List<Car>));
        using(TextWriter tx = new StreamWriter(fnameCars))
        {
            xsL.Serialize(tx, cars);
        }

        using(TextReader tr = new StreamReader(fnameCars))
        {
            var listCar = xsL.Deserialize(tr) as List<Car>;

            Console.WriteLine($"\n\n Recovered list of cars \n{String.Join<Car>("\n",listCar)}");
        }
    }
}
using _36_JSON_Serialization;
using System.Net;
using System.Text.Json;
//using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(123, "Toyota", 2.3);
        Car car2 = new Car(333, "BMW", 3.0);

        string fname = "car.json";
        //var json = JsonConvert.SerializeObject(car);
        ////Console.WriteLine(json);
        //File.WriteAllText(fname, json);

        //string res = File.ReadAllText(fname);
        //Car rcar = JsonConvert.DeserializeObject<Car>(res)!;
        //Car rcar = JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname))!;
        //Console.WriteLine($"Recovered car :: {rcar}");

        //List<Car> cars = new()
        //{
        //    car, car2
        //};

        //string fnamelist = "listCar.json";
        ////File.WriteAllText(fnamelist,JsonConvert.SerializeObject(cars));
        ////var res = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(fnamelist));
        ////Console.WriteLine($"Recovered :: \n{String.Join<Car>("\n", res)}");


        //Dictionary<int, Car> dictCars = new()
        //{
        //    [car.id] = car,
        //    [car2.id] = car2
        //};

        ////File.WriteAllText(fnamelist,JsonConvert.SerializeObject(dictCars));
        //var res = JsonConvert.DeserializeObject<IDictionary<int, Car>>(File.ReadAllText(fnamelist));
        //foreach (var item in res)
        //{
        //    Console.WriteLine(item.Value);
        //}

        var json = JsonSerializer.Serialize<Car>(car); // only property!!!!!
        Console.WriteLine(json);

        Car res = JsonSerializer.Deserialize<Car>(json);
        Console.WriteLine(res);

        Dictionary<int, Car> dictCars = new()
        {
            [car.id] = car,
            [car2.id] = car2
        };

        json = JsonSerializer.Serialize<Dictionary<int, Car>>(dictCars);
        Console.WriteLine(json);
        Dictionary<int, Car> resdic = JsonSerializer.Deserialize<Dictionary<int, Car>>(json);
        foreach (var item in resdic)
        {
            Console.WriteLine(item.Key + " \t " + item.Value);
        }

        WebClient wc = new WebClient();
        json = wc.DownloadString(@"https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
        Console.WriteLine(json);
    }
}
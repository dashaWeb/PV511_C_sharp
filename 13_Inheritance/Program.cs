using _13_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        //Device device = new Device();
        TV tv = new TV("LG");
        tv.Price = 44;
        tv.Weight = 333;
        Console.WriteLine(tv);
        tv.PrintModel();
        SmartTV smartTV = new SmartTV("LG");
        smartTV.PrintModel();

        Console.WriteLine();
        TV test = smartTV;
        test.PrintModel();

        Smartphone smartphone = new Smartphone();
        smartphone.demo();

        Device[] arr = { tv, smartTV, test, smartphone };
        foreach (var item in arr)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
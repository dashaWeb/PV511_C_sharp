using _14_Exception;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck duck = new Duck() { Weight = 4 };
        Console.WriteLine("\n ------------- Duck ------------- ");
        Console.WriteLine($"Duck weight : {duck.Weight}");
        duck.Move();
        duck.Fly();
        duck.Swim();
        //Console.WriteLine($"Spped : {duck.Speed}");
        Console.WriteLine("\n ------------- Duck as IMove ------------- ");
        IMove im = duck;
        im.Move();
        Console.WriteLine($"Speed : {im.Speed}");

        Console.WriteLine("\n ------------- Duck as IFly ------------- ");
        IFly ifl = duck;
        ifl.Fly();
        Console.WriteLine($"Speed : {ifl.Speed}");

        Console.WriteLine("\n ------------- SteamerDuck as fly ------------- ");
        SteamerDuck steamer = new SteamerDuck();
        steamer.Fly();

        Console.WriteLine("\n\n ------------- Array of ducks fly ------------- ");
        Duck[] ducks = { duck, steamer };
        foreach (var item in ducks)
        {
            item.Fly();
        }
    }
}
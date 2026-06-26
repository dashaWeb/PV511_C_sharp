using _21_Struct;

internal class Program
{
    private static void Main(string[] args)
    {
        City city = new City();
        Console.WriteLine(city);
        City rivne = new City("Rivne", 244_000);
        Console.WriteLine(rivne);

        City clone = rivne; // value type
        Console.WriteLine($"Clone : {clone}");
        Console.WriteLine($"Rivne : {rivne}");

        clone.Name = "Rivne - 2";
        Console.WriteLine($"Clone : {clone}");
        Console.WriteLine($"Rivne : {rivne}");

        int val = 10;
        int val2 = 123;

        Console.WriteLine($"{val.CompareTo(val2)}"); // -1 --> 10 < 123
        Console.WriteLine($"{val2.CompareTo(val)}"); // 1 --> 123 > 10
        val = 123;
        Console.WriteLine($"{val2.CompareTo(val)}"); // 0 --> 123 == 123

        Console.WriteLine();

        int[] arr = { 10, 23, -44, 55, 100, 33 };
        Console.WriteLine(String.Join("\t", arr));
        Array.Sort(arr);
        Console.WriteLine(String.Join("\t", arr));

        City lviv = new City("Lviv", 734_000);

        Console.WriteLine(rivne.CompareTo(lviv));

        City[] cities =
        {
            new City("Kyiv",2_952_301),
            rivne,
            lviv
        };
        Console.WriteLine(String.Join("\n",cities));
        Array.Sort(cities);
        Console.WriteLine();
        Console.WriteLine(String.Join("\n",cities));
        Array.Sort(cities, (c1, c2) => -c1.Population.CompareTo(c2.Population));
        Console.WriteLine();
        Console.WriteLine(String.Join("\n",cities));

        var cmpName = new ComparerByName();
        Array.Sort(cities, cmpName);
        Console.WriteLine();
        Console.WriteLine(String.Join("\n", cities));

        Array.Sort(cities, new ComparerByNameDesc());
        Console.WriteLine();
        Console.WriteLine(String.Join("\n", cities));
    }
}
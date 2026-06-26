internal class Program
{
    enum Color:byte {Red = 4, Blue = 1, White = 15, Black = 0 }
    enum Mode { Read = 1, Write = 2, Binary = 4 };
    private static void Main(string[] args)
    {
        Color color = Color.Red;
        Console.WriteLine($"{color} : {(byte)color}");

        Console.WriteLine("\n Input color (Red = 4, Blue = 1)");
        //color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
        //Console.WriteLine(color);

        if (Enum.TryParse<Color>(Console.ReadLine(), out color))
        {
            if(Enum.IsDefined(typeof(Color), color))
                Console.WriteLine($"{color} : {(byte)color}");
        }

        Console.WriteLine("\n ---------- GetNames --------------");
        var names = Enum.GetNames(typeof(Color));
        Console.WriteLine(String.Join("\n",names));

        Console.WriteLine("\n ---------- GetValues --------------");
        Color[] colors = (Color[])Enum.GetValues(typeof(Color));
        foreach (var item in colors)
        {
            Console.WriteLine($"{item} ---- {(byte)item}");
        }
    }
}
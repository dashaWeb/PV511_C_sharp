using _17_ICloneable;

internal class Program
{
    private static void Main(string[] args)
    {
        //int one = 11; // value type
        //int two = one;
        //Console.WriteLine($"One : {one}; \t Two : {two}");
        //one = 33;
        //Console.WriteLine($"One : {one}; \t Two : {two}");


        //int[] a = { 1, 2, 3 }; // reference type
        //int[] b = (int[])a.Clone();

        //Console.WriteLine($"A --> {String.Join('\t',a)}");
        //Console.WriteLine($"B --> {String.Join('\t',b)}");

        //Console.WriteLine();
        //b[0] = 17;
        //Console.WriteLine($"A --> {String.Join('\t', a)}");
        //Console.WriteLine($"B --> {String.Join('\t', b)}");

        Student olia = new Student("Olia", 10, 11, 10, 12);
        Console.WriteLine(olia);

        Student pavlo = (Student)olia.Clone();
        Console.WriteLine(pavlo);

        pavlo.Name = "Pavlo";
        pavlo[0] = 2;
        Console.WriteLine();
        Console.WriteLine(olia);
        Console.WriteLine(pavlo);

    }
}
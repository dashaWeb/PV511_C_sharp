using _11_Indexers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Matrix m = new Matrix(); // 2x2
        Console.WriteLine(m);
        m[0, 0] = 33;
        Console.WriteLine();
        Console.WriteLine(m);
    }
}
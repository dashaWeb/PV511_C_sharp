internal class Program
{
    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }
    private static void Main(string[] args)
    {
        int first = 5, second = 10;
        Console.WriteLine( "Test BadSwap");
        Console.WriteLine($" Before swap \t first :: {first} \t second :: {second}");
        BadSwap(first, second);
        Console.WriteLine($" After  swap \t first :: {first} \t second :: {second}");

        Console.WriteLine( "Test Swap");
        Console.WriteLine($" Before swap \t first :: {first} \t second :: {second}");
        Swap(ref first, ref second);
        Console.WriteLine($" After  swap \t first :: {first} \t second :: {second}");
        Console.WriteLine( "\n Test out params");
        int res;
        SumTwo(first, second, out res);
        Console.WriteLine($"Result :: {res}");
    }

    // ref, out - передача за посиланням
    // ref - переданий фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
    // out - переданий фактичний параметр можу бути НЕ ПРОІНІЦІАЛІЗОВАНИЙб використовується для збереження результату
    static void Swap(ref int a,ref int b)
    {
        var tmp = a;
        a = b;
        b = tmp;
    }
    static void BadSwap(int a, int b)
    {
        var tmp = a;
        a = b;
        b = tmp;
    }
}
internal class Program
{
    static void Print<T>(T[] arr, string prompt = "")
    {
        //Console.Write(prompt + " :: ");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"{arr[i],20}");
        //}
        //Console.WriteLine();

        Console.Write(prompt + (prompt.Length == 0 ? "" : " :: "));
        foreach (var item in arr)
        {
            Console.Write($"{item,15}");
        }
        Console.WriteLine();
    }
    static void Fill(int[] arr, int min = 0, int max = 100) // ref type , масив приходить за посиланням
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack(ref int[] arr, int value)
    {
        //int[] tmp = new int[arr.Length + 1];
        ////for (int i = 0; i < arr.Length; i++)
        ////{
        ////    tmp[i] = arr[i];
        ////}
        //arr.CopyTo(tmp, 0);
        //tmp[tmp.Length - 1] = value;
        //arr = tmp;

        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;

    }
    private static void Main(string[] args)
    {
        // class Array - абстрактний клас, від якого успадковуються масиви 
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = { 10, 20, 30, 40 };
        Print(arr, "Print Array");
        Print(arr2, "Print Array2");

        //Console.Write("Enter size of array :: ");
        //int size = int.Parse(Console.ReadLine());
        int size = 5;
        int[] arr3 = new int[size];
        Fill(arr3, -5, 5);
        Print(arr3, "Array 3 ");
        PushBack(ref arr3, 333);
        Print(arr3, "Array 3 ");

        Console.WriteLine("Input value for search ::");
        int value = 4; //int.Parse(Console.ReadLine());
        int index = Array.IndexOf(arr3, value);
        if(index != -1)
        {
            Console.WriteLine($"Value {value} was found in index {index}");
            int lastIndex = Array.LastIndexOf(arr3, value);
            Console.WriteLine($"Value {value} was found in last index {lastIndex}");
        }
        else
        {
            Console.WriteLine($"Value {value} not found");
        }

        // бібліотека Linq - методи розширення роботи з масивами
        Console.WriteLine();
        value = 3;
        if (arr.Contains(value))
        {
            Console.WriteLine($"Value {value} was found");
        }
        else
            Console.WriteLine($"Value {value} not found");

        Console.WriteLine();
        int indexPositive = Array.FindIndex(arr3, IsPositive);
        if(indexPositive != -1)
        {
            Console.WriteLine($"Found positive {arr3[indexPositive]}");
        }

        Console.WriteLine();
        Console.WriteLine($"Number of positive elements :: {arr3.Count(IsPositive)}");

        Console.WriteLine();
        var positives = Array.FindAll(arr3, IsPositive);
        Print(positives, "Print all positive elements");

        Console.WriteLine(Array.TrueForAll(arr3,IsPositive));

        //lambda (format param-list) => { .... return ... ;}
        var even = Array.FindAll(arr3, (int e) => {
            e += 2; // ...........
            return e % 2 == 0; });
        Print(even, " Even elements");
        var odd = Array.FindAll(arr3, e => e % 2 != 0);
        Print(odd, " odd elements");

        Console.WriteLine();
        Console.WriteLine();

        Array.Sort(arr3);
        Print(arr3, "Print sord array");
        Array.Reverse(arr3);
        Print(arr3, "Print reverse array");

        string[] colors = { "red", "green", "Yellow", "gold", "Pink", "aqua" };
        Print(colors, "Print Colors       ");
        Array.Sort(colors);
        Print(colors, "Print sorted Colors");
        Array.Sort(colors, (s1, s2) => s1.Length.CompareTo(s2.Length));
        Print(colors, "Print sorted Colors");
    }
    static bool IsPositive(int a) // предикат, логічна функція
    {
        return a > 0;
    }
}
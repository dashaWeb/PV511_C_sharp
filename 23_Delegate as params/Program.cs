internal class Program
{
    delegate bool Condition<T>(T data);
    static int CountInArray<T>(T[] arr, Condition<T> func)
    {
        int counter = 0;
        foreach (var item in arr)
        {
            if (func(item))
                counter++;
        }
        return counter;
    }
    private static void Main(string[] args)
    {
        int[] arr = { 10, -23, 45, 100, -34, -5, 99 };
        var res = Array.FindAll<int>(arr, e => e > 0);
        Console.WriteLine(String.Join("\t",res));

        string[] words = { "Note", "Book", "Ruler", "Rubber" };
        Console.WriteLine(words.All(str => str.Length < 7));

        Console.WriteLine($"Negative elements = {CountInArray(arr,x => x < 0)}");
        Console.WriteLine($"Count of words with letter e = {CountInArray(words,s => s.Contains('e'))}");
    }
}
internal class Program
{
    static void Hello()
    {
        Console.WriteLine("Hello from std delegates (Action)");
    }
    private static void Main(string[] args)
    {
        Action act = Hello;
        act += () => Console.WriteLine("Studing delegate");
        act();

        Action<string, int> act2 = (str, numb) => Console.WriteLine($"#{numb} : {str}");
        act2("Test", 10);

        Func<int, int, double> funcAvg = (a, b) => (a + b) / 2.0;
        Console.WriteLine($"funcAvg :: {funcAvg(10,11)}");

        Predicate<string> pred = s => char.IsUpper(s[0]);

        Console.WriteLine($"Has first upper letter : {pred("Good")}");
        Console.WriteLine($"Has first upper letter : {pred("error")}");

        string[] arr = { "Red", "Green", "blue", "yellow" };
        Console.WriteLine(Array.FindAll(arr,pred).Count());

        Comparison<string> cmp = (s1, s2) => s1.Length.CompareTo(s2.Length);
        string word1 = "Program";
        string word2 = "Python";
        Console.WriteLine($"Test comparison by lenght : {cmp(word1,word2)}"); // 1
        Console.WriteLine($"Test comparison by lenght : {cmp(word2,word1)}"); // -1
    }
}
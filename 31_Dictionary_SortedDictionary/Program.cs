using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> voc = new Dictionary<string, string>()
        {
            ["hello"] = "привіт",
            ["bye"] = "бувай",
            ["program"] = "програма",
            ["developer"] = "програміст"
        };
        Console.OutputEncoding = Encoding.UTF8;
        voc.Add("banana", "банан");
        voc.TryAdd("banana", "банан");
        voc.Remove("hello");
        foreach (var p in voc)
        {
            Console.WriteLine($"{p.Key, -10} {p.Value}");
        }
        SortedDictionary<string, string> vocSorted = new SortedDictionary<string, string>(voc);
        Console.WriteLine("------------------");
        foreach (var p in vocSorted)
        {
            Console.WriteLine($"{p.Key,-10} {p.Value}");
        }
        Console.WriteLine(vocSorted.GetValueOrDefault("banana"));

    }
}
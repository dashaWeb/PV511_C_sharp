using System.Collections;

internal class Program
{
    static void PrintList(IEnumerable al, string text = "")
    {
        Console.WriteLine(text);
        foreach (var item in al)
        {
            Console.Write($"{item, 10}");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        // Неузвгвльнені - елементи типу object
        // не продуктивні для value = boxing - unboxing
        ArrayList al = new ArrayList() { 10, 34.56, "test", true, 900 };

        al[0] = 10.7;
        Console.WriteLine(al.Capacity);
        PrintList(al, "Array List");

        al.Add(456);
        al.AddRange(new int[] { 1, 2, 3 });
        PrintList(al, "Array List");
        Console.WriteLine(al.Capacity);

        al.InsertRange(1, new[] { "one", "two" });
        PrintList(al, "Array List");

        al.Remove("one");
        PrintList(al, "Array List");

        al.RemoveRange(0, 3);
        PrintList(al, "Array List");

        al.RemoveAt(2);
        PrintList(al, "Array List");

        //al.Sort();
        PrintList(al, "Array List");

        al.Clear();
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            al.Add((char)rnd.Next(65, 91));
        }
        PrintList(al, "\n new Array List");
        al.Sort();
        PrintList(al, "\n sort Array List");
        Console.Clear();

        // List

        List<string> li = new List<string>(10)
        {
            "pen", "book","bag","study","copybook"
        };
        PrintList(li, "Print List");
        li.InsertRange(0, new[] { "Ruler", "pupil" });
        PrintList(li, "Print List");

        //li.Remove("pen");
        //li.RemoveAll(w => w.Contains('o'));
        //PrintList(li, "Print List after removell with letter 'o'");

        li.Sort();
        PrintList(li, "Print List sorted");

        li.Sort((s1, s2) => s1.Length.CompareTo(s2.Length));
        PrintList(li, "Print List sorted");

        var res = li.FindAll(s => s.Length > 3);
        PrintList(res, "Print List sorted");
        PrintList(li, "Print List sorted");
    }
}
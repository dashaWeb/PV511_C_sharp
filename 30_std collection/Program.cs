using System.Collections;

internal class Program
{
    static void DemoSortedList()
    {
        System.Collections.SortedList sorted = new System.Collections.SortedList()
        {
            {10, "ten" },
            {5, "five" },
            {7, "seven" },
            {0, "zero" },
        }; // (object key, object value)
        PrintSL(sorted, "Print Sorted List");
        sorted.Add(2, "two");
        sorted[7] = "SEVEN";
        sorted[8] = "eight";
        PrintSL(sorted, "\n Print Sorted List");
        int key = 3;
        Console.WriteLine($"Get access for key {key} :: {sorted[key] ?? "NULL"}");
        if (!sorted.ContainsKey(key))
        {
            sorted.Add(key, "Something");
            Console.WriteLine($"Key {key} was added!!!");
        }
        PrintSL(sorted, "\n Print Sorted List");

        key = 3;
        sorted.Remove(key);
        PrintSL(sorted, $"\n After remove pair with key {key}");
        int index = 0;
        if (index < sorted.Count)
        {
            sorted.RemoveAt(index);
            PrintSL(sorted, $"\n After remove pair with index {index}");
        }
        Console.WriteLine($"Index {index} Key : {sorted.GetKey(index)} Value :: {sorted.GetByIndex(index)}");
    }
    static void DemoSortedListGen()
    {
        SortedList<int, string> sl = new SortedList<int, string>()
        {
            [1000] = "Olena",
            [777] = "Pavlo",
            [555] = "Alex"
        };
        PrintSL(sl, "\n Sorted List ::");
        //sl.TryAdd(1000, "test");
        sl.Add(233, "Vasil");
        PrintSL(sl, "\n Sorted List ::");
        int id = 555;
        if (sl.TryGetValue(id, out string name))
        {
            Console.WriteLine($"Get name by id {id} ::: {name}");
        }
        else
        {
            Console.WriteLine($"Bad access by id {id}");
        }
        sl.Remove(id);
        sl.RemoveAt(0);
        PrintSL(sl, "\n Sorted List ::");
        foreach (var k in sl.Keys)
        {
            Console.WriteLine($"Code : {k} \t Name : {sl[k]}");
        }
    }
    static void PrintSL(IDictionary list, string prompt = "")
    {
        Console.WriteLine(prompt);
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key,-5} {item.Value,-10}");
        }
    }
    private static void Main(string[] args)
    {
        //DemoSortedList();
        DemoSortedListGen();
    }
}
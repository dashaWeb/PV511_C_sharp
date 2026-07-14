class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"Product {Name, -20} Category {Category, -10} Price {Price}";
    }
}
internal class Program
{
    static void Print<T>(IEnumerable<T> list, string prompt)
    {
        Console.WriteLine(prompt);
        foreach (var item in list)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        int[] arrayInt = { 5, 34, 67, -12, 94, -42 };
        // result = from item_name in source_name 
        //          select result_value

        var query = from i in arrayInt
                    select i * -1;


        List<int> query2 = query.ToList();
        Print(arrayInt, "Print Array int");
        Print(query2, "Print Result Query");

        Console.WriteLine("Extend methods ");
        //var result = arrayInt.Select(ConvertData);
        //var result = arrayInt.Select(delegate (int item) { return item * -1; });
        var result = arrayInt.Select(item => item * -1);
        Print(result, "Print result convert ");

        Console.Clear();

        query = from i in arrayInt
                where i % 2 == 0
                select i;
        Print(arrayInt, "Print Array int");
        Print(query, "Only the even elements");

        query = arrayInt.Where(item => item % 2 == 0).Select(i=> i * -1);
        Print(query, "Only the even elements");

        string[] colors = { "purple", "yellow", "brown", "violet", "magenta", "red", "blue" };
        var queryStr = from word in colors
                       where word.Length > 4
                       select word;

        Print(queryStr, "Print result query words");
        queryStr = colors.Where(item => item.Length > 4);
        Print(queryStr, "Print result query words");
        var max = colors.Max(c => c.Length);
        Console.WriteLine($"Max length :: {max}");

        Console.Clear();
        Print(arrayInt, "Print Array int");
        query = from i in arrayInt
                where i % 2 == 0
                orderby i /*descending*/
                select i;
        Print(query, "Print Array int sorted ascending");

        //query = arrayInt.Where(i => i % 2 == 0).OrderBy(i => Math.Abs(i));
        query = arrayInt.Where(i => i % 2 == 0).OrderByDescending(i => Math.Abs(i));
        Print(query, "Print Array int sorted ascending");

        Console.Clear();

        Product[] arr =
        {
            new Product(){Name ="Apple", Category = "Food", Price = 30},
            new Product(){Name ="Phone", Category = "Tech", Price = 30000},
            new Product(){Name ="Laptop", Category = "Tech", Price = 10000},
            new Product(){Name ="Banana", Category = "Food", Price = 50},
            new Product(){Name ="Orange", Category = "Food", Price = 70},
        };

        var queryProduct = from product in arr
                           group product by product.Category;

        foreach (var item in queryProduct)
        {
            Console.Write($"Key : {item.Key} \n\t Value : \n");
            foreach (var item1 in item)
            {
                Console.Write($"\t\t{item1,-20}\n");
            }
            Console.WriteLine();
        }
        queryProduct = arr.GroupBy(p => p.Category);
        foreach (var item in queryProduct)
        {
            Console.Write($"Key : {item.Key} \n\t Value : \n");
            foreach (var item1 in item)
            {
                Console.Write($"\t\t{item1,-20}\n");
            }
            Console.WriteLine();
        }
        Console.Clear();

        int[] mas = { 1, 2, 3, 4, 5 };
        var resAgg = mas.Aggregate((x, y) => x - y);
        // 1 - 2 - 3 - 4 - 5
        Console.WriteLine($"Result :: {resAgg}");
        resAgg = mas.Aggregate((x, y) => x + y);
        // 1 + 2 + 3 + 4 + 5 => 15
        Console.WriteLine($"Result :: {resAgg}");

        string[] words = { "apple", "banana", "orange", "salat" };
        var res_w = words.Select(i => i[0].ToString()).Aggregate((x, y) => x + y);
        Console.WriteLine($"Result :: {res_w}");
        // Count
        int[] numbers = { 1, 2, 10, 34, 55, 66, 77, 88 };
        var size = (from i in numbers
                    where i % 2 == 0 && i > 10
                    select i).Count();
        Print(numbers, "Print numbers");
        Console.WriteLine(size);

        size = numbers.Where(i => i % 2 == 0 && i > 10).Count();
        Console.WriteLine(size);
        size = numbers.Count(i => i % 2 == 0 && i > 10);
        Console.WriteLine(size);

        // Min, Max, Sum, AVG
        foreach(var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Min Price :: {arr.Min(x=>x.Price)}");
        Console.WriteLine($"Max Price :: {arr.Max(x=>x.Price)}");
        Console.WriteLine($"Sum Price :: {arr.Sum(x=>x.Price)}");
        Console.WriteLine($"Avg Price :: {arr.Average(x=>x.Price)}");

        var names = from i in arr
                    //where i.Price > 1000
                    orderby i.Price
                    select i.Name;
        Print(names, "Print name product");
    }
    static int ConvertData(int item)
    {
        return item * -1;
    }
}
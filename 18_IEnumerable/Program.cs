using _18_IEnumerable;

internal class Program
{
    private static void Main(string[] args)
    {
        //Demo demo = new Demo();
        //demo.Test();
        Item apple = new Item() { Name = "Apple", Price = 20 };
        Item grapes = new Item() { Name = "Grapes", Price = 40 };
        Item orange = new Item() { Name = "Orange", Price = 50 };
        Item blueberry = new Item() { Name = "Blueberry", Price = 70 };

        //var bucket = new ShopBucket();
        ShopBucket bucket = new();
        bucket.AddItem(apple);
        bucket.AddItem(grapes);
        bucket.AddItem(orange);
        bucket.AddItem(blueberry);

        Console.WriteLine(bucket);
        Console.WriteLine();
        Console.WriteLine("________ foreach __ (GetEnumerator)______");
        foreach (var product in bucket)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("________ foreach __ (GetReverse())______");
        foreach (var product in bucket.GetReverse())
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("________ foreach __ (GetCheaperItem())______");
        foreach (var product in bucket.GetCheaperItem(40))
        {
            Console.WriteLine(product);
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "info.txt";
        //using (StreamWriter sw = new StreamWriter(fname))
        //{
        //    string line = "Hello from C# Streams";
        //    int value = 123456;
        //    DateTime today = DateTime.Now;
        //    int[] arr = { 10, 20, 30, 40, 50 };

        //    sw.WriteLine(line);
        //    sw.WriteLine($"Value :: {value}");
        //    sw.WriteLine(today);
        //    sw.WriteLine(arr.Length);
        //    foreach (var item in arr)
        //    {
        //        sw.WriteLine(item);
        //    }
        //}


        // 1 way
        Console.WriteLine($"Content ReadAllText :: {File.ReadAllText(@"C:\\Users\\kap19\\Desktop\\test.txt")}");
        // 2 way
        Console.WriteLine($"\n\n Content File.ReadAllLines \n");
        /*var*/ string[] lines = File.ReadAllLines(fname);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"#{i + 1} :::: {lines[i]}");
        }
        Console.WriteLine();

        // 3 way 
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"\n\n Content (ReadToEnd) :: {sr.ReadToEnd()} ");
        }

        // 4 way 
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"\n\n Content (line by line )");
            string line;
            //!sr.EndOfStream
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("End read");

        // 5 way 
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"\n\n Content (char by char )");

            int symbol;

            while((symbol = sr.Read()) != -1)
            {
                Console.WriteLine((char)symbol);
            }
        }
    }
}

// Дано текстовий файл (створити у Блокноті). Зробити статистику.
// Кількість рядків
// Кількість символів
// Кількість слів
// Кількість цифр
// Записати результат у файл


// Кількість голосних букв
// Кількість приголосних букв
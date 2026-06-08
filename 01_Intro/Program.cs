internal class Program
{
    static void ReadFromConsole()
    {
        //char s = (char)Console.Read();
        //Console.WriteLine($"Symbol :: {s}");
        //Console.WriteLine($"Letter :: {char.IsLetter(s)}");
        //Console.WriteLine($"Letter :: {char.ToLower(s)}");

        //string line = Console.ReadLine();
        //Console.WriteLine(line);
        int one, two;
        Console.WriteLine("Enter first number :: ");
        one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number :: ");
        //two = int.Parse(Console.ReadLine());
        if (int.TryParse(Console.ReadLine(), out two))
        {
            Console.WriteLine($"Reasult :: {one + two}");
        }
        else
        {
            Console.WriteLine("Error value");
        }
    }
    private static void Main(string[] args)
    {
        //int number = 10;
        //Console.Write(number + "\n");
        // Raw line
        Console.WriteLine(@"
                            Hello  
                                    \n \t
                                             World 
");
        // write
        Console.WriteLine("H\bello\n \t  \b  \" \' \\ C#");
        // format line
        string name = "Pavlo";
        string lastname = "Bondar", email = "test@gmail.com";
        int age = 18;
        //Console.WriteLine("Name :: " + name + "Surname :: " + lastname + email + age);
        Console.WriteLine(" Name :: {0,20}; \n Lastname :: {1,-20}; \n Email :: {2}; \n Age :: {3}", name, lastname, email, age);
        // interpolation line
        Console.WriteLine($"Name :: {name,10}; \nLastname :: {lastname,10};");
        Console.WriteLine("\n\n Test read console ");
        //ReadFromConsole();
        // +,-, !, a++, a--, --a;
        // +,-,*,/,%, ==, !=, >, <, >=, <=   (and - && , or - ||)
        // 

        //string line = Console.ReadLine();
        //int number;
        //if(int.TryParse(line, out number))
        //{
        //    if (number >= 0 && number <= 20)
        //    {
        //        Console.WriteLine("Ok, in range");
        //    }
        //    else if (number < 0 || number > 20)
        //    {
        //        Console.WriteLine("no ok");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error value");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Error");
        //}

        //int day = Convert.ToInt32(Console.ReadLine());
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    default:
        //        Console.WriteLine("Error number day");
        //        break;
        //}
        //int month = Convert.ToInt32(Console.ReadLine());
        //switch (month)
        //{
        //    case 1:
        //    case 3:
        //    case 5:
        //    case 7:
        //        Console.WriteLine("31 days");
        //        break;

        //}

        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine(i);
        }

        int a = 1;
        while (a < 10)
        {
            Console.WriteLine(a);
            a++;
        }
        //int res;
        //do
        //{
        //    Console.WriteLine("2 + 2 = ");
        //     res = int.Parse(Console.ReadLine());

        //}
        //while (res != 4);

        do
        {
            Console.WriteLine("2 + 2 = ");
            int res = int.Parse(Console.ReadLine());
            if (res == 4)
                break;

        }
        while (true);

    }
}
/*
 multi lines
 */
// single line
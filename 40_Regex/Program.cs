using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // numbers
        //string pattern = @"\d";
        //var reg = new Regex(pattern);
        //bool flag = true;
        //while (flag)
        //{
        //    string str = Console.ReadKey().KeyChar.ToString();
        //    if (str == " ")
        //        flag = false;

        //    bool success = reg.IsMatch(str);
        //    Console.WriteLine(success ? $" match found {pattern}" : $" match not found {pattern}");
        //}

        var array = new[] { "test", "123", "test123test", "123test", "test123", "123test123" };
        //string pattern = @"\d"; // одна цифра
        //string pattern = @"\d+"; // одна і більше
        //string pattern = @"\d*"; // 0 і більше
        //string pattern = @"\d?"; // 0 або 1
        //string pattern = @"^\d$"; // one number
        //string pattern = @"^\d+$"; // one number
        //string pattern = @"^\d{3}$"; // рядок з 3 цифр
        //string pattern = @"\d{1,2}\w"; // 
        //string pattern = @"\d{1,2}[A-Za-z0-9]{5}"; // 
        //var regex = new Regex(pattern,RegexOptions.IgnoreCase);
        //foreach (var element in array)
        //{
        //    //Console.WriteLine(
        //    //        regex.IsMatch(element)
        //    //        ? $"String '{element}' matched '{pattern}'"
        //    //        : $"String '{element}' NOT matched '{pattern}'"
        //    //        );
        //    //Console.WriteLine(new string('-',50));

        //    Match match = Regex.Match(element, pattern);
        //    while (match.Success)
        //    {
        //        Console.WriteLine($"{element,-20} '{pattern,-20}' {regex.IsMatch(element),-5}  --> {match.Value}");
        //        match = match.NextMatch();
        //    }

        //}

        //Match m = Regex.Match("123 Axx-1xxy \n Axyx-2-xyyxy", @"A.*y");
        //while(m.Success)
        //{
        //    Console.WriteLine($"Value :: {m.Value}");
        //    Console.WriteLine($"Length :: {m.Length}");
        //    Console.WriteLine($"Index :: {m.Index}");
        //    Console.WriteLine(new string('-',50));

        //    m = m.NextMatch();
        //}

        //string str = "saidsaid said see spread super said";
        //MatchCollection matches = Regex.Matches(str, @"s\w+d");
        //foreach (Match match1 in matches)
        //{
        //    Console.WriteLine($"{match1.Value, -15} {match1.Index, -5} {match1.Length, -5}");
        //}

        //var str = "Dont replace Dot Net replaced Net Net dots";
        //string output = Regex.Replace(str, @"N.t", "NET");
        //Console.WriteLine(str);
        //Console.WriteLine(output);

        string text = "test test 458796589 args args 457895874 test test 457854789 test ";
        // +38(045)-12-45-458;
        //var output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})","+38(0$1)-$2-$3-$4");
        var output = Regex.Replace(text, @"\d{9}",(m) => String.Format("{0:+38(0##)-##-##-###}",Convert.ToInt64(m.Value)));
        Console.WriteLine(text);
        Console.WriteLine(output);

    }
}
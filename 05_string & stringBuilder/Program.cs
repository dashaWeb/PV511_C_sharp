
using System.Text;

internal class Program
{
    static int sum(int a, int b) => a + b;
    static int sum(int a, int b, int c) => a + b + c;
    //static int sum(int text, params int[] numb) => numb.Sum() / text;
    static int sum(int text, params int[] numb)
    {
        Console.WriteLine($"Sum :: {numb.Sum()}" );
        Console.WriteLine($"Min :: {numb.Min()}" );
        Console.WriteLine($"Max :: {numb.Max()}" );
        Console.WriteLine($"Average :: {numb.Average()}" );
        return numb.Sum();
    }
    private static void Main(string[] args)
    {
        // string -- immtable
        // System.Text.StringBuilder = new System.Text.StringBuilder()
        //string text = "lorem ipsum dolor C#";
        //Console.WriteLine(text[0]);
        ////text[0] = 'L';
        //StringBuilder text2 = new StringBuilder(text);
        //text2[0] = 'L';
        string text = "lorem ipsum dolor C#";
        char[] chars = text.ToCharArray();
        chars[0] = Char.ToUpper(chars[0]);
        Console.WriteLine(text);
        Console.WriteLine(chars);
        text = new string(chars);
        Console.WriteLine(text);

        // Methods
        string word = "C#";
        Console.WriteLine($"\n Contains '{word}' :: {text.Contains(word)}");
        Console.WriteLine($"\n Indexof  '{word}' :: {text.IndexOf(word)}"); // -1 not found
        Console.WriteLine($"\n StartsWith  '{word}' :: {text.StartsWith(word)}"); // -1 not found
        Console.WriteLine($"\n EndsWith  '{word}' :: {text.EndsWith(word)}"); // -1 not found
        string letters = "ips";
        int index = text.IndexOfAny(letters.ToCharArray());
        if(index != -1)
        {
            Console.WriteLine($"\n Index of first from '{letters}' :: {index}. Letter :: {text[index]}");
        }

        string one = "Apple", two = "Apricot"; // one < two
        Console.WriteLine($"{one} == {two} --> {one == two}"); // 
        Console.WriteLine($"{one}.CompareTo({two}) --> {one.CompareTo(two)}"); // 
        two = "apple";
        Console.WriteLine($"{one}.CompareTo({two}) --> {one.CompareTo(two)}"); // 1 ( A > a)
        Console.WriteLine($"{one}.CompareTo({two}) --> {string.CompareOrdinal(one,two)}"); // 1 ( a(97) > A(65))
        Console.WriteLine($"{one}.CompareTo({two}) --> {string.Compare(one,two,true)}"); // 1 ( a(97) > A(65))

        Console.WriteLine($"Origin Text :: {text}");
        Console.WriteLine($"text.Remove -- > {text.Remove(5,10)}");
        Console.WriteLine($"text.Replace -- > {text.Replace("C#","JavaScript")}");
        Console.WriteLine($"text.Insert -- > {text.Insert(0,"Next Text")}");
        Console.WriteLine($"text.Substring -- > {text.Substring(5,10)}");

        string number = "1,2,3,4, 5,6, 7,8,9";
        string[] numbers = number.Split(',',' ',StringSplitOptions.TrimEntries);
        foreach(var @char in numbers)
        {
            Console.WriteLine(@char);
        }

        string[] color = { "red", "green", "yellow" };
        Console.WriteLine(String.Join("\n",color));

        Console.WriteLine(sum(1,2));
        Console.WriteLine(sum(1,2,3));
        Console.WriteLine(sum(100, 1,2,3,4,5,6,7,8,9,10));

        StringBuilder text2 = new StringBuilder(text);
        Console.WriteLine(text2);
        text2.Append("test test test");
        Console.WriteLine(text2);
        text2.Insert(0,"test");
        Console.WriteLine(text2);
        text2.Replace("test","C#");
        Console.WriteLine(text2);
        text2.Remove(10,5);
        Console.WriteLine(text2);

        Console.WriteLine(text);
        var res = text.Split(' ');
        Console.WriteLine(res[0]);
        Array.Reverse(res);
        Console.WriteLine(res[0]);
        text = string.Join(' ', res);
        Console.WriteLine(text);
    }
}
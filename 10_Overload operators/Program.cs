using _10_Overload_operators;

internal class Program
{
    private static void Main(string[] args)
    {
        //string str1 = "line 1";
        //string str2 = "line 2";
        //var str = str1 + str2;
        Fraction one = new Fraction(1, 2);
        Fraction two = new Fraction(3, 4);
        Console.WriteLine(one[0] + "/" + one[1]);

        Fraction res = one + two;
        Console.WriteLine($"Result :: {res}");
        Console.WriteLine(one + " + " + two + " = " + (one + two));

        res += one;
        Console.WriteLine(res);

        Fraction first = new Fraction(2, 3);
        Fraction second = first;

        Console.WriteLine(first + " " + second);
        first[0] = 33;
        Console.WriteLine(first + " " + second);

        Console.WriteLine($"{one} == {two} = {one == two}");
        Console.WriteLine($"{one} != {two} = {one != two}");
        Console.WriteLine($"{first} == {second} = {first == second}");
        Console.WriteLine($"{first} != {second} = {first != second}");
        if(one)
        {
            Console.WriteLine("overload true");
        }
        two[0] = 0;
        if (two)
        {
            Console.WriteLine("overload true");
        }
        else
        {
            Console.WriteLine("overload false");
        }
        Console.WriteLine(one);
        Console.WriteLine(one++);
        Console.WriteLine(one);
        Console.WriteLine(++one);

        Console.WriteLine(one);
        Fraction test = new Fraction(1, 2);
        int value = (int)test;
        Console.WriteLine($" one cast to int {value}");
        Console.WriteLine($" one cast to int {(int)test}");

        double dValue = test;
        Console.WriteLine($" one cast to double {dValue}"); ;
        Console.WriteLine($" one cast to double {(double)test}"); ;
    }
    // Визначити для Дробу оператор *
}
/*
 if(5)
{
cout << "True" ;
}
 */
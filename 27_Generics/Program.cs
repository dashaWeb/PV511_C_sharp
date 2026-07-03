class Person<T> : IComparable<Person<T>>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public T Test { get; set; }
    public int CompareTo(Person<T>? other)
    {
        if (other is null)
            return 1;
        //return this.Name.CompareTo(other.Name); 
        return this.Age.CompareTo(other.Age);
    }
    virtual public void Busy()
    {
        Console.WriteLine($"Person {Name} is busy ..... ---> Test : {Test}");
    }
}

class Employee<T> : Person<T>
{
    public override void Busy()
    {
        Console.WriteLine($"Employee {Name} is working");
    }
}
class Student<T>:Person<T>
{

}
internal class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    // contraints - обмеження на тип
    static T Max<T>(T one, T two) where T : IComparable<T>
    {
        return one.CompareTo(two) > 0 ? one : two; 
    }
    static void CheckBusy<T,T2>(T person) where T : Person<T2>
    {
        person.Busy();
    }
    private static void Main(string[] args)
    {
        int a = 5, b = 7;
        double one = 20.2, two = 4.5;
        Console.WriteLine($"a   = {a, -20}  b = {b}");
        Console.WriteLine($"one = {one,-20}  two = {two}");
        Swap<int>(ref a, ref b);
        Swap<double>(ref one, ref two);
        Console.WriteLine();
        Console.WriteLine($"a   = {a,-20}  b = {b}");
        Console.WriteLine($"one = {one,-20}  two = {two}");

        Console.WriteLine($"Max :: {Max(one,two)}");
        Person<string> p1 = new Person<string> { Name = "Oleg", Age = 20, Test = "Test Generic" };
        Person<string> p2 = new Person<string> { Name = "Ivanna", Age = 25, Test = "Test Generic" };
        Console.WriteLine($"Max({p1.Name},{p2.Name}) = {Max(p1,p2).Name}");
        Console.WriteLine();
        CheckBusy<Person<string>, string>(p1);
        Employee<string> emp = new Employee<string> { Name = "Alex", Age = 34 };
        CheckBusy<Person<string>, string>(emp);
        Student<string> st = new Student<string> { Name = "Pavlo" };
        CheckBusy<Person<string>, string>(st);

    }
}
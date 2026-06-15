using _07_Static_field___method;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main started");
        Console.WriteLine($"Last id {Employee.LastId}");
        Employee emp1 = new Employee() { Name = "Pavlo", Birth = DateTime.Parse("30/10/2000"), Position = Position.QA };
        Console.WriteLine(emp1);

        Employee emp2 = new Employee()
        {
            Name = "Alex",
            Birth = new DateTime(2001, 9, 16),
            Position = Position.QA
        };
        Console.WriteLine(emp2);

        Console.WriteLine($"Same position :: {Employee.SomePosition(emp1,emp2)}");
        Console.WriteLine(emp1.ID);
        //emp1.ID = 111; readonly
    }
}
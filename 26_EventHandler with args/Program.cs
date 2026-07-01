using _26_EventHandler_with_args;

internal class Program
{
    private static void Main(string[] args)
    {
        Company softServe = new Company { Name = "SoftServe" };
        Company honeyComb = new Company { Name = "HoneyComb" };

        Interviwer ann = new Interviwer { Name = "Ann" };
        Interviwer alex = new Interviwer { Name = "Alex" };


        softServe.NewPosition += ann.DoSomething;
        softServe.NewPosition += alex.DoSomething;

        honeyComb.NewPosition += ann.DoSomething;
        honeyComb.NewPosition += alex.DoSomething;

        softServe.AddPosition("Intern C++");
        Console.WriteLine();
        honeyComb.AddPosition("Junior .NET");
        Console.WriteLine();

        honeyComb.NewPosition -= ann.DoSomething;
        Console.WriteLine();
        honeyComb.AddPosition("Middle Frontend");
    }
}
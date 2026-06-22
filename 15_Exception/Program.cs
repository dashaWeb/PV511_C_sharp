
using _15_Exception;

internal class Program
{
    static double DivisionNumber(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Division by zero");

        return a / b;
    }
    private static void Main(string[] args)
    {
        //double a, b;
        //while (true)
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter two number");
        //        a = double.Parse(Console.ReadLine());
        //        b = double.Parse(Console.ReadLine());
        //        double result = DivisionNumber(a, b);
        //        Console.WriteLine($"{a} / {b} = {result}");
        //        break;
        //    }
        //    catch (DivideByZeroException ex)
        //    {

        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("\t" + ex.Message);
        //        Console.ResetColor();
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("\t FormatException " + ex.Message);
        //        Console.ResetColor();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("\t Exception " + ex.Message);
        //        Console.ResetColor();
        //    }
        //}
        //Console.WriteLine("Test Exception final");

        Product product = new Product();
        try
        {
            product.Name = "Bread";
            Console.WriteLine(product.Name);
            product.DateIn = new DateTime(2026, 06, 22, 0, 0, 0);
            product.InputName();
        }
        catch (BadProductDateException ex)
        {

            Console.WriteLine($"Message error :: {ex.Message}");
            Console.WriteLine($"Bad value date :: {ex.ErrorDate}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Message   :: {ex.Message} ");
            Console.WriteLine($"Value     :: {ex.Data["Value"]} ");
            Console.WriteLine($"TimeStamp :: {ex.Data["TimeStamp"]} ");
            Console.WriteLine($"TargetSite :: {ex.TargetSite} ");

            foreach (var item in ex.Data.Keys)
            {
                Console.WriteLine($"{item} -------> {ex.Data[item]}");
            }
        }
        Console.WriteLine("Test ---------------- ");
    }
}
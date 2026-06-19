internal class Program
{
    private static void Main(string[] args)
    {
        double value = 12.5;
        int valueInt = 10;
        string str2 = "line 111";
        object obj = str2;//valueInt;//value; // boxing obj ---> heap[12.5]
        
        Console.WriteLine($"obj = {obj} has type {obj.GetType()}");

        int a = 4;
        //var res = a + obj;
        //if(obj is double)
        //{
        //    double valueDB = (double)obj;
        //    Console.WriteLine($"Unboxing from obj into double {valueDB}");
        //}
        switch (obj)
        {
            case int val: // 1. obj is int; 2. val = (int)obj;
                Console.WriteLine($"Unboxing from obj into int {val}");
                break;
            case double val: // 1. obj is int; 2. val = (int)obj;
                Console.WriteLine($"Unboxing from obj into double {val}");
                break;
            case string str: // 1. obj is int; 2. val = (int)obj;
                Console.WriteLine($"Unboxing from obj into string {str}");
                break;
            default:
                break;
        }

    }
}
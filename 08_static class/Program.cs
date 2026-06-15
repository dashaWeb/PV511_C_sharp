

// static class; 1) може містити тільки статичні поля та методи; 2) не можна створити екземпляр
static class AreaShapes
{
    const double PI = 3.14; // константа у С# неявно статична
    public static double TrianArea(double height, double side) => height * side * 0.5;
    public static double CircleArea(double radius) => PI * Math.Pow(radius,2);

}
internal class Program
{
    private static void Main(string[] args)
    {
        //AreaShapes test = new AreaShapes();
        Console.WriteLine($"Trian area :: {AreaShapes.TrianArea(10,20)}");
    }
}
using _28_Generic___Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>(10);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Peek());
            stack.Pop();
        }
    }
}
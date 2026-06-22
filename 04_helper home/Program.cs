internal class Program
{
    private static void Main(string[] args)
    {
        const int ROW = 5, COL = 5;

        Random rand = new Random();

        int[,] arr = new int[ROW, COL];


        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                arr[i, j] = rand.Next(-100, 100);
            }
        }

        int min = arr[0, 0];
        int max = arr[0, 0];
        int minI = 0;
        int minJ = 0;
        int maxI = 0;
        int maxJ = 0;

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    minI = i;
                    minJ = j;
                }
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    maxI = i;
                    maxJ = j;
                }

            }
        }

        int sum = 0;

        int q = minJ;
        for (int i = minI; i <= maxI; i++)
        {
            for (; q < arr.GetLength(1); q++)
            {
                sum += arr[i, q];
                Console.WriteLine(arr[i, q] + "\t");
            }
            if (i == maxI && q == maxJ)
                break;
            q = 0;
        }

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Min ({minI},{minJ}) Max {maxI}{maxJ}");
        Console.WriteLine(sum);
    }
}
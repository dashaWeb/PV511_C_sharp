internal class Program
{
    static void Print<T>(T[,] arr, string prompt = "")
    {
        Console.WriteLine(prompt);
        //foreach (var item in arr)
        //{
        //    Console.Write(item + "\t");
        //}
        //Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-20}");
            }
            Console.WriteLine();
        }
    }
    static void Print(int[][] arr, string prompt = "")
    {
        Console.WriteLine(prompt);
        //for (int i = 0; i < arr.Length; i++) // row
        //{
        //    for (int j = 0; j < arr[i].Length; j++) // col 
        //    {
        //        Console.Write($"{arr[i][j],-20}");
        //    }
        //    Console.WriteLine();
        //}
        foreach(var row in arr)
        {
            foreach (var item in row)
            {
                Console.Write($"{item,-20}");
            }
            Console.WriteLine();
        }

    }
    static int[][] Create(int row)
    {
        int[][] arr = new int[row][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[new Random().Next(5, 10)];
        }
        return arr;
    }
    static void Fill(int[][] arr, int min = 1, int max = 10)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = rnd.Next(min, max);
            }
        }
    }
    static void SwapRows(int[][] arr, int row1, int row2)
    {
        if(row1 >= 0 && row2 >= 0 && row1 < arr.Length && row2 < arr.Length)
        {
            int[] tmp = arr[row1];
            arr[row1] = arr[row2];
            arr[row2] = tmp;
        }
    }
    private static void Main(string[] args)
    {
        int[,] arr = new int[3, 4]
        {
            {1,2,3,4 },
            {10,20,30,40 },
            {100,200,300,400 }
        };
        Console.WriteLine(arr.Length);
        Console.WriteLine(arr[0, 2]);
        Print(arr);

        int[][] arr2 = new int[3][];
        arr2[0] = new int[] { 1, 2, 3 };
        arr2[1] = new int[] { 1, 2, 3, 4, 5 };
        arr2[2] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        Print(arr2, "Print Array Jugged");

        var arr3 = Create(4);
        Fill(arr3);
        Print(arr3, "\nPrint new Array :: ");
        SwapRows(arr3, 0, arr3.Length - 1);
        Print(arr3, "\nAfter SwapRows :: ");

        //int[,,] arr4 = new int[2, 3, 4]
        //{
        //    { // 0
        //        { 1,2,3,4}, //0
        //        { 1,2,3,4}, // 1
        //        { 1,2,3,4}  // 2
        //    },
        //    { // 1
        //        {2,5,4,7 },
        //        {2,5,4,7 },
        //        {2,5,4,7 }
        //    }
        //};
        //arr4[0, 1, 2] = 11;

        //int[][][] arr5 = new int[2][][];
        //arr5[0] = new int[3][];
        //arr5[1] = new int[2][];

        //arr5[0][0] = new int[4];
        //arr5[0][1] = new int[4];
        //arr5[0][3] = new int[4];
    }
}
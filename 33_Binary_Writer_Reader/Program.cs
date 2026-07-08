internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "my.dat";
        //using (BinaryWriter bw = new BinaryWriter(new FileStream(fname,FileMode.Create)))
        //{
        //    string test = "Test - line Тестовий рядок";
        //    int valueI = 45623;
        //    double valueD = -23.456;
        //    int[] array = { 10, 20, 30, 40, 50 };


        //    bw.Write(test);
        //    bw.Write(valueI);
        //    bw.Write(valueD);

        //    bw.Write(array.Length);
        //    foreach (var item in array)
        //    {
        //        bw.Write(item);
        //    }
        //}

        using(BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {
            string readStr = br.ReadString();
            Console.WriteLine($"Read str    :: {readStr}");
            Console.WriteLine($"Read int    :: {br.ReadInt32()}");
            Console.WriteLine($"Read double :: {br.ReadDouble()}");
            Console.WriteLine("Recovered Array ");
            int[] readArray = new int[br.ReadInt32()];
            for (int i = 0; i < readArray.Length; i++)
            {
                readArray[i] = br.ReadInt32();
                Console.Write($"{readArray[i], 7}");
            }
            Console.WriteLine();
        }

    }
}
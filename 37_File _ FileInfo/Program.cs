internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = { "First line", "Second line" };
        string fname = "../../../my.txt";
        File.SetAttributes(fname, FileAttributes.Archive);
        if (File.Exists(fname))
        {
            File.Delete(fname);
            Console.WriteLine($"File '{fname}' was deleted \n\n");
        }
        File.AppendAllLines(fname, lines);
        File.AppendAllText(fname, $"Third line \nFourth line\n");

        Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");
        string fname2 = "../../../copy_my.txt";
        File.Copy(fname, fname2,true);


        Console.WriteLine($"Content of file '{fname2}' \n{File.ReadAllText(fname2)}");

        //FileStream fs = File.Create(fname);
        //var fs = File.AppendText(fname);
        var fs = File.CreateText(fname);
        fs.WriteLine("Write Someting ... ");
        fs.Dispose();

        File.AppendAllText(fname, "New line");

        Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");

        Console.WriteLine($"Creation time {File.GetCreationTime(fname).ToShortTimeString()}");
        Console.WriteLine($"Creation time {File.GetLastWriteTime(fname)}");

        string fname3 = "../../../third.txt";
        FileInfo fi = new FileInfo(fname3);
        Console.WriteLine($"\n\n Is exists file : {fname3} --> {fi.Exists}");
        if(!fi.Exists)
        {
            using (var tw = fi.CreateText())
            {
                tw.WriteLine("It is third file");
            }
        }
        Console.WriteLine($"Content of file {fname3} \n{File.ReadAllText(fname3)}");

        //fi.MoveTo("./third.txt"); // net8.0
        //string path = @"C:\Users\kap19\Desktop" + @"\third.txt";
        Console.WriteLine($"Move to path {Path.Combine(".", "third.txt")}");
        Console.WriteLine($"Move to path {Path.Combine(@"C:\Users\kap19\Desktop", "third.txt")}"); // bad
        Console.WriteLine($"Move to path {Path.Combine(@"C:\Users\kap19\Desktop", fi.Name)}"); // bad
        //fi.MoveTo(Path.Combine(@"C:\Users\kap19\Desktop", fi.Name));

        Console.WriteLine($"Length of {fi.Name} ::: {fi.Length}");
        Console.WriteLine($"Extension of {fi.Name} ::: {fi.Extension}");
        Console.WriteLine($"File attributes of {fname} : {File.GetAttributes(fname)}");
        File.SetAttributes(fname, FileAttributes.ReadOnly);
        Console.WriteLine($"File attributes of {fname} : {File.GetAttributes(fname)}");
    }
}
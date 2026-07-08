using System;
using System.Text;

internal class Program
{
    static void writeString(string value, string path)
    {
        //using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        //{
        //    byte[] bytes = Encoding.Unicode.GetBytes(value);
        //    Console.WriteLine($"Test bute array : {String.Join(" ", bytes)}");
        //    fs.Write(bytes, 0, bytes.Length);
        //}
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            byte length = (byte)bytes.Length; // (ок при умові що рядки не будуть перевищувати 255 символів)
            fs.WriteByte(length);
            Console.WriteLine($"Size :: {length} \n Test bute array : {String.Join(" ", bytes)}");

            fs.Write(bytes, 0, bytes.Length);
        }
    }
    static void readString(string path)
    {
        string value = String.Empty;
        //using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        //{
        //    byte[] bytes = new byte[fs.Length];
        //    fs.Read(bytes, 0, bytes.Length);
        //    value = Encoding.Unicode.GetString(bytes);
        //    Console.WriteLine($"Result read file :: {value}");
        //}
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte lenght = (byte)fs.ReadByte();
            byte[] bytes = new byte[lenght];
            fs.Read(bytes, 0, bytes.Length);
            value = Encoding.Unicode.GetString(bytes);
            Console.WriteLine($"Size :: {lenght} \t Result read file :: {value}");
        }
    }
    static void writeInt(int value, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Console.WriteLine($"Test byte array : {String.Join(" ", bytes)}");
            fs.Write(bytes, 0, bytes.Length);
        }
    }
    static void readInt(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            int value = 0;
            //byte[] bytes = BitConverter.GetBytes(value);
            byte[] bytes = new byte[sizeof(int)];
            fs.Read(bytes, 0, bytes.Length);

            value = BitConverter.ToInt32(bytes);
            Console.WriteLine($"Result :: {value}");
        }
    }
    private static void Main(string[] args)
    {
        //string name = "bytes.dat";
        //using (FileStream file = new FileStream(name, FileMode.OpenOrCreate))
        //{
        //    byte byteValue = 65;
        //    byte[] array = { 122, 123, 124, 125, 14, 15 }; // 0 - 255

        //    file.WriteByte(byteValue);
        //    file.Write(array, 0, array.Length);
        //    Console.WriteLine($"Position file cursor :: {file.Position}");

        //    file.Position = 0;
        //    //file.Seek(0, SeekOrigin.Begin);
        //    //file.Seek(-2, SeekOrigin.End);
        //    //file.Seek(5, SeekOrigin.Current);
        //    Console.WriteLine($"Position file cursor :: {file.Position}");
        //    Console.WriteLine($"File size in bytes : {file.Length}");
        //    byte[] result = new byte[file.Length];
        //    file.Read(result, 0, result.Length);
        //    Console.WriteLine($"File read :: {String.Join('\t',result)}");

        //    //file.Close();
        //    // file.Dispose(); // неявно спрацює    
        //}
        //writeString("Lorem ipsum", "string.dat");
        //readString("string.dat");
        //writeInt(333, "number.dat");
        readInt("number.dat");
    }
}
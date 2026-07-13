internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Current path : \n{Directory.GetCurrentDirectory()}");
        Directory.CreateDirectory("A");
        Directory.SetCurrentDirectory("A");
        Console.WriteLine($"Current path : \n{Directory.GetCurrentDirectory()}");
        Directory.CreateDirectory("A1");
        Directory.CreateDirectory("A2");
        File.WriteAllText("a.txt", "File a.txt content");
        File.WriteAllText("b.txt", "File b.txt content");

        File.WriteAllText("A1/a1.txt", "File a1.txt content");
        File.WriteAllText("A2/a2.txt", "File a2.txt content");

        var fnames = Directory.GetFiles(".", "a*.*");
        fnames = Directory.GetFiles(".", "*.*", SearchOption.AllDirectories);
        Console.WriteLine(String.Join("\n", fnames));
        foreach (var item in fnames)
        {
            Console.WriteLine($"{Path.GetFileName(item)} in folder {Path.GetDirectoryName(item)}");
        }
        string[] dirs = Directory.GetDirectories(".");
        Console.WriteLine("\n\n List folders from folder A");
        foreach (var item in dirs)
        {
            Console.WriteLine(Path.GetFileName(item));
        }



        string path = @"C:\Users\kap19\Documents";
        var entries = Directory.GetFileSystemEntries(path);
        Console.WriteLine($"\n\n ---------------------------- {path}");
        foreach (var item in entries)
        {
            FileInfo fi = new FileInfo(item);
            string info = "<DIR>";
            if (!fi.Attributes.HasFlag(FileAttributes.Directory))
            {
                info = fi.Length.ToString();
            }
            Console.WriteLine($"{fi.CreationTime,-22}{fi.Name,-50} {info,-15}");
        }

        path = "B";
        DirectoryInfo di = new DirectoryInfo(path);
        if(!di.Exists)
        {
            di.Create();
        }
        Console.WriteLine($"Attrb of 'B' :: {di.Attributes}");
        File.WriteAllText("B/b1.txt", "hello from b1.txt");
        File.WriteAllText("B/b2.txt", "hello from b2.txt");

        FileInfo[] listFI = di.GetFiles();
        foreach (var item in listFI)
        {
            Console.WriteLine($"{item.Name} :: {item.Length}");
        }
        Console.Clear();

        var watcher = new FileSystemWatcher
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };

        watcher.Created += WatcherChanged;
        watcher.Deleted += WatcherChanged;
        watcher.Renamed += WatcherChanged;
        watcher.Changed += WatcherChanged;
        watcher.EnableRaisingEvents = true;

        Console.ReadKey();


    }
    static void WatcherChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Directory changed {e.ChangeType} {e.FullPath}");
    }
}
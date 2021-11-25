using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var location = Path.Combine(Directory.GetCurrentDirectory(),"CsvFile");

        SortFilesWithOutLinq(location);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("********************************************");
        Console.ResetColor();

        SorFilesWithLinq(location);

    }

    public static void SorFilesWithLinq(string location)
    {
        var files = new DirectoryInfo(location).GetFiles()
            .OrderBy(f => f.Length).Take(5);
        
        foreach (var file in files)
        {
            Console.WriteLine($"Name:{file.Name} ************ Length:{file.Length}");
        }
    }

    public static void SortFilesWithOutLinq(string location)
    {
        var DirInfo = new DirectoryInfo(location);
        FileInfo[] files = DirInfo.GetFiles();

        Array.Sort(files, (x, y) =>
        {
            if (x.Length == y.Length)
            {
                return 0;
            }else if (x.Length > y.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        });

        for (int i = 0; i < files.Length; i++)
        {
            FileInfo file = files[i];
            Console.WriteLine($"Name:{file.Name} ************ Length:{file.Length}");
        }
    }
}
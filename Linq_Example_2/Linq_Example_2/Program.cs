using System;
using System.IO;

namespace Linq_Example_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var location = Path.Combine(Directory.GetCurrentDirectory(), "CvsFile");

            SortfilesWhitOutLinq(location);

            
        }

        public static void SortfilesWhitOutLinq(string location)
        {
            var DirInfo = new DirectoryInfo(location);
            FileInfo[] files = DirInfo.GetFiles();

            Array.Sort(files, (x, y) =>
            {
                if (x.Length == y.Length)
                {
                    return 0;
                }
                else if (x.Length > y.Length)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }

            });

            for (int i = 0; i <files.Length; i++)
            {
                FileInfo file = files[i];

                Console.WriteLine($"{file.Name}****** {file.Length}");
            }
        }
    }
}

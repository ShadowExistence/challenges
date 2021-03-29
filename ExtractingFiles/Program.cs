using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace ExtractingFiles
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Rootfolder: ");
            string rootFolder = Console.ReadLine();
            Console.WriteLine("\n");
            var directories = Directory.GetDirectories(rootFolder);

            if (!Directory.Exists(rootFolder))
            {
                Console.WriteLine("The rootfolder doesn't exist");

            }
            else
            {
                //string[] files = Directory.GetFiles(rootFolder, "*ProfileHandler.cs", SearchOption.AllDirectories);

                for (int folderCount = 0; folderCount < directories.Length; folderCount++)
                {
                    //directories[folderCount] = directories[folderCount].Replace('\\', '/');

                    string[] files = Directory.GetFiles(directories[folderCount], "*.mp3", SearchOption.AllDirectories);

                    for (int fileCount = 0; fileCount < files.Length; fileCount++)
                    {
                        File.Move(files[fileCount], $"{rootFolder}/Muzyka{i}.mp3");
                        i++;
                        Console.WriteLine($"Replaced {files[fileCount]} to {rootFolder}");
                    }
                }

                Console.WriteLine("\n\n Fajnie działa ny :D");
                
            }
            Console.ReadLine();
        }
    }
}

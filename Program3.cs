using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CopyFile("C:\\Users\\pc15\\source\repos\\ConsoleApp12\\App.config\\source.txt", "destination.txt");
            Console.WriteLine("Файл успешно скопирован!");
        }

        static void CopyFile(string sourcePath, string destinationPath)
        {
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                sourceStream.CopyTo(destinationStream);
            }
        }
    }
}
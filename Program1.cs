using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile("C:\\Users\\pc15\\source\repos\\ConsoleApp10\\App.config\\output.txt", "Привет, мир!");
        }

        static void WriteToFile(string filePath, string message)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(message);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Write(byteArray, 0, byteArray.Length);
            }

            Console.WriteLine($"Сообщение записано в файл: {filePath}");
        }
    }
}
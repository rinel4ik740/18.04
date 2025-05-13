using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = ReadFromFile("C:\\Users\\pc15\\source\repos\\ConsoleApp11\\App.config\\output.txt");
            Console.WriteLine(text);
        }

        static string ReadFromFile(string filePath)
        {
            byte[] byteArray;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byteArray = new byte[fileStream.Length];
                fileStream.Read(byteArray, 0, byteArray.Length);
            }

            string message = System.Text.Encoding.UTF8.GetString(byteArray);
            return message;
        }
    }
}
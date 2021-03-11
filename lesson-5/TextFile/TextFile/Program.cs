using System;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "TextFile.txt";
            Console.WriteLine("Введите какой-нибудь текст:");
            string text = Console.ReadLine();
            File.WriteAllText(filename, text);
            Console.ReadLine();
        }
    }
}

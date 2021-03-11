using System;
using System.IO;

namespace CurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string textfile = "startup.txt";
            File.AppendAllText(textfile, $"{DateTime.Now.ToString()} ");
            Console.ReadLine();
        }
    }
}

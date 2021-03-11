using System;
using System.IO;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "textfile.txt";
            byte[] array = new byte[5];
            byte[] array1 = new byte[5];
            Console.WriteLine("Введите пять любых чисел от 0 до 255 (каждое число в новой строке):");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToByte(Console.ReadLine());
            }
            File.WriteAllBytes(file, array);
        }
    }
}

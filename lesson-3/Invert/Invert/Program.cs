using System;

namespace Invert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string FirstString = Console.ReadLine();
            for (int i = FirstString.Length - 1; i > -1; i--)
            {
                Console.Write(FirstString[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32 (Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine("Это число чётное");
            }
            else
            {
                Console.WriteLine("Это число не является чётным");
            }
            Console.ReadLine();
        }
    }
}

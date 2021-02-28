using System;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array =
            {
                //1    2    3    4    5    6    7    8    9    10
                {'o', 'x', 'x', 'x', 'x', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'x'},
                {'o', 'o', 'o', 'o', 'o', 'x', 'x', 'o', 'o', 'x'},
                {'o', 'x', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'x'},
                {'o', 'o', 'o', 'o', 'x', 'o', 'o', 'o', 'o', 'o'},
                {'x', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'x', 'o', 'x', 'o', 'o', 'o', 'o', 'o', 'x', 'o'},
                {'o', 'o', 'x', 'o', 'o', 'o', 'o', 'o', 'o', 'o'},
                {'o', 'o', 'x', 'o', 'o', 'o', 'o', 'o', 'o', 'x'},
                {'o', 'o', 'o', 'o', 'o', 'x', 'x', 'o', 'o', 'o'},
            };

            string name = "Морской бой 1.0";
            string horizontal = new string('-', 20);
            string letters = "А Б В Г Д Е Ж З И К";
            Console.WriteLine(name.PadLeft (20));
            Console.WriteLine(horizontal.PadLeft(23));
            Console.WriteLine(letters.PadLeft (23));
            Console.WriteLine(horizontal.PadLeft(23));

            for (int i = 0; i < 10; i++)
            {
                if (i != 9)
                {
                    Console.Write($"{i + 1} |");
                }
                else
                {
                    Console.Write($"{i + 1}|");
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

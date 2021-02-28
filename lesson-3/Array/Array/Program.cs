using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 3];
            Console.WriteLine("Введите элементы целочисленного массива 3х3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Вы ввели массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Диагональные элементы этого массива:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array[i, i]);
            }
        }
    }
}

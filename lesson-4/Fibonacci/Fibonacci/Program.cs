using System;

namespace Fibonacci
{
    class Program
    {
        static long Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return (n);
            }
            else
            {
                return (Fibo (n-1) + Fibo (n-2));
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"Значение числа Фибоначчи: {Fibo(n)}");
            Console.ReadLine();

        }
    }
}

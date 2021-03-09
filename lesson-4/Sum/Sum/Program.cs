using System;

namespace Sum
{
    class Program
    {
        static int Sum (string set)
        {
            int sum = 0;
            string number = "";

            for (int i = 0; i < set.Length; i++)
            {
                if (set[i] != ' ')
                {
                    number = number + set[i];
                }
                else
                {
                    sum = sum + Convert.ToInt32(number);
                    number = "";
                }
            }
            sum = sum + Convert.ToInt32(number);
            return (sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел разделенных пробелом:");
            string set = Console.ReadLine();
            Console.WriteLine($"Сумма введенных чисел {Sum(set)}");
            Console.ReadLine();
        }
    }
}

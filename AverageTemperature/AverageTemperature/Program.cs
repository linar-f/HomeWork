using System;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную суточную температуру:");
            float Tmin = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите максимальную суточную температуру:");
            float Tmax = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура Т= {(Tmax + Tmin) / 2}");
            Console.ReadLine();
        }
    }
}

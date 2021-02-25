using System;

namespace MonthNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Month = new DateTime();
            Console.WriteLine("Введите порядковый номер текущего месяца:");
            Byte Number = Convert.ToByte (Console.ReadLine());
            Console.WriteLine($"Название этого месяца {Month.AddMonths(Number-1).ToString ("MMMM")}");
            Console.ReadLine();
        }
    }
}

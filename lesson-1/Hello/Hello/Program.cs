using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string TodaysDate = DateTime.Now.ToShortDateString();
            Console.Write("Введите имя пользователя: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Привет, " + UserName + "! Сегодня " + TodaysDate);
            Console.ReadLine();
        }
    }
}

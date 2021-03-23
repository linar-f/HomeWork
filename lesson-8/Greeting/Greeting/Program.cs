using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.userName))
            {
                Console.WriteLine($"{Properties.Settings.Default.greeting} Введите пожалуйста ваше имя:");
                Properties.Settings.Default.userName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Здравствуйте, {Properties.Settings.Default.userName}!");
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.userAge))
            {
                Console.WriteLine("Введите пожалуйста ваше возраст:");
                Properties.Settings.Default.userAge = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Ваш возраст: {Properties.Settings.Default.userAge}");
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.userCareer))
            {
                Console.WriteLine("Ваша профессия:");
                Properties.Settings.Default.userCareer = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Ваша профессия: {Properties.Settings.Default.userCareer}");
            }
            Console.ReadLine();
            //Properties.Settings.Default.Reset();
        }
    }
}

using System;

namespace Season
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static Season CurrentSeason(int numberMonth)
            {
            Season current = Season.Winter;
            switch (numberMonth)
            {
                case 12:
                case 1:
                case 2:
                    current = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    current = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    current = Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    current = Season.Autumn;
                    break;
            }
           return current;
        }

        static string NameSeason(Season current)
        {
            string name = "";
            switch (current)
            {
                case Season.Winter:
                    name = "зима";
                    break;
                case Season.Spring:
                    name = "весна";
                    break;
                case Season.Summer:
                    name = "лето";
                    break;
                case Season.Autumn:
                    name = "осень";
                    break;
            }
            return name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            if (numberMonth > 0 && numberMonth < 13)
            {
                Console.WriteLine(NameSeason(CurrentSeason(numberMonth)));
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.ReadLine();
        }
    }
}

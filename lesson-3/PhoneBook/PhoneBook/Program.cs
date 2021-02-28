using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Book =
            {
                {"Иванов Иван", "+7-951-213-18-01"},
                {"Петров Василий", "+7-912-311-15-02"},
                {"Сидоров Сергей", "+7-911-221-19-03"},
                {"Колышев Антон", "+7-951-213-18-04"},
                {"Абдуллин Артур", "+7-917-432-17-05"},
                 
            };
            Console.WriteLine("ТЕЛЕФОННЫЙ СПРАВОЧНИК 1.0");
            Console.WriteLine("Введите фамилию и имя:");
            string Name = Console.ReadLine();
            bool test = false;
            for (int i = 0; i < 5; i++)
                {
                if (Name == Book[i,0])
                    {
                    Console.WriteLine("Номер телефона абонента " + Book[i, 0] + ": " + Book [i, 1]);
                    test = true;
                    break;
                    }
                }
            if (!test) Console.WriteLine("Такого абонента нет в телефонном справочнике");
            Console.ReadLine();

        }
    }
}

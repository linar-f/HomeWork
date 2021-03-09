using System;

namespace FullName
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = $"{lastName} {firstName} {patronymic}";
            return fullName;
        }
        static (string firstName, string lastName, string patronymic) ReceiveData()
        {
            Console.WriteLine ("Введите фамилию:");
            string lastName = Console.ReadLine ();
            Console.WriteLine ("Введите имя:");
            string firstName = Console.ReadLine ();
            Console.WriteLine ("Введите отчество:");
            string patronymic = Console.ReadLine ();
            return (firstName, lastName, patronymic);
        }

        static void Main(string[] args)
        {
            string stop = " ";
            while (stop != "s")
            {
                (string firstName, string lastName, string patronymic) = ReceiveData ();
                Console.WriteLine ($"Вы ввели: {GetFullName(firstName, lastName, patronymic)}");
                Console.WriteLine("Чтобы завершить работу программы введите s и нажмите Enter");
                stop = Console.ReadLine ();
            }
        }
            
    }
}

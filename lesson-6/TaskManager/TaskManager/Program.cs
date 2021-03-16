using System;
using System.Diagnostics;
namespace TaskManager
{
    class Program
    {
        static void KillProcessByName (Process [] arrayProcess, string nameProcess)
        {
            for (int i = 0; i < arrayProcess.Length; i++)
            {
                if (nameProcess == arrayProcess[i].ProcessName)
                {
                    arrayProcess[i].Kill();
                    Console.Clear();
                    Console.WriteLine($"Процесс {arrayProcess[i].ProcessName} завершён.");
                }
            }
        }
        static void KillProcessById (Process [] arrayProcess, int idProcess)
        {
            for (int i = 0; i < arrayProcess.Length; i++)
            {
                if (idProcess == arrayProcess[i].Id)
                {
                    arrayProcess[i].Kill();
                    Console.Clear();
                    Console.WriteLine($"Процесс {arrayProcess[i].Id} {arrayProcess[i].ProcessName} завершён.");
                }
            }
        }

        static void Main(string[] args)
        {
            string stop = " ";
            while (stop != "exit")
            {
                Process[] arrayProcess = Process.GetProcesses();
                Console.WriteLine($"Имя{new string (' ',24)}ID{new string (' ', 8)}Память (Кбайт)");
                Console.WriteLine(new string('-', 52));
                for (int i = 0; i < arrayProcess.Length; i++)
                {
                    Console.WriteLine($"{arrayProcess[i].ProcessName.PadRight(36).Remove(25,11)}  {arrayProcess[i].Id.ToString().PadRight(10)}  {arrayProcess[i].WorkingSet64/1024}");
                }
                Console.WriteLine(new string('-', 52));
                Console.WriteLine("Выберите способ завершения процесса:");
                Console.WriteLine("1 По имени процесса - наберите name и нажмете Enter");
                Console.WriteLine("2 По ID процесса - наберите id и нажмете Enter");
                string method = Console.ReadLine();
                try
                {
                    switch (method)
                    {
                        case "name":
                        case "1":
                            Console.WriteLine("Введите имя процесса:");
                            string name = Console.ReadLine();
                            KillProcessByName(arrayProcess, name);
                            break;
                        case "id":
                        case "2":
                            Console.WriteLine("Введите ID процесса:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            KillProcessById(arrayProcess, id);
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Во время выполнения произошла ошибка: {e.Message}");
                }
                Console.WriteLine("Для завершения работы, введите exit и нажмите Enter. Для продолжения Enter.");
                stop = Console.ReadLine();
            }
        }
    }
}

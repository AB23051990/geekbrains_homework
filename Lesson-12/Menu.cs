using System;
using System.Diagnostics;
using HomeWork13;
using HomeWork12;
using HomeWork11;
using HomeWork10;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.GeneralClass;
using HomeWork14;

namespace HomeWork
{
    class Menu
    {
        static void Main(string[] args)
        {
            List<GeneralClass> less = new List<GeneralClass>();// Переделал по замечаниям. Создал один общий класс [void Less();] для вывода в консль заданий
            while (true) 
            {                
                Console.WriteLine("Для выбора практической работы введите её номер '1', '2'..." +
                               $"\nили '0' - завершить программу");
                string work = Console.ReadLine();
                int menu = Convert.ToInt32(work);                
                if (menu == 0)
                {
                    Process.GetCurrentProcess().Kill();
                }
                if (menu == 1)
                {
                    Console.WriteLine($"Практическая работа №1 (колличество заданий '3')" + "\nДля выбора задания введите его номер '1', '2'...");
                    string work1 = Console.ReadLine();
                    int menu1 = Convert.ToInt32(work1);
                    if (menu1 == 1)
                    {less.Add(new Less1());}
                    if (menu1 == 2)
                    {less.Add(new Less2());}
                    if (menu1 == 3)
                    {
                        less.Add(new Less3());
                        less.Add(new Less4());
                    }
                    if (menu1 > 3)
                    {Console.WriteLine("нет такого задания");}
                }
                if (menu == 2)
                {
                    Console.WriteLine($"Практическая работа №2 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'...");
                    string work2 = Console.ReadLine();
                    int menu2 = Convert.ToInt32(work2);
                    if (menu2 == 1)
                    {
                        less.Add(new Less5());
                    }
                    if (menu2 > 1)
                    {Console.WriteLine("нет такого задания");}
                }
                if (menu == 3)
                {
                    Console.WriteLine($"Практическая работа №3 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'...");
                    string work3 = Console.ReadLine();
                    int menu3 = Convert.ToInt32(work3);
                    if (menu3 == 1)
                    {
                        less.Add(new Less6());
                    }
                    if (menu3 > 1)
                    {Console.WriteLine("нет такого задания");}
                }
                if (menu == 4)
                {
                    Console.WriteLine($"Практическая работа №4 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'...");
                    string work4 = Console.ReadLine();
                    int menu4 = Convert.ToInt32(work4);
                    if (menu4 == 1)
                    {
                        less.Add(new Less7()); //метод скопировал с интернета
                    }
                    if (menu4 == 2)
                    {
                        less.Add(new Less8()); //метод скопировал с интернета
                    }  
                    if (menu4 > 2)
                    {Console.WriteLine("нет такого задания");}
                }
                if (menu == 5)
                {
                    Console.WriteLine($"Практическая работа №5 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'...");
                    string work5 = Console.ReadLine();
                    int menu5 = Convert.ToInt32(work5);
                    if (menu5 == 1)
                    {
                        less.Add(new Less9()); 
                    }
                    if (menu5 > 1)
                    { Console.WriteLine("нет такого задания"); }
                }
                if (menu > 5)
                {
                    Console.WriteLine("Практическое задание еще не готово");
                }
                foreach (GeneralClass les in less)
                {
                    les.Less();
                }

            }
            
        }
    }
}
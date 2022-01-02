using System;
using System.Diagnostics;
using Work1;
using Work2;
using Work3;
using Work4;
using Work5;
using Work6;
using Work7;

namespace HomeWork_14
{
    class Menu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню заданий:");
                Console.WriteLine("Для выбора практической работы введите её номер '1' - '7'" +
                $"\nили '0' - завершить программу");
                string work = Console.ReadLine();
                int menu = Convert.ToInt32(work);
                if (menu == 0)
                {
                    Process.GetCurrentProcess().Kill();
                }
                if (menu == 1)
                {
                    Console.WriteLine($"Практическая работа №1 (колличество заданий '3')" + "\nДля выбора задания введите его номер '1', '2', '3'");
                    string work1 = Console.ReadLine();
                    int menu1 = Convert.ToInt32(work1);
                    if (menu1 == 1)
                    { Lessons1.Lesson1(); }
                    if (menu1 == 2)
                    { Lessons1.Lesson2(); }
                    if (menu1 == 3)
                    { Lessons1.Lesson3(); }
                    if (menu1 > 3)
                    { Console.Clear(); }
                }
                if (menu == 2)
                {
                    Console.WriteLine($"Практическая работа №2 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1'");
                    string work2 = Console.ReadLine();
                    int menu2 = Convert.ToInt32(work2);
                    if (menu2 == 1)
                    { Lessons2.Lesson1(); }
                    if (menu2 > 1)
                    { Console.Clear(); }
                }
                if (menu == 3)
                {
                    Console.WriteLine($"Практическая работа №3 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1'");
                    string work3 = Console.ReadLine();
                    int menu3 = Convert.ToInt32(work3);
                    if (menu3 == 1)
                    { Lessons3.Lesson1(); }
                    if (menu3 > 1)
                    { Console.Clear(); }
                }
                if (menu == 4)
                {
                    Console.WriteLine($"Практическая работа №4 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'");
                    string work4 = Console.ReadLine();
                    int menu4 = Convert.ToInt32(work4);
                    if (menu4 == 1)
                    { Lessons4.Lesson1(); }
                    if (menu4 == 2)
                    { Lessons4.Lesson2(); }
                    if (menu4 > 2)
                    { Console.Clear(); }
                }
                if (menu == 5)
                {
                    Console.WriteLine($"Практическая работа №5 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1'");
                    string work5 = Console.ReadLine();
                    int menu5 = Convert.ToInt32(work5);
                    if (menu5 == 1)
                    { Lessons5.Lesson1(); }
                    if (menu5 > 1)
                    { Console.Clear(); }
                }
                if (menu == 6)
                {
                    Console.WriteLine($"Практическая работа №6 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1'");
                    string work6 = Console.ReadLine();
                    int menu6 = Convert.ToInt32(work6);
                    if (menu6 == 1)
                    { Lessons6.Lesson1(); }
                    if (menu6 > 1)
                    { Console.Clear(); }
                }
                if (menu == 7)
                {
                    Console.WriteLine($"Практическая работа №7 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1'");
                    string work7 = Console.ReadLine();
                    int menu7 = Convert.ToInt32(work7);
                    if (menu7 == 1)
                    { Lessons7.Lesson1(); }
                    if (menu7 > 1)
                    { Console.Clear(); }
                }
                if (menu > 7)
                {
                    Console.WriteLine("Нет такой работы");
                    Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}

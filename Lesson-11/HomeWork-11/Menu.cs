using System;
using System.Diagnostics;

namespace HomeWork11
{

    class Menu
    {
        static void Main(string[] args)
        {
            while (true) //запуск цикла программы
            {
                try //начало ловки ошибок
                {   //выводит на консоль основное меню практических заданий
                    Console.WriteLine("Для выбора практической работы введите её номер '1', '2'..." +
                                     $"\nили '0' - завершить программу");
                    string work = Console.ReadLine();//создание переменной
                    int menu = Convert.ToInt32(work);//переводим переменную в число
                    Console.Clear(); //очищает консоль
                    if (menu == 0) //команда закрывает приложение
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    if (menu == 1)//команда выводит на консоль практическую работу № 1 ссылаясь на классы (Lesson-1, Lesson-3, Lesson-4)
                    {
                        Console.WriteLine($"Практическая работа №1 (колличество заданий '3')" + "\nДля выбора задания введите его номер '1', '2'...");
                        string work1 = Console.ReadLine();
                        int menu1 = Convert.ToInt32(work1);
                        if (menu1 == 1)//команда выводит на консоль задание № 1 ссылаясь на Класс Lesson-1
                        {
                            Console.WriteLine($"\nЗадание № 1:");
                            var les1 = new Lesson1();
                            les1.Les1();
                            Console.WriteLine(les1);
                        }
                        if (menu1 == 2)//команда выводит на консоль задание № 2
                        {
                            Console.WriteLine($"\nЗадание № 2:");
                            Console.WriteLine($"Асимптотическая сложность функции = O(5 + N^3).");
                        }
                        if (menu1 == 3)//команда выводит на консоль задание № 3 ссылаясь на Класс (Lesson-3, Lesson-4)
                        {
                            Console.WriteLine($"\nЗадание № 3:");
                            var rec = new Lesson3();
                            rec.Rec();
                            Console.WriteLine(rec);
                            var for1 = new Lesson4();
                            for1.For();
                            Console.WriteLine(for1);
                        }
                        if (menu1 > 3)//команда выводит на консоль о предупреждении, что нет такого задания
                        {
                            Console.WriteLine("нет такого задания");
                        }
                    }
                    if (menu == 2)//выводит на консоль практическую работу № 2 ссылаясь на класс (NodeList)
                    {
                        Console.WriteLine($"Практическая работа №2 (колличество заданий '1')" + "\nДля выбора задания введите его номер '1', '2'...");
                        string work2 = Console.ReadLine();
                        int menu2 = Convert.ToInt32(work2);
                        if (menu2 == 1)//команда выводит на консоль задание № 2 ссылаясь на класс (NodeList)
                        {
                            Console.WriteLine($"\nЗадание № 1:");
                            NodeList myList = new NodeList();//создаёт переменную ссылаясь на класс (NodeList)
                            myList.AddNode(5464);//создание элемента в списске класс (NodeList)
                            myList.AddNode(6468);
                            myList.AddNode(4496);
                            myList.PrintList();//вывод на консоль списска
                        }
                        if (menu2 > 1)
                        { Console.WriteLine("нет такого задания"); }
                    }
                    if (menu > 2)
                    {
                        Console.WriteLine("Практическое задание еще не готово");
                    }
                }
                catch (Exception)//выводит на консоль ошибоку
                {
                    Console.WriteLine("Ошибка: выберите цыфру");
                }
                finally { }
            }
        }
    }
}
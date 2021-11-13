using System;

namespace Homework_3._1
{
    class Program
    {
        public static string W { get; private set; }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Практическое задание №3]");
            Console.ResetColor();
            // 1.Написать программу, выводящую элементы двумерного массива по диагонали.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №1]"+"\nНаписать программу, выводящую элементы двумерного массива по диагонали:" + "\n");
            Console.ResetColor();
            int[,] matrix = new int[9, 5];
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;
            matrix[2, 2] = 3;
            matrix[3, 3] = 4;
            matrix[4, 4] = 5;
            matrix[5, 3] = 6;
            matrix[6, 2] = 7;
            matrix[7, 1] = 8;
            matrix[8, 0] = 9;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { 
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            // 2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №2]"+ "\nНаписать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email.:" + "\n");
            Console.ResetColor();
            var matrix2 = new string[5, 2];
            matrix2[0, 0] = "Аль Пачино";            
            matrix2[1, 0] = "Джонни Депп";
            matrix2[2, 0] = "Анджелина Джоли";
            matrix2[3, 0] = "Шарлиз Терон";
            matrix2[4, 0] = "Том Хэнкс";
            matrix2[0, 1] = "+7 (495)-156-12-ХХ / Alpo@mail.ru";
            matrix2[1, 1] = "+7 (495)-315-33-ХХ / JD@Yandex.ru";
            matrix2[2, 1] = "+7 (495)-462-77-ХХ / ANGYPOP@rambler.ru";
            matrix2[3, 1] = "+7 (495)-758-99-ХХ / SHT#@mail.com";
            matrix2[4, 1] = "+7 (495)-598-54-ХХ / TomyHomy@gmail.com";

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine("\n");
            }

            // 3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №3]" + "\nНаписать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello):" + "\n");
            Console.ResetColor();

            Console.WriteLine("Введите слово Hello");
            string Rev = "";
            Rev = Console.ReadLine();
            char[] sReverse = Rev.ToCharArray();
            Array.Reverse(sReverse);
            Rev = new string(sReverse);
            Console.WriteLine(Rev);
            Console.ReadLine();

            // *.«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
        }
    }
}

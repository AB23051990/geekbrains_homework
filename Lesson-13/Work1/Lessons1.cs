using System;

namespace Work1
{
    
    public class Lessons1
    {
        /// <summary>
        /// 1. Напишите на C# функцию согласно блок-схеме
        /// </summary>
        public static void Lesson1()
        {
            {
                Console.WriteLine($"\nЗадание № 1:");
                Console.WriteLine($"- напишите на C# функцию согласно блок-схеме:");
                Console.WriteLine($"Введите число");
                int number = Int32.Parse(Console.ReadLine());
                int d = 0;
                int i = 2;
                if (i < number)
                {
                    if (number % i == 0)
                    {
                        d++;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (d == 0)
                {
                    Console.WriteLine($"число '{number}' простое\n");
                }
                else
                {
                    Console.WriteLine($"число '{number}' не простое\n");
                }
                Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
                Console.ReadLine();
                Console.Clear();
            }
        }
        /// <summary>
        /// Посчитайте сложность функции
        /// </summary>
        public static void Lesson2()
        {
            Console.WriteLine($"\nЗадание № 2:");
            Console.WriteLine($"- посчитайте сложность функции");
            Console.WriteLine($"*int sum = 0; // O(1)" +
                $"\nfor (int i = 0; i < inputArray.Length; i++) // O(N)" +
                $"\nfor (int j = 0; j < inputArray.Length; j++) // O(N)" +
                $"\nfor (int k = 0; k < inputArray.Length; k++) // O(N)" +
                $"\nint y = 0; // O(1)" +
                $"\nif (j != 0) // O(1)" +
                $"\n y = k / j;" +
                $"\nsum += inputArray[i] + i + k + j + y; // O(1)" +
                $"\nreturn sum; // O(1)" +
                $"\n" +
                $"\n");
            Console.WriteLine($"Асимптотическая сложность функции = O(5 + N^3).");
            Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
            Console.ReadLine();
            Console.Clear();
        }
        /// <summary>
        /// Реализуйте функцию вычисления числа Фибоначчи
        /// </summary>
        public static void Lesson3()
        {
            Console.WriteLine($"\nЗадание № 3:");
            Console.WriteLine($"- реализуйте функцию вычисления числа Фибоначчи");
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            int fib1 = Fibonachi(1); 
            int fib2 = Fibonachi(2);
            int fib3 = Fibonachi(3);
            int fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);     
            Console.WriteLine($"число Фибоначчи (рекурсивная версия) = {fib1},{fib2},{fib3},{fib4},{fib5}\n");
            int Fibonachi2(int n)
            {
                int result = 0;
                int b = 1;
                int tmp;
                for (int i = 0; i < n; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                }
                return result;
            }
            int fib6 = Fibonachi2(6);
            int fib7 = Fibonachi2(7);
            int fib8 = Fibonachi2(8);
            int fib9 = Fibonachi2(9);
            int fib10 = Fibonachi2(10);
            Console.WriteLine($"число Фибоначчи (без рекурсии, через цикл) = {fib6},{fib7},{fib8},{fib9},{fib10}\n");
            Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

using System;

namespace HomeWork10
{
    /// <summary>
    /// Практическая работа №1
    /// Задание 1 Напишите на C# функцию согласно блок-схеме
    /// </summary>
    /// <param name="args"></param>
    class Less1
    {
        public void Les1()
        {
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
                Console.WriteLine($"число '{number}' простое\n");// вывод первого задания на консоль 
            }
            else
            {
                Console.WriteLine($"число '{number}' не простое\n");// вывод первого задания на консоль
            }
        }
    }
    /// <summary>
    /// Задание 2 Вычислите асимптотическую сложность функции из примера ниже
    /// </summary>
    /// <param name="inputArray"></param>
    /// <returns></returns>
    class Lesson2
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) // O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(N)
                    {
                        int y = 0; // O(1)
                        if (j != 0) // O(1)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y; // O(1)
                    }
                }
            }
            return sum; // O(1)
        } // Асимптотическая сложность функции = O(5 + N^3).
    }
    /// <summary>
    /// Задание 3 Реализуйте функцию вычисления числа Фибоначчи
    /// 1. Реализовать рекурсивную версию и версию без рекурсии(через цикл);
    /// 2. Обе реализации сделать методами отдельного класса;
    /// 3. На вход методы должны принимать целочисленный параметр, определяющий количество элементов формируемой последовательности.
    /// Пример чисел Фибоначчи:
    /// F(0) = 0,
    /// F(1) = 1.
    /// Для остальных чисел:
    /// F(N) = F(N-2) + F(N-1).
    /// То есть для F(2) будет F(2) = F(0) + F(1) = 0 + 1 = 1.
    /// F(3) будет F(3) = F(1) + F(2) = 1 + 1 = 2.
    /// /// </summary>
    class Less3
    {
        public void Rec()
        {
            int Fibonachi(int n)// 1. Реализовать рекурсивную версию
            {
                if (n == 0 || n == 1) return n;
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            int fib1 = Fibonachi(1); // определение чисел
            int fib2 = Fibonachi(2);
            int fib3 = Fibonachi(3);
            int fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);
            Console.WriteLine($"число Фибоначчи (рекурсивная версия) = {fib1},{fib2},{fib3},{fib4},{fib5}\n"); // вывод заначений на консоль            
        }
    }
    class Less4
    {
        public void For()
        {
            int Fibonachi2(int n)//2. Реализовать версию без рекурсии(через цикл)
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
            int fib6 = Fibonachi2(6);// определение чисел
            int fib7 = Fibonachi2(7);
            int fib8 = Fibonachi2(8);
            int fib9 = Fibonachi2(9);
            int fib10 = Fibonachi2(10);
            Console.WriteLine($"число Фибоначчи (без рекурсии, через цикл) = {fib6},{fib7},{fib8},{fib9},{fib10}\n"); // вывод заначений на консоль
        }
    }
}
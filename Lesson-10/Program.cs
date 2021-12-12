using System;

namespace Lesson_10
{
    class Program
    {
        /// <summary>
        /// Задание 1 Напишите на C# функцию согласно блок-схеме
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"Задание 1:");
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
                Console.WriteLine($"число '{number}' простое");// вывод первого задания на консоль ()
            }
            else
            {
                Console.WriteLine($"число '{number}' не простое");// вывод первого задания на консоль
            }

            Console.WriteLine($"\nЗадание 2:");
            Console.WriteLine($"Асимптотическая сложность функции = O(5 + N^3).");// вывод второго задания на консоль

            Console.WriteLine($"\nЗадание 3:");
            Rec(); // вывод третьего задания на консоль            
            var For = new Program2(); // вывод третьего задания на консоль (новым классом)
            For.For();
            Console.WriteLine(For);
        }

        /// <summary>
        /// Задание 2 Вычислите асимптотическую сложность функции из примера ниже
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
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
        static void Rec()
        {
            int Fibonachi(int n)// 1. Реализовать рекурсивную версию
            {// функцию скопировал с интернета, составить по описанию в задани для меня очень сложная и практически не посильная задача.
                if (n == 0 || n == 1) return n;
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            int fib1 = Fibonachi(1); // определение чисел
            int fib2 = Fibonachi(2);
            int fib3 = Fibonachi(3);
            int fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);
            Console.WriteLine($"число Фибоначчи (рекурсивная версия) = {fib1},{fib2},{fib3},{fib4},{fib5}"); // вывод заначений на консоль            
        }
    }
    class Program2
    {
        public void For()
        {
            int Fibonachi2(int n)//2. Реализовать версию без рекурсии(через цикл)
            {// функцию скопировал с интернета...
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
            Console.WriteLine($"число Фибоначчи (без рекурсии, через цикл) = {fib6},{fib7},{fib8},{fib9},{fib10}"); // вывод заначений на консоль
        }
    }
}

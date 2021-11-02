using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}]");
        }
    }
}

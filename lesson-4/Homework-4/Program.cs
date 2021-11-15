using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HomeWork(""));
            Console.WriteLine(GetFullName("", "", ""));
            Console.WriteLine(GetFullName2("", "", ""));
            Console.WriteLine(GetFullName3("", "", ""));
            Console.WriteLine(HomeWork2(""));
            Console.WriteLine(Getnumber(""));
            Console.WriteLine(HomeWork3(""));
            do
            {
                Console.WriteLine("Введите номер месяца: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);
        }
        /*Написать метод GetFullName(string firstName, string lastName, string patronymic),
        принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.Используя метод,
        написать программу, выводящую в консоль 3–4 разных ФИО.*/
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            firstName = "Иван";
            lastName = "Попов";
            patronymic = "Индонезевич";
            return $"{firstName} {lastName} {patronymic}";
        }
        static string GetFullName2(string firstName, string lastName, string patronymic)
        {
            firstName = "Гульчитай";
            lastName = "Намэ";
            patronymic = "Иброгимовна";
            return $"{firstName} {lastName} {patronymic}";
        }
        static string GetFullName3(string firstName, string lastName, string patronymic)
        {
            firstName = "Семён";
            lastName = "Нерушимый";
            patronymic = "Иванович";
            return $"{firstName} {lastName} {patronymic}";
        }
        /*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
        и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.*/
        static string Getnumber(string Numbers)
        {
            string input = "10 20   30";
            int result = 0;
            int number = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var ch = input[i];
                if (ch != ' ')
                {
                    int x = ch - '0';
                    number = number * 10 + x;
                }
                else
                {
                    result += number;
                    number = 0;
                }
            }
            if (number > 0)
            {
                result += number;
            }
            Console.WriteLine(result);
            return $"{Numbers}";
        }
        /* 3.Написать метод по определению времени года.На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.
        Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень).
        Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/
        enum season 
        {            
            Winter,
            Spring,
            Summer,
            Autumn,
            Exceptions
        }
        static season OfMonth(int n)
        {
            try
            {
                if (n <= 0 || n > 12)
                    throw new Exception("Ошибка: введите число от 1 до 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.Exceptions;
            }
        }
        static string Season(season A)
        {
            switch (A)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        static string HomeWork(string Work1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Практическое задание №4]");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №1]" + "\nНаписать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.:" + "\n");
            Console.ResetColor();
            return Work1;
        }
        static string HomeWork2(string Work2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №2]" + "\nНаписать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.:" + "\n");
            Console.ResetColor();
            return Work2;
        }
        static string HomeWork3(string Work3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[Задание №3]" + "\nНаписать метод по определению времени года.На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12»:" + "\n");
            Console.ResetColor();
            return Work3;
        }   
        
    }
}

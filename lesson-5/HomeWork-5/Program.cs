using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HomeWork_5
{
    class Program
    {
        
        static void Main (string[] args)
        {
            // Задание 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл:

            string filename1 = "HomeWork_task1.txt"; // Присваеваем имя для текстового фаила;
            File.WriteAllText(filename1, Console.ReadLine()); // записываем в файл строку;
            // Текстовый файл будет создан рядом с исполняемым файлом приложения.

            // Задание 2.Написать программу, которая при старте дописывает текущее время в файл «startup.txt»:

            string filename2 = "startup.txt"; // Присваеваем имя для текстового фаила;
            File.WriteAllText(filename2, $"{DateTime.Now}"); // записываем текущее время в файл «startup.txt»;
            // Текстовый файл будет создан рядом с исполняемым файлом приложения.
            
            // Задание 3.Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.

            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел(0...255)"); // призывает пользователя ввести набор чисел(0...255);
            int a = Int32.Parse(Console.ReadLine()); //ввод числа
            try { if (a <= 0 || a > 255) throw new Exception("Ошибка: введите число от 0 до 255"); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            BinaryFormatter formatter = new BinaryFormatter(); // перевод в бинарный формат
            formatter.Serialize(new FileStream("HomeWork_task3.bin", FileMode.OpenOrCreate), a);
            // бинарный файл будет создан рядом с исполняемым файлом приложения.
        }

    }
   
}

using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Практическое задание №7
            /*Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
            декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать приложение.*/

            //1. Написать любое приложение, произвести его сборку с помощью MSBuild
            Console.WriteLine("ИСХОДНЫЙ КОД:");
            Console.WriteLine("Введите число A");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Б");
            int B = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма А и Б = {A + B}");

            //2. Осуществить декомпиляцию с помощью dotPeek
            /*
            // Decompiled with JetBrains decompiler
            // Type: HomeWork_7.Program
            // Assembly: HomeWork-7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
            // MVID: 2F51C3D2-DD71-431C-A540-A4B4BCF89CF9
            // Assembly location: C:\Users\AB23051990\Desktop\geekbrains_homework\lesson-7\HomeWork-7\bin\Debug\net5.0\HomeWork-7.dll
            using System;
            namespace HomeWork_7
            {internal class Program{private static void Main(string[] args)
            {Console.WriteLine("Введите число A");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Б");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Сумма А и Б = {0}", (object) (num1 + num2)));}}}
            */

            //3. внести правки в программный код и пересобрать приложение.
            Console.WriteLine("\nДЕКОМПИЛИРОВАННЫЙ КОД:");
            Console.WriteLine("Введите число В");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число Г");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Сумма В и Г = {0}", (object)(num1 + num2)));
        }
    }
}

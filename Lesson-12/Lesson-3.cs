using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HomeWork12
{
    /// <summary>
    /// Создаем 2 типа:
    /// * структура PointStructDouble с полями типа double (Double);
    /// * класс PointClassDouble с полями типа double (Double);
    /// Создаем метод, возвращающий расстояние между парой точек каждого типа.;
    /// Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями.;
    /// Проводим замеры длительности выполнения методов на массивах разного размера.;
    /// Вывод может иметь вид (соответственно x, y - время выполнения, Ratio - отношение времени):
    /// Количество точек | PointStructDouble | PointClassDouble | Ratio
    /// 100000 | x1 | y1| y1/x1
    /// 200000 | x2 | y2 | y2/x2
    /// </summary>
    public struct PointStructDouble  // структура PointStructDouble (это значимый тип)
    {
        public double X1;
        public double Y1;
    }
    public class PointClassDouble // класс PointClassDouble (это ссылочный тип)
    {
        public double X2;
        public double Y2;
    }
    class Point
    {

        public static readonly int PointMassOne = 100000; // размер массива данных 
        public static PointStructDouble[] masD = new PointStructDouble[PointMassOne + 1]; // объявляем массивы с данными

        public static readonly int PointMassTwo = 200000; // размер массива данных 
        public static PointStructDouble[] masF = new PointStructDouble[PointMassTwo + 1]; // объявляем массивы с данными


        public static double PointStructD(PointStructDouble pointOne, PointStructDouble pointTwo) // Метод расчёта типа double (значимый тип)
        {
            double x = pointOne.X1 - pointTwo.X1;
            double y = pointOne.Y1 - pointTwo.Y1;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static double PointClassD(PointClassDouble pointOne, PointClassDouble pointTwo) // Метод расчёта типа double (ссылочный тип)
        {
            double x = pointOne.X2 - pointTwo.X2;
            double y = pointOne.Y2 - pointTwo.Y2;
            return Math.Sqrt((x * x) + (y * y));
        }
        public void PointW()
        {
            // не получается задать произвольные координаты точек!
            // метод взял из интернета но реализовать реализовать (ссылочный тип) не получается!
            // ввод [Benchmark] реализовать не успел!

            /*
            Random rnd1 = new Random(); // создание пременной для случайных чисел
            for (int i = 0; i <= PointMassTwo; i++) // заполняем массив случайными данными 
            {
                masF[i].X2 = rnd1.NextDouble();
                masF[i].Y2 = rnd1.NextDouble();
            }*/

            Random rnd = new Random(); // создание пременной для случайных чисел

            for (int i = 0; i <= PointMassOne; i++) // заполняем массив случайными данными (значимый тип)
            {
                masD[i].X1 = rnd.NextDouble();
                masD[i].Y1 = rnd.NextDouble();
            }
            Stopwatch stopWatch = new Stopwatch();// расчёты 

            stopWatch.Restart();//  (значимый тип)
            for (int i = 0; i < PointMassOne; i++)
            {
                _ = PointStructD(masD[i], masD[i + 1]);
            }
            stopWatch.Stop();
            long milisek3 = stopWatch.ElapsedMilliseconds;

            /*
            stopWatch.Restart();// (ссылочный тип) реализовать не получается
            for (int i = 0; i < PointMassTwo; i++)
            {
                _ = PointClassD(masF[i], masF[i + 1]);
            }
            stopWatch.Stop();
            long milisek4 = stopWatch.ElapsedMilliseconds;
            */

            // результаты
            Console.WriteLine($"Количество точек | PointStructDouble | PointClassDouble | Ratio");
            Console.WriteLine($"100000           |         X1        |        Y1        |" + milisek3.ToString());
            Console.WriteLine($"200000           |         X2        |        Y2        |" /*+ milisek4.ToString()*/);
            _ = Console.ReadLine();

        }
        

    }
}
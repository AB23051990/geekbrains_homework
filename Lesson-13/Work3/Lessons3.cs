using System;
using System.Diagnostics;

namespace Work3
{
    /// <summary>
    /// Создаем метод, возвращающий расстояние между парой точек каждого типа. Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями. Проводим замеры длительности выполнения методов на массивах разного размера.
    /// </summary>
    public struct PointStructDouble
    {
        public double X;
        public double Y;
    }
    public class Lessons3
    {
        public static readonly int PointMassOne = 100000;
        public static PointStructDouble[] masD = new PointStructDouble[PointMassOne + 1];
        public static double PointStructD(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static void Lesson1()
        {
            Random rnd = new Random();
            for (int i = 0; i <= PointMassOne; i++)
            {
                masD[i].X = rnd.NextDouble();
                masD[i].Y = rnd.NextDouble();
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            for (int i = 0; i < PointMassOne; i++)
            {
                _ = PointStructD(masD[i], masD[i + 1]);
            }
            stopWatch.Stop();
            long milisek3 = stopWatch.ElapsedMilliseconds;
            Console.WriteLine($"\nЗадание № 1:");
            Console.WriteLine($"- создаем метод, возвращающий расстояние между парой точек каждого типа." +
                $" Реализуем метод, создающий массив точек каждого типа и заполняющий его случайными значениями." +
                $" Проводим замеры длительности выполнения методов на массивах разного размера.");
            Console.WriteLine($"Количество точек | PointStructDouble | PointClassDouble | Ratio");
            Console.WriteLine($"100000 | X1 | Y1 |" + milisek3.ToString());
            Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

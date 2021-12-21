using System;
using System.Diagnostics;
using AlgorithmsAndDataStructures.GeneralClass;
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
        public double X;
        public double Y;
    }
    
    class Less6 : GeneralClass
    {
        public static readonly int PointMassOne = 100000; // размер массива данных 
        public static PointStructDouble[] masD = new PointStructDouble[PointMassOne + 1]; // объявляем массивы с данными

        public string Name => throw new NotImplementedException();

        public static double PointStructD(PointStructDouble pointOne, PointStructDouble pointTwo) // Метод расчёта типа double (значимый тип)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public void Less()
        {
            Random rnd = new Random(); // создание пременной для случайных чисел

            for (int i = 0; i <= PointMassOne; i++) // заполняем массив случайными данными (значимый тип)
            {
                masD[i].X = rnd.NextDouble();
                masD[i].Y = rnd.NextDouble();
            }
            Stopwatch stopWatch = new Stopwatch();// расчёты 

            stopWatch.Restart();//  (значимый тип)
            for (int i = 0; i < PointMassOne; i++)
            {
                _ = PointStructD(masD[i], masD[i + 1]);
            }
            stopWatch.Stop();
            long milisek3 = stopWatch.ElapsedMilliseconds;

            // результаты
            Console.WriteLine($"\nЗадание № 1:");
            Console.WriteLine($"Количество точек | PointStructDouble | PointClassDouble | Ratio");
            Console.WriteLine($"100000           |         X1        |        Y1        |" + milisek3.ToString());
            _ = Console.ReadLine();
        }     
    }
}
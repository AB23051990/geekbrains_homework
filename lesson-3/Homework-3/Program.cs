using System;

namespace Homework_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1.Написать программу, выводящую элементы двумерного массива по диагонали.
            int[,] matrix = new int[9, 5];
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;
            matrix[2, 2] = 3;
            matrix[3, 3] = 4;
            matrix[4, 4] = 5;
            matrix[5, 3] = 6;
            matrix[6, 2] = 7;
            matrix[7, 1] = 8;
            matrix[8, 0] = 9;            
            for (int i = 0; i < matrix.GetLength(0); i++)
            { for (int j = 0; j < matrix.GetLength(1); j++)
                {Console.Write($"{matrix[i, j]} ");}
                Console.WriteLine();
            }

            // 2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email.

            // 3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).

            //«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

        }
    }
}

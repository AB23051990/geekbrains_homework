﻿using AlgorithmsAndDataStructures.GeneralClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork13
{
    /// <summary>
    /// Задание 1 (метод скопировал с интернета)
    /// Реализуйте класс двоичного дерева поиска с операциями вставки, удаления, поиска. Также напишите метод вывода в консоль дерева, чтобы увидеть, насколько корректно работает ваша реализация.    
    /// </summary>
    public enum BinSide
    {
        Left,
        Right
    }
    /// <summary>
    /// Двоичного дерево поиска
    /// </summary>
    public class DoubleTree
    {
        public long? Data { get; private set; }
        public DoubleTree Left { get; set; }
        public DoubleTree Right { get; set; }
        public DoubleTree Parent { get; set; }

        /// <summary>
        /// Вставляет целочисленное значение в дерево
        /// </summary>
        /// <param name="data">Значение, которое добавится в дерево</param>
        public void Insert(long data)
        {
            if (Data == null || Data == data)
            {
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (Left == null) Left = new DoubleTree();
                Insert(data, Left, this);
            }
            else
            {
                if (Right == null) Right = new DoubleTree();
                Insert(data, Right, this);
            }
        }

        /// <summary>
        /// Вставляет значение в определённый узел дерева
        /// </summary>
        /// <param name="data">Значение</param>
        /// <param name="node">Целевой узел для вставки</param>
        /// <param name="parent">Родительский узел</param>
        private void Insert(long data, DoubleTree node, DoubleTree parent)
        {

            if (node.Data == null || node.Data == data)
            {
                node.Data = data;
                node.Parent = parent;
                return;
            }
            if (node.Data > data)
            {
                if (node.Left == null) node.Left = new DoubleTree();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new DoubleTree();
                Insert(data, node.Right, node);
            }
        }
        /// <summary>
        /// Уставляет узел в определённый узел дерева
        /// </summary>
        /// <param name="data">Вставляемый узел</param>
        /// <param name="node">Целевой узел</param>
        /// <param name="parent">Родительский узел</param>
        private void Insert(DoubleTree data, DoubleTree node, DoubleTree parent)
        {

            if (node.Data == null || node.Data == data.Data)
            {
                node.Data = data.Data;
                node.Left = data.Left;
                node.Right = data.Right;
                node.Parent = parent;
                return;
            }
            if (node.Data > data.Data)
            {
                if (node.Left == null) node.Left = new DoubleTree();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new DoubleTree();
                Insert(data, node.Right, node);
            }
        }
        /// <summary>
        /// Определяет, в какой ветви для родительского лежит данный узел
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BinSide? MeForParent(DoubleTree node)
        {
            if (node.Parent == null) return null;
            if (node.Parent.Left == node) return BinSide.Left;
            if (node.Parent.Right == node) return BinSide.Right;
            return null;
        }

        /// <summary>
        /// Удаляет узел из дерева
        /// </summary>
        /// <param name="node">Удаляемый узел</param>
        public void Remove(DoubleTree node)
        {
            if (node == null) return;
            var me = MeForParent(node);
            //Если у узла нет дочерних элементов, его можно смело удалять
            if (node.Left == null && node.Right == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = null;
                }
                else
                {
                    node.Parent.Right = null;
                }
                return;
            }
            //Если нет левого дочернего, то правый дочерний становится на место удаляемого
            if (node.Left == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = node.Right;
                }
                else
                {
                    node.Parent.Right = node.Right;
                }

                node.Right.Parent = node.Parent;
                return;
            }
            //Если нет правого дочернего, то левый дочерний становится на место удаляемого
            if (node.Right == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = node.Left;
                }
                else
                {
                    node.Parent.Right = node.Left;
                }

                node.Left.Parent = node.Parent;
                return;
            }

            //Если присутствуют оба дочерних узла
            //то правый ставим на место удаляемого
            //а левый вставляем в правый

            if (me == BinSide.Left)
            {
                node.Parent.Left = node.Right;
            }
            if (me == BinSide.Right)
            {
                node.Parent.Right = node.Right;
            }
            if (me == null)
            {
                var bufLeft = node.Left;
                var bufRightLeft = node.Right.Left;
                var bufRightRight = node.Right.Right;
                node.Data = node.Right.Data;
                node.Right = bufRightRight;
                node.Left = bufRightLeft;
                Insert(bufLeft, node, node);
            }
            else
            {
                node.Right.Parent = node.Parent;
                Insert(node.Left, node.Right, node.Right);
            }
        }
        /// <summary>
        /// Удаляет значение из дерева
        /// </summary>
        /// <param name="data">Удаляемое значение</param>
        public void Remove(long data)
        {
            var removeNode = Find(data);
            if (removeNode != null)
            {
                Remove(removeNode);
            }
        }
        /// <summary>
        /// Ищет узел с заданным значением
        /// </summary>
        /// <param name="data">Значение для поиска</param>
        /// <returns></returns>
        public DoubleTree Find(long data)//Положить корень дерева в очередь.
        {
            if (Data == data) return this; //Если очередь пуста, завершить работу алгоритма.
            if (Data > data)
            {
                return Find(data, Left);
            }
            return Find(data, Right);
        }
        /// <summary>
        /// Ищет значение в определённом узле
        /// </summary>
        /// <param name="data">Значение для поиска</param>
        /// <param name="node">Узел для поиска</param>
        /// <returns></returns>
        public DoubleTree Find(long data, DoubleTree node)
        {
            if (node == null) return null;

            if (node.Data == data) return node;
            if (node.Data > data)
            {
                return Find(data, node.Left);
            }
            return Find(data, node.Right);
        }
        /// <summary>
        /// Количество элементов в дереве
        /// </summary>
        /// <returns></returns>
        public long CountElements()
        {
            return CountElements(this);
        }
        /// <summary>
        /// Количество элементов в определённом узле
        /// </summary>
        /// <param name="node">Узел для подсчета</param>
        /// <returns></returns>
        private long CountElements(DoubleTree node)
        {
            long count = 1;
            if (node.Right != null)
            {
                count += CountElements(node.Right);
            }
            if (node.Left != null)
            {
                count += CountElements(node.Left);
            }
            return count;
        }
    }
    public class DoubleTreeExtensions
    {
        public static void Print(DoubleTree node)
        {
            if (node != null)
            {
                if (node.Parent == null)
                {
                    Console.WriteLine("ROOT:{0}", node.Data);
                }
                else
                {
                    if (node.Parent.Left == node)
                    {
                        Console.WriteLine("Left for {1}  --> {0}", node.Data, node.Parent.Data);
                    }

                    if (node.Parent.Right == node)
                    {
                        Console.WriteLine("Right for {1} --> {0}", node.Data, node.Parent.Data);
                    }
                }
                if (node.Left != null)
                {
                    Print(node.Left);
                }
                if (node.Right != null)
                {
                    Print(node.Right);
                }
            }
        }
    }
    /// <summary>
    /// вывод вывод структуры
    /// </summary>
    class Less7 : GeneralClass
    {
        public string Name => throw new NotImplementedException();
        public void Less()
        {
            Console.WriteLine($"\nЗадание № 1:");
            var tree = new DoubleTree();
            tree.Insert(10);
            tree.Insert(100);
            tree.Insert(1);
            tree.Insert(4);
            tree.Insert(50);
            tree.Insert(0);
            tree.Insert(19);
            tree.Insert(45);
            tree.Insert(17);
            DoubleTreeExtensions.Print(tree);
        }
    }
    /// <summary>
    /// Задание 2 (метод скопировал с интернета)
    /// (Опционально) Заполните массив и HashSet случайными строками, не менее 10 000 строк.Выполните замер производительности проверки наличия строки в массиве и HashSet.Выложите код и результат замеров.
    /// </summary>
    class Less8 : GeneralClass
    {
        public string Name => throw new NotImplementedException();
        public void Less()
        {
            Random r = new Random();
            HashSet<string> myHash = new HashSet<string>();
            while (myHash.Count < 10_000)
            {
                string value = default;
                for (int j = 0; j < r.Next(5, 10); j++) value += ((char)r.Next('a', 'z')).ToString();
                myHash.Add(value);
            }
            //Замер HasSet
            Stopwatch stopWatch = Stopwatch.StartNew();
            foreach (var item in myHash)
            {
                if (item.Equals("abcderfdk"))
                {
                    break;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string time = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds / 10}";
            Console.WriteLine($"\nЗадание № 2:");
            Console.WriteLine("RunTime " + time);
        } 
    }
}


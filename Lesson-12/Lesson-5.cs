using AlgorithmsAndDataStructures.GeneralClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork14
{
    /// <summary>
    /// Задание 1 
    /// Реализуйте методы поиска в дереве "поиск в ширину" и "поиск в глубину" с выводом каждого шага в консоль.    
    /// </summary>
    internal class Tree<T>
    {
        public Node<T> Root { get; private set; }
        public void AddNode(Node<T> node)
        {
            Trace.Assert(node != null);
            if (Root == null)
            {
                Root = node;
                return;
            }
                
            Node<T> nodeToAdd = GetLastNodeWithEmptyChildLink(Root);
            if (nodeToAdd.Left == null)
            {
                nodeToAdd.Left = node;                
            }                
            else
                nodeToAdd.Right = node;
            node.Parent = nodeToAdd;
        }
        private void Across(Node<T> node, ref string s, bool detailed)// метод из интернета
        {
            {
                /*
                 Аргументы метода:
                 1. TreeNode node - текущий "элемент дерева" (ref  передача по ссылке)       
                 2. ref string s - строка, в которой накапливается результат (ref - передача по ссылке)
                */
                var queue = new Queue<Node<T>>(); // Положить корень дерева в очередь.

                if (detailed) s += "    заносим в очередь значение " + node.Data.ToString() + Environment.NewLine; queue.Enqueue(node); // поместить в очередь первый уровень
                while (queue.Count != 0) // пока очередь не пуста
                {
                    //если у текущей ветви есть листья, их тоже добавить в очередь
                    if (queue.Peek().Left != null)
                    {
                        if (detailed) s += "    заносим в очередь значение " + queue.Peek().Left.Data.ToString() + " из левого поддерева" + Environment.NewLine;
                        queue.Enqueue(queue.Peek().Left);
                    }
                    if (queue.Peek().Right != null)
                    {
                        if (detailed) s += "    заносим в очередь значение " + queue.Peek().Right.Data.ToString() + " из правого поддерева" + Environment.NewLine;
                        queue.Enqueue(queue.Peek().Right);
                    }
                    //извлечь из очереди информационное поле последнего элемента
                    if (detailed) s += "    извлекаем значение из очереди: " + queue.Peek().Data.ToString() + Environment.NewLine;
                    else s += queue.Peek().Data.ToString() + " "; // убрать последний элемент очереди
                    queue.Dequeue();
                }
            }
        }

        public void PrintTree()
        {
            PrintTree(0, Root);
            Across();
        }       

        public void PrintTree(int Level, Node<T> node)
        {
            Console.WriteLine($"{Level} - {node.Data}");
            if (node.Left != null)
                PrintTree(Level + 1, node.Left);
            if (node.Right != null)
                PrintTree(Level + 1, node.Right);
        }
        public Node<T> GetLastNodeWithEmptyChildLink(Node<T> root)
        {
            if (root.Left == null || root.Right == null)
                return root;
            return GetLastNodeWithEmptyChildLink(root.Left);
        }     

    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }
    }
    public class Less9 : GeneralClass
    {
        public string Name => throw new NotImplementedException();

        public void Less()
        {
            Console.WriteLine($"\nЗадание № 1:");
            Tree<int> tree = new Tree<int>();
            tree.AddNode(new Node<int>(1000));
            tree.AddNode(new Node<int>(1100));
            tree.AddNode(new Node<int>(1200));
            tree.AddNode(new Node<int>(1210));
            tree.AddNode(new Node<int>(1220));
            tree.AddNode(new Node<int>(1230));
            tree.AddNode(new Node<int>(1240));
            tree.PrintTree();
        }
    }
}
    
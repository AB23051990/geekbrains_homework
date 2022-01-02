using System;
using System.Collections.Generic;

namespace Work6
{    
    public class Lessons6
    {
        /// <summary>
        ///  Модифицируйте DFS и BFS из предыдущего урока, но уже для графа, также с выводом каждого шага
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GraphNode<T> // Вершина
        {
            public T Value { get; set; }
            public List<Edge<T>> Edges { get; set; } //исходящие связи
            public GraphNode()
            {
                Edges = new List<Edge<T>>();
            }
        }
        public class Edge<T>//Ребро
        {
            public int Weight { get; set; }
            public GraphNode<T> Node { get; set; }
        }        
        public static void Lesson1()
        {
            Console.WriteLine($"\nЗадание № 1:");
            Console.WriteLine($"- модифицируйте DFS и BFS из предыдущего урока, но уже для графа, также с выводом каждого шага:");
            GraphNode<string> node0 = new GraphNode<string>()
            { Value = "Я" };
            GraphNode<string> node1 = new GraphNode<string>()
            { Value = "ОН" };
            GraphNode<string> node2 = new GraphNode<string>()
            { Value = "ОНА" };
            GraphNode<string> node3 = new GraphNode<string>()
            { Value = "ОНО" };
            Edge<string> node0node1 = new Edge<string>() { Node = node1 };
            Edge<string> node0node2 = new Edge<string>() { Node = node2 };
            Edge<string> node0node3 = new Edge<string>() { Node = node3 };
            node0.Edges.Add(node0node1);
            node0.Edges.Add(node0node2);
            node0.Edges.Add(node0node3);
            Console.WriteLine(node0.Edges);
            Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

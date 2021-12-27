using AlgorithmsAndDataStructures.GeneralClass;
using System;
using System.Collections.Generic;

namespace HomeWork15
{
    /// <summary>
    ///  задание 1
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
    class Less10 : GeneralClass
    {
        public string Name => throw new NotImplementedException();
        public void Less()
        {
            Console.WriteLine($"\nЗадание № 1:");
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
        }
    }
}

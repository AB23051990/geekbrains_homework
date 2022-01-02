using System;

namespace Work2
{
    /// <summary>
    /// реализация типа двусвязного списка.
    /// </summary>
    class Node // создаёт класс "Узел"
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    interface linkedList //Создание интерфейса списка
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }
    public class Lessons2
    {
        private Node head;
        private Node tail;
        public int Length { get; private set; }
        public string Name => throw new NotImplementedException();
        public void AddNode(int value) // добавляет новый элемент списка
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.PrevNode = tail;
                tail.NextNode = newNode;
            }
            tail = newNode;
            Length++;
        }        
        public void PrintList() //метод для вывода на консоль списка
        {
            string list = "";
            Node current = head;
            while (current != null)
            {
                list += $"Элемент|{current.Value}|,";
                current = current.NextNode;
            }
            Console.WriteLine(list);
        }
        public static void Lesson1()
        {
            Console.WriteLine($"\nЗадание № 1:");
            Console.WriteLine($"- реализация типа двусвязного списка");
            Lessons2 myList = new Lessons2();
            myList.AddNode(5464);
            myList.AddNode(6468);
            myList.AddNode(4496);
            myList.AddNode(5496);
            myList.PrintList();
            Console.WriteLine("для выхода в меню нажмите 'Enter' для завершения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

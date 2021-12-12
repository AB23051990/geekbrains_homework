using System;

namespace HomeWork11
{
    /// <summary>
    /// Практическая работа №2
    /// Задание №1 Двусвязный список Требуется реализация типа двусвязного списка. И контрольный пример, демонстрирующий использование методов. Интерактивный режим (взаимодействие с пользователем) не требуется.    /// 
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
    class NodeList // выполнил по подобию из видео Arifa в телеграмме
    {
        private Node head;
        private Node tail;
        public int Length { get; private set; }
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
        public void AddNodeAfter(Node node, int value)//не реализованный метод
        {
            throw new NotImplementedException();
        }
        public Node FindNode(int searchValue)//не реализованный метод
        {
            throw new NotImplementedException();
        }
        public int GetCount()//не реализованный метод
        {
            throw new NotImplementedException();
        }
        public void RemoveNode(int index) //не реализованный метод
        {
            throw new NotImplementedException();
        }
        public void RemoveNode(Node node) //не реализованный метод
        {
            throw new NotImplementedException();
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
    }
}
using System;
using System.Diagnostics;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Практическое задание №6
            /*Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
            позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
            помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
            утилиты Windows tasklist и taskkill.*/
            
            while (true)//Повторяет цикл приложения;
            {
                Process TaskManager = Process.Start("tasklist"); //открывает утилиту TaskManager выводит на экран запущенные процессы;
                
                Console.WriteLine("выберите метод завершения процесса где:" + //запрос от пользователя на завершение процесса;
                    "\n - 1 завершение по ID" +
                    "\n - 0 завершение по имени");
                string s = Console.ReadLine();
                int i = Convert.ToInt32(s);
                try { if (i <= -1 || i > 2) throw new Exception("Ошибка: введите число от 0 или 1"); }
                catch (Exception ex) { Console.WriteLine(ex.Message); return; }

                if (0 < i)//возможность завершения процессов с помощью указания его ID
                {   
                    Console.WriteLine("Введите ID процесса");
                    int V = Int32.Parse(Console.ReadLine());
                    var ID = Process.GetProcessById(V);
                    ID.Kill();
                    Console.WriteLine($"Процесс завершен {V}");
                }
                else //возможность завершения процессов с помощью указания его имени
                {   
                    Console.WriteLine("Введите имя процесса");
                    string E = Console.ReadLine();
                    Process[] localByName = Process.GetProcessesByName(E);
                    foreach (Process p in localByName)
                    {
                        p.Kill();
                    }
                    Console.WriteLine($"Процесс завершен {E}");
                }
                Console.WriteLine("__________________________________________________");
            }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        // сохранение файла
        void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
        // открытие файла
        void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
}

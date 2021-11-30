using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace Homework_9
{    /* Курсовой проект
     1. Просмотр файловой структуры
     2. Поддержка копирование файлов, каталогов
     3. Поддержка удаление файлов, каталогов
     4. Получение информации о размерах, системных атрибутов файла, каталога
     5. Вывод файловой структуры должен быть постраничным
     6. В конфигурационном файле должна быть настройка вывода количества элементов на страницу
     7. При выходе должно сохраняться, последнее состояние
     8. Должны быть комментарии в коде
     9. Должна быть документация к проекту в формате md
     10. Приложение должно обрабатывать непредвиденные ситуации(не падать)
     11. При успешном выполнение предыдущих пунктов – реализовать сохранение ошибки в текстовом файле в каталоге errors/random_name_exception.txt
     12. При успешном выполнение предыдущих пунктов – реализовать движение по истории команд(стрелочки вверх, вниз)
    */

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(" ____'Меню' выберите действие______" +
                               "\n |1 - Посмотреть дериктории       |" +
                               "\n |2 - Копировать фаил в дериктории|" +
                               "\n |3 - Создать папку в дериктории  |" +
                               "\n |4 - Удалить файл в дериктории   |" +
                               "\n |5 - Информация о файл           |");

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("Древо с файлами и каталогами__________________");
                Console.SetCursorPosition(50, 0);
                Console.WriteLine("Информация_______________________________________");
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("Командная строка_________________________________");
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("Строка ошибок_________________________________");               
                
                try
                {
                    Console.SetCursorPosition(50, 11);
                    string A = Console.ReadLine();
                    int i = Convert.ToInt32(A);

                    if (i == 1)
                    { Console.WriteLine(Trees("")); }

                    if (i == 2)
                    { Console.WriteLine(Copys("")); }

                    if (i == 3)
                    { Console.WriteLine(Creates("")); }

                    if (i == 4)
                    { Console.WriteLine(deleteFolder("")); }

                    if (i == 5)
                    { Console.WriteLine(info("")); }
                }
                catch (Exception)
                {
                    
                    Console.SetCursorPosition(50, 21);
                    Console.WriteLine("Ошибка: выберите цыфру от 1 до 5");
                }
                finally { }

            }
        }

        static string Trees(string Tree)//"1"
        {
            while (true)
            {
                try
                {
                    Console.SetCursorPosition(50, 12);
                    Console.WriteLine(@"Укажите путь каталога (пример: C:\)");
                    Console.SetCursorPosition(50, 13);
                    string B = Console.ReadLine();
                    Console.Clear();

                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("Папки:");
                    string[] allfolders = Directory.GetDirectories(B);
                    foreach (string folder in allfolders)
                    { Console.WriteLine(folder); }
                    Console.WriteLine("Файлы:");
                    string[] allfiles = Directory.GetFiles(B);
                    foreach (string filename in allfiles)
                    { Console.WriteLine(filename); }

                    Console.SetCursorPosition(50, 1);
                    DirectoryInfo dirInfo = new DirectoryInfo(B);
                    Console.SetCursorPosition(50, 2);
                    Console.WriteLine($"Название каталога: {dirInfo.Name}");
                    Console.SetCursorPosition(50, 3);
                    Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                    Console.SetCursorPosition(50, 4);
                    Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(50, 21);
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                finally { }
                return Tree;
            }
        }
        static string Copys(string Copy)//"2"
        {
            try
            {                
                Console.SetCursorPosition(50, 12);
                Console.WriteLine(@"Укажите полный путь файла для копирования (пример: C:\1.txt)");
                Console.SetCursorPosition(50, 13);
                string path = Console.ReadLine();                
                Console.SetCursorPosition(50, 14);
                Console.WriteLine(@"Укажите путь каталога вместе с именм файла для перемещения копии (пример: C:\Новая папка\1.txt)");
                Console.SetCursorPosition(50, 15);
                string newPath = Console.ReadLine();
                
                
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                { fileInf.CopyTo(newPath, true); }
                Console.Clear();

                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Файл скопирован в папку дериктории");
                
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally { }
            return Copy;
        }

        static string Creates(string Create)//"3"
        {
            try
            {
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Создание каталога");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine(@"Введите путь для создания каталога: (Пример - С:\test)");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine(@"Примечание: созданная папка без пути переносится в директорию по умолчанию");
                Console.SetCursorPosition(50, 15);
                string path = Console.ReadLine();

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {dirInfo.Create();}
                Console.Clear();

                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Папка создана");
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally { }            

            return Create;
        }
        static string deleteFolder(string folder)//"4"
        {
            try
            {
                Console.SetCursorPosition(50, 12);
                Console.WriteLine(@"Укажите полный путь файла для удаления (пример: C:\1.txt)");
                Console.SetCursorPosition(50, 13);
                string D = Console.ReadLine();

                string path = D;
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {fileInf.Delete();}
                Console.Clear();

                Console.SetCursorPosition(50, 12);
                Console.WriteLine(@"Фаил удалён");
                
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Ошибка:" + ex.Message);
            }
            return folder;
        }
        static string info(string folder)//"5"
        {
            try
            {
                Console.SetCursorPosition(50, 12);
                Console.WriteLine(@"Укажите полный путь файла для информации (пример: C:\1.txt)");
                Console.SetCursorPosition(50, 13);
                string D = Console.ReadLine();
                

                string path = D;
                FileInfo fileInf = new FileInfo(path);
                Console.Clear();
                if (fileInf.Exists)
                {
                    Console.SetCursorPosition(50, 2);
                    Console.WriteLine("Имя файла: {0}", fileInf.Name);
                    Console.SetCursorPosition(50, 3);
                    Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                    Console.SetCursorPosition(50, 4);
                    Console.WriteLine("Размер: {0} байт", fileInf.Length);
                }
                
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Ошибка:" + ex.Message);
            }
            return folder;
        }

    }
}


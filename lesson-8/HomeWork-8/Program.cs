using System;
using System.IO;
using System.Text.Json;
using ExampleLibrary;
using HomeWork_8.Properties;

namespace HomeWork_8
{
    class ConfigurationManager
    {   
    }
    class MyOptions
    { }
    class Program
    {
        static void Main(string[] args)
        {
            // Практическое задание №8
            /*Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения(application - scope).
            Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
            При следующем запуске отобразить эти сведения. Задать приложению версию и описание.*/

            Greeting.SayHello();

            // 1 приложение выводит приветствие, записанное в настройках приложения(application - scope):
            Console.WriteLine(Resources.ApplicationScope);

            // 2 Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках. При следующем запуске отобразить эти сведения.
            
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var options = configuration.GetSection("CustomOptions").Get<MyOptions>();
            Console.WriteLine(options.Title);
            File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));


            Console.WriteLine(ConfigurationManager.AppSettings["UserName"]);
            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeCofigurationFileMap { ExeConfigFilename = roaming.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("UserName", Console.ReadLine());
            config.Save();
            Console.WriteLine(roaming.FilePath);
            var userName = config.AppSettings["UserName"].Value;
            Console.WriteLine(userName);
            config.AppSettings["UserName"].Value = $"{userName}_{DateTime.Now}";
            config.Save();

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName1 = Properties.Settings.Default.UserName;
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}, {userName1}!");


            // 3 Задать приложению версию и описание

        }


    }
    
    
}


/*
 * 
  

            
*/
/*
*/
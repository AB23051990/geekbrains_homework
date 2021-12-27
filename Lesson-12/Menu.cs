using System;
using System.Diagnostics;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.GeneralClass;
using HomeWork13;
using HomeWork12;
using HomeWork11;
using HomeWork10;
using HomeWork14;
using HomeWork15;
using System.IO;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace HomeWork
{
    /// <summary>
    /// Реализовать загрузку списка уроков из файла.
    /// </summary>
    class Menu
    {
        static void Main(string[] args)
        {
            var menu0 = new ConfigurationBuilder();//передаём ссылку Json на сборку 
            IConfiguration menu = Buildmenu(menu0);
            // дальше незнаю что делать

            var builder = new ConfigurationBuilder();//обработчик ошибок из первого урока
            IConfiguration configuration = BuildConfig(builder);
            Log.Logger = new LoggerConfiguration()
                            .ReadFrom.Configuration(configuration)
                            .CreateLogger();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Log.Logger.Verbose("Приложение запущено");
            Log.Logger.Debug("Приложение запущено");
            Log.Logger.Information("Приложение запущено");
            Log.Logger.Warning("Приложение запущено");
            Log.Logger.Error("Приложение запущено");
            Console.WriteLine("Нажмите 'Enter' для завершения работы");
            Console.ReadLine();
            Log.Logger.Information("Работа приложения завершена");
        }
        static IConfiguration Buildmenu(IConfigurationBuilder menu0) // ссылка на сборку в Json файле
        {
            return
                menu0.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("menu.json")
                .Build();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception unhandledException = (Exception)e.ExceptionObject;
            Log.Error(unhandledException, "Необработанное исключение");
        }
        static IConfiguration BuildConfig(IConfigurationBuilder builder)
        {
            return
                builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
        
    }
}
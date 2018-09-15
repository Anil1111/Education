using System;
using System.Reflection;

//Глобальные аттрибуты для всей сборки. Ключевое слово assembly на просто помогает и оттеняет, что атрибут описывает сборку.
//Очень удобно использовать аттрибут для описания сборки!
[assembly: AssemblyVersion("1.0.2000.0")]                   //Версия сборки
[assembly: AssemblyTitle("AssemblySmpl")]                   //Имя сборки
[assembly: AssemblyDescription("some description")]          //Описание сборки
[assembly: AssemblyConfiguration("some configuration")]     //Конфигурация - например Release или Debug
[assembly: AssemblyCompany("Roman Company")]                 //Имя компании разработчика
[assembly: AssemblyProduct("AssemblyProductName")]           //Имя продукта
[assembly: AssemblyCopyright("Copyright 2009")]              //Копирайты
[assembly: AssemblyTrademark("Some trade mark")]             //Торговая марка
[assembly: AssemblyCulture("")]                              //Какие культуры поддерживает сборка

//Пример использования : у меня есть приложение и к моему приложению другие разработчики пишут плагины.
//я бы мог сказать этим ребятам про определнный атрибут сборки и помощью этого атрибута проверять, этот точно dll`ка, котрая как плагин,
//ее точно нужно подключить или нет?


namespace _004_Attributes_assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получение сборки (Assembly assembly) код которой выполняется в данный момент
            Assembly assembly = Assembly.GetExecutingAssembly();

            //Полное имя сборки
            Console.WriteLine($"Assembly Full Name:\n{assembly.FullName}");

            //AssemblyName - позволяет разбить полное имя сборки на части.
            AssemblyName assemblyName = assembly.GetName();

            Console.WriteLine($"\nИмя сборки: {assemblyName.Name}");
            Console.WriteLine($"Версия сборки: {assemblyName.Version.Major}.{assemblyName.Version.Minor}");
            Console.WriteLine($"\nМесто хранения сборки: {assemblyName.CodeBase}");

            //Точка входа сборки.
            Console.WriteLine("\nAssembly entry point:");
            Console.WriteLine(assembly.EntryPoint);

            //Delay
            Console.ReadKey();
        }
    }
}

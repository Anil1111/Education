using System;
using System.Collections.Specialized;
using System.Configuration;

namespace _001_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Configuration  - пространство имен для работы с файлами конфигурации.
            //Конфигруационный файл - файл в XML формате, в котором храняться настройки. Он лежит возле exe`шника
            //и когда программа запускается - он тянет оттуда все настройки.

            //Foo - слово, которое части используется в примерах, переводится как "пустышка"

            //!!!ВАЖНО!!! Нужно менять файл App.config, а не bin/Debug/001_Configuration.exe.config. 
            //Содержимое файла bin/Debug/001_Configuration.exe.config меняется каждый раз на 
            //содержимое App.config.

            //1 (Устарел)
            string value = ConfigurationSettings.AppSettings["Foo"];
            Console.WriteLine(value);
            Console.WriteLine(new string('-', 12));

            //2
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            //лучше не делать 2х ключей с одинаоквым именем  
            //Я добавил <add key ="Foo" value ="Hello World!!!!"/> и мне ниже вывело Hello World!!!!, хотя,
            //там есть ещё значение с таким же ключем
            Console.WriteLine(appSettings["Foo"]); 
            Console.WriteLine(appSettings[0]);

            Console.WriteLine(new string('-', 12));

            //3
            for (int i = 0; i < appSettings.Count; i++)
            {
                Console.WriteLine(appSettings[i]);
            }

            Console.WriteLine(new string('-', 12));

            foreach (string settingItem in appSettings)
            {
                Console.WriteLine(appSettings[settingItem]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

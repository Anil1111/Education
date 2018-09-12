using System;
using System.Configuration;

namespace _025_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Как правило - в больших проектах пишется свой ConfigurationManager.

            //В десктопных приложениях файл с конфигурациями называется App.config, в веб - Web.config

            //NameValueCollection - словарь без проверки ключей на уникальность. 
            //У меня сейчас 2 элемента с одинаковыми ключами. Проблем нету, но ConfigurationManager.AppSettings вернул мне только 1 элемент - 
            //т.е второе значение (Val2) перезаписало первое (Val1), ПО ЭТОМУ НУЖНО ИСПОЛЬЗОВАТЬ ТОЛЬКО УНИКАЛЬНЫЕ КЛЮЧИ
            foreach (string item in ConfigurationManager.AppSettings) 
            {
                Console.WriteLine(item + " - " + ConfigurationManager.AppSettings[item]);
            }

            //ConfigurationManager.AppSettings - не распространенная вещь в консольных приложениях, по этому и не было Refferance`ах не было System.Configuration;
            //ConfigurationManager.AppSettings активно успользуются в других технологиях - MVC, WPF, Entity Framework etc.

            //Delay
            Console.ReadKey();
        }
    }
}

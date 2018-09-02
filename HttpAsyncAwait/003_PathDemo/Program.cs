using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PathDemo
{
    //Пример работы с классом Path
    class Program
    {
        static void Main(string[] args)
        {
            //Класс Path - это илюзия. Он не работает с файлом, но работает только со строкой(путь)

            //Создание строки, содержащей адресс
            string path = @"C:\Windows\notepad.exe";
            Console.WriteLine(path);

            //Вывод на экран значений свойств класса-объекта Pah
            Console.WriteLine($"Extension: {Path.GetExtension(path)}"); //т.е просто откусываем расширение

            //ChangeExtension не изменят расширение у файла - он просто создает строку с другим расширеним
            //которую вы сами должны использовать для реального переименования(Path.ChangeExtesion)
            Console.WriteLine($"Change Path: {path = Path.ChangeExtension(path, "bak")}");
            Console.WriteLine(path);

            //Delay
            Console.ReadKey();
        }
    }
}

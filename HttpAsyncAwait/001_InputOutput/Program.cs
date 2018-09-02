using System;
using System.IO;

namespace _001_InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //В .NET есть пространство имен -System.IO (input - output), в котором определены классы для работы с файловой системы
            //Мы даже может выделить в ОЗУ место и записать туда информацию.
            //Есть временные объекты, которые живут в ОЗУ, а есть постоянные(персистентные) объекты, которые живут на дисках.

            //!!!ВАЖНО
            //На диске не может ыть двух файлов с одинаковыми именами! 
            //Полное имя каждого файла состоит из пути к файлу + имени файла, например
            //D:\folder1\folder2\file.txt

            //Получание информации о директории

            //Экземплр класса DirectoryInfo, ссылается на директори - C:\Windows\assembly
            var directory = new DirectoryInfo(@"C:\Windows\assembly");

            //Вывод информации о каталоге (Директории).
            if (directory.Exists) //Если указанная директория существует - выводим и ней информацию
            {
                Console.WriteLine($"FullName       : {directory.FullName}");
                Console.WriteLine($"Name           : {directory.Name}");
                Console.WriteLine($"Parent         : {directory.Parent}");
                Console.WriteLine($"CreationTime   : {directory.CreationTime}");
                Console.WriteLine($"Attributes     : {directory.Attributes}"); //создать файл-> ПКМ->свойства->security и там есть Modify, Read & Execute, Read, Write etc.
                Console.WriteLine($"Root           : {directory.Root}");
                Console.WriteLine($"LastAcessTime  : {directory.LastAccessTime}");
                Console.WriteLine($"LastWriteTime  : {directory.LastWriteTime}");
            }
            else
            {
                Console.WriteLine($"Директория с именем {directory.Name} не сещуствует");
            }

            //Операционная система Windows собирается по кусочкам. Тут, кто занимается сборкой Windows
            // у того не Visual Studio, а Embeded Studio.

            //Delay
            Console.ReadKey();
        }
    }
}

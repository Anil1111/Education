﻿using System;
using System.IO;

namespace _001_InputOutput
{
    class Program
    {
        //!!!ВАЖНО! Очень важно ставить try-catch в операциях с файловой системой. Наведи на любой метод и 
        //посмотри сколько исключений может посыпаться. Лучше предохраняться или же хотя бы проверять файл на наличие прежде чем с ним работать.
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
                Console.WriteLine($"FullName       : {directory.FullName}"); //Полное имя дериктории(включая путь.)
                Console.WriteLine($"Name           : {directory.Name}"); //Имя директории(без пути)
                Console.WriteLine($"Parent         : {directory.Parent}"); //Путь к родительской директории
                Console.WriteLine($"CreationTime   : {directory.CreationTime}"); //Время создания
                Console.WriteLine($"Attributes     : {directory.Attributes}"); //создать файл-> ПКМ->свойства->security и там есть Modify, Read & Execute, Read, Write etc.
                Console.WriteLine($"Root           : {directory.Root}");  //Корневой диск, на котором находится директория С или D(у меня) - например C:\
                Console.WriteLine($"LastAcessTime  : {directory.LastAccessTime}"); //Время поледнего доступа к каталогу
                Console.WriteLine($"LastWriteTime  : {directory.LastWriteTime}");  //Время последних изменений внутри каталога(переименовывали, обавляли файлы, удаляли файлы)
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

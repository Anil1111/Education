using System;
using System.IO;

namespace _002_InputOutput
{
    //Получаение информации о файлах, хранящихся в директории.
    //Для тестирования данного примера требуется предварительно создать на диске D
    //директорию TESTDIR в поместить в нее некоторое количество файлов с расширением .txt
    class Program
    {
        static void Main(string[] args)
        {
            //C:\project\Education\HttpAsyncAwait\002_InputOutput\bin\Debug , там где лежит .exe`шник
            var directory = new DirectoryInfo(@"."); //мы будем получать информацию о файлах из директории, где хранится исполняемый файл

            if (directory.Exists)
            {
                Console.WriteLine($"FullName       : {directory.FullName}");
                Console.WriteLine($"Name           : {directory.Name}");
                Console.WriteLine($"Parent         : {directory.Parent}");
                Console.WriteLine($"CreationTime   : {directory.CreationTime}");
                Console.WriteLine($"Attributes     : {directory.Attributes}");
                Console.WriteLine($"Root           : {directory.Root}");

                //Получаем все файлы с расширением .txt
                FileInfo[] files = directory.GetFiles("*.txt"); //"*.txt" - фильтр. Можем его указывать, а можем и не указывать.

                //Сколько файлов с расширением .txt в данной директории
                Console.WriteLine($"Найдено {files.Length} *.txt файлов\n");

                //Выводим информацию о каждом файле.
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"File name      : {file.Name}");
                    Console.WriteLine($"File size      : {file.Length}");
                    Console.WriteLine($"Creation time  : {file.CreationTime}");
                    Console.WriteLine($"Attributes     : {file.Attributes.ToString()}");
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine($"Файлов не найдено.");
            }


            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем новый файл в корне диска D
            var file = new FileInfo(@"D:\Test.txt"); //можем создать любой файл любого формата, ДАЖЕ НЕ СУЩЕСТВУЮЩИЙ!

            file.Create(); 
           

            //Выводим основную информацию о созданном файле.
            Console.WriteLine($"Full Name    : {file.FullName}");
            Console.WriteLine($"Attributes   : {file.Attributes.ToString()}");
            Console.WriteLine($"CreationTime : {file.CreationTime}");

            Console.WriteLine("Нажмите любую клавишу для удаление файла");
            Console.ReadKey();

            //Удаляем файл
            file.Delete(); //т.е директории мы удаляем так: Directory.Delete(@"D:\TESTDIR\SUBDIR");, а файлы -через экземпляр класса FileInfo.
            
            Console.WriteLine("Файл успешно удален.");

            //Delay
            Console.ReadKey();
        }
    }
}

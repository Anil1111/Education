using System;
using System.IO;

namespace _003_InputOutput
{
    //Создание директорий
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"D:\TESTDIR");
            Console.WriteLine(directory.FullName);

            //Создание в TESTDIR новых подкаталогов.
            if (directory.Exists)
            {
                //Создаем D:\TESTDIR\SUBDIR.
                directory.CreateSubdirectory("SUBDIR");

                //Создаем  D:\TESTDIR\MyDir\SubMyDir
                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы");
            }
            else
            {
                Console.WriteLine($"Директория с именем: {directory.Name} не существует.");
            }

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;

namespace _004_DisksInfoAndDirectoryRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выводим информацию о дисках.

            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Имещиеся диски:");

            foreach (var drive in drives)
            {
                Console.WriteLine($"- {drive}");
            }

            var directory = new DirectoryInfo(@"D:\TESTDIR");

            Console.WriteLine("\nГотовимся удалять");
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine("\nНажмите Enter для удаления. \n");

            //Задержка перед удалением.
            Console.ReadKey();

            //Создай в D:\TESTDIR\SUBDIR и D:TESTDIR\MyDir файлы
            try
            {
                //Удаление каталогов
                Directory.Delete(@"D:\TESTDIR\SUBDIR"); //Exception т.к я в папке SUBDIR создал файл и она НЕ ПУСТА
                //а метод Directory.Delete() с одним параметром нужен, чтобы удалять ПУСТЫЕ директории.

                //Второй параметр определяет, будут ли уалены так же И ВЛОЖЕННЫЕ ПОДКАТОЛОГИ.
                Directory.Delete(@"D:TESTDIR\MyDir", true);

                Console.WriteLine("Каталоги успешно удалены.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

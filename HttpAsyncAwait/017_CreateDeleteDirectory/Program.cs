using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_CreateDeleteDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!ВАЖНО! Очень важно ставить try-catch в операциях с файловой системой. Наведи на любой метод и 
            //посмотри сколько исключений может посыпаться. Лучше предохраняться или же хотя бы проверять файл на наличие прежде чем с ним работать.

            var directory = new DirectoryInfo(@"D:\TESTDIR");
            Console.WriteLine(directory.FullName);

            //Создание в TESTDIR новых подкаталогов.
            if (directory.Exists)
            {
                //Создаем D:\TESTDIR\SUBDIR.  т.е папку внутри directory(@"D:\TESTDIR")
                directory.CreateSubdirectory("SUBDIR");

                //Создаем  D:\TESTDIR\MyDir\SubMyDir
                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы");
            }
            else
            {
                Console.WriteLine($"Директория с именем: {directory.Name} не существует.");
            }

            //Выводим информацию о папках.
            Console.WriteLine("\nГотовимся удалять");
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine("\nНажмите Enter для удаления. \n");

            //Задержка перед удалением.
            Console.ReadKey();

            //Создай в D:\TESTDIR\SUBDIR и D:TESTDIR\MyDir файлы
            try
            {
                //Удаление каталогов - есть обычный метод, а есть статический Directory.Delete
                //new DirectoryInfo(@"D:\TESTDIR\SUBDIR").Delete();
                Directory.Delete(directory.FullName + @"\SUBDIR"); //Exception т.к я в папке SUBDIR создал файл и она НЕ ПУСТА
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

            //Delay
            Console.ReadKey();
        }
    }
}

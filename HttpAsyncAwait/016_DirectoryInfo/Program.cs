using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получание информации о директории

            //C:\Windows\assembly - путь к папке, которую мы зотим исследовать
            //Так же мы можем указать путь к несуществущей папке, тогда часть параметров(см ниже) будут указаны или недоступны
            //Кстати, так же и файлами - мы можем указать на несуществуюий файл
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

            //Delay
            Console.ReadKey();
        }
    }
}

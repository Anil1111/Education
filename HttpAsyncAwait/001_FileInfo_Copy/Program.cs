using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_FileInfo_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем обект для работы с файлом.
            var file = new FileInfo(@"C:\Windows\notepad.exe");

            //Копируем содержимое файла.
            try
            {
                file.CopyTo(@"D:\newName.exe"); //можно дать новое имя файлу
                Console.WriteLine("Файл успешно скопирован.");
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

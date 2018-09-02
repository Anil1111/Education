using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_StreamReader
{
    //Поиск по файлу.
    //Для тестирования данного примера создайте файл: D:\test.txt

    //Запишите в файл следующие строки: alt+shift и можно выделить прямоугольником.
    //Hello
    //Roman!
    //How
    //are
    //you?

    class Program
    {
        static void Main(string[] args)
        {
            //Подготовка файла
            using (StreamReader reader = File.OpenText(@"D:\test.txt"))
            {
                //Последовательный обход файла
                while (!reader.EndOfStream)
                {
                    //Чтение файла построчно
                    string line = reader.ReadLine();

                    //Если нужный текст найден - прекратить чтение
                    if (line != null && line.Contains("Roman"))
                    {
                        //Обнаружив слово "Roman", уведомить пользователя и прекратить чтение.
                        Console.WriteLine("Found:");
                        Console.WriteLine(line);
                        break; //выводит из цикла while
                    }
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}

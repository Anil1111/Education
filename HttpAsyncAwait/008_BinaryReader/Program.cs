using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_BinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Открываем файл (и получаем поток)
            FileStream file = File.Open(@"D:\test.txt", FileMode.Open);

            //Сообщаем поток с файлом
            var reader = new BinaryReader(file);

            //Читаем из файла разные данные.
            long number = reader.ReadInt64();
            byte[] bytes = reader.ReadBytes(4);
            string s = reader.ReadString();

            //Удаляем поток.
            reader.Close();

            //Выводим на экран то, что удалось прочитать.
            Console.WriteLine(number);
            foreach (var b in bytes)
            {
                Console.Write($"[{b}]");
            }

            Console.WriteLine();
            Console.WriteLine(s);

            //Delay
            Console.ReadKey();
        }
    }
}

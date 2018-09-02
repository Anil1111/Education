using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_OperativeMemory
{
    // Чтение/запись файлов
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект класса MemoryStream

            var memory = new MemoryStream();

            //Задаем требуемый объем памяти.
            memory.Capacity = 256; //память не резиновая и дорогая) просим выделить 256 байт в ОЗУ

            //Записываем байти в поток
            for (var i = 0; i < 256; i++)
            {
                memory.WriteByte((byte)i);
            }

            // Переставлем внутренний указатель на начало
            memory.Position = 0;

            //Считываем байты из потока
            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + memory.ReadByte()); //ReadByte читает и увеличивает memory.Position на 1
            }

            Console.WriteLine("\n" + new string('-', 80));

            //Сохраняем данные из MemoryStream в массив байт.
            byte[] array = memory.ToArray();

            foreach (var b in array)
            {
                Console.Write(" " + b);
            }

            Console.WriteLine("\n" + new string('-', 80));

            //Сохраняем данные из MemoryStream в файл.

            var file = new FileStream("Dump.dat", FileMode.Create, FileAccess.ReadWrite);
            memory.WriteTo(file);

            //Переставлем внутренний указатель на начало
            file.Position = 0;

            // Ситывааем байты из файла
            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + file.ReadByte());
            }

            memory.Close(); //Закрываем MemoryStream
            file.Close();   //Закрываем FileStream

            //Delay
            Console.ReadKey();
        }
    }
}

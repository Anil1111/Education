using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_WrittingToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем файл в текущем каталоге.
            var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //Записываем байты в файл.
            for (int i = 0; i < 256; i++)
            {
                stream.WriteByte((byte)i);
            }

            Console.WriteLine($"stream.Position = {stream.Position}");

            //Преставлям внутренний указатель на начало.
            stream.Position = 0; //очень важная штука! Нужно переставлять его в начало вручную.

            //Считываем байты из файла.
            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + stream.ReadByte());
            }

            // Закрываем FileStream
            stream.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

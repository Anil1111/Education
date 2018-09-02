using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ReadWriteStream
{
    //!!!!ВАЖНО
    //StringReader`ы и StringWriter`ы просто вспомагательные средства, чтобы считывать и записыаать информацию.
    //Т.е мы что-то набираем в них, а потом сбрасываем в Stream(MemoryStream) etc.

    //А StreamWriter`ы и StreamReader`ы - пишут и читают из файла!
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryStream наследуется от абстрактного класса Stream
            Stream stream = new MemoryStream();

            //Добавляем в поток данные
            Console.WriteLine("Запись в поток начата...");
            AppendToStream(stream, new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.WriteLine("Данные успешно записаны");

            //Считываем назад
            Console.WriteLine("\nСодержимое потока:");
            DumpStream(stream);

            //Удаляем поток.
            stream.Close();

            //Delay
            Console.ReadKey();
        }

        //Метод для добавления данных в поток
        static void AppendToStream(Stream stream, byte[] data)
        {
            //Установить курсор в коцен потока
            stream.Position = stream.Length;

            //Добавить байты
            stream.Write(data, 0, data.Length);
        }

        //Метод для вывода содердимого потока на экран
        static void DumpStream(Stream stream)
        {
            //Установить курсор на начало потока.
            stream.Position = 0;

            //Обработать поток в цике и показать его содержимое.
            while (stream.Position != stream.Length)
            {
                Console.WriteLine("{0:x3", stream.ReadByte());
            }
        }
    }
}

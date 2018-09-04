using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Zip_Compression
{
    //Архивая файлов - перекодирование данных с целью уменьшения их объема
    //Разархивация - процесс, обратный архивации, т.е. процес восстановления данных из архивных файлов.

    //Zip - популярный формат сжатия данных и архивации файлов. Файл в этом формате обычно имеет расширение .zip
    //и хранит в сжатом или несжатом виде один или несколько файлов. Термин "ZIP" предлагается интерпретировать как "скорость".

    //Deflate - это алгоритм сжатия без потерь, который использует комбаниию алгоритма LZ77 и алгоритма Хаффмана.

    //Библиотек много - и не обязательно использовать именно эти: GZipStream, DeflateStream
    class Program
    {
        static void Main(string[] args)
        {
            //Создание файла и запись в него данных
            var fieStream = File.Open(@"D:\test_zip_1.txt", FileMode.OpenOrCreate);

            //у StreamWriter`а немножко поудобнее запись, чем у стандартного 
            //FileStream`а, который нам любезно возвращается когда файл создается.
            //FileStream может читать и писать, но из него мы всегда можем сделать более удобные StreamWriter и StreamReader
            using (StreamWriter writter = new StreamWriter(fieStream))
            {
                writter.WriteLine("Hello, Roman from Zip");
                //Вот после операторной скобки заароются writter и fieStream
            }
            //Создание архива
            FileStream destination = File.Create(@"D:\archive_zip.zip");

            //Создание компрессора - используется паттерн Дкоратор.
            //Назначение этого паттерна - добавить новые обязанности объекту.
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            using (var fieStream2 = File.Open(@"D:\test_zip_1.txt", FileMode.OpenOrCreate))
            {
                //Заполнение архива информацией из файла - тут лучше применить do while!!!!!, смотри пример 003_Zip_Decompression
                int theByte = fieStream2.ReadByte();
                while (theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = fieStream2.ReadByte();
                }
            }

            //Удвление компрессора
            compressor.Close();
        }
    }
}

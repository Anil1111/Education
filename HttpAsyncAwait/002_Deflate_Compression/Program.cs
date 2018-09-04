using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Deflate_Compression
{
    class Program
    {
        //Некоторые архивы имеют заголовки - например ZIP, а Deflate - не имеют таких заголовков
        //по этому я и не могу открыть его через стандартный архиватор.
        static void Main(string[] args)
        {
            //Создание файла
            FileStream fileStream = File.Open(@"D:\test_dfl_1.txt", FileMode.OpenOrCreate);

            //Запись в файл
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Privet, Roman from Deflate");

            //Создание архива
            FileStream archiveStream = File.Create(@"D:\archive_dfl.dfl");

            DeflateStream compressor = new DeflateStream(archiveStream, CompressionMode.Compress);

            // тут лучше применить do while!!!!! смотри пример 003_Zip_Decompression
            int theByte = fileStream.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = fileStream.ReadByte();
            }

            writer.Close();
            compressor.Close();
        }
    }
}

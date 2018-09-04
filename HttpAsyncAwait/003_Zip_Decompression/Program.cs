using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Zip_Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream archiveStream = File.OpenRead(@"D:\archive_zip.zip");

            FileStream destinationStream = File.Create(@"D:\txt_destnation_zip.txt");

            GZipStream deCompressor = new GZipStream(archiveStream, CompressionMode.Decompress);

            //В прошлых примерах цикл бы неправильный! нужно  do - while
            do
            {
                var theByte = deCompressor.ReadByte();
                if (theByte == -1)
                {
                    break;
                }
                destinationStream.WriteByte((byte)theByte);
            }
            while (true); //появлялось"я" в файле, потому, что оно записывало -1. пришлось сделать do - while (true) и выход из цикла.

            //int theByte = deCompressor.ReadByte();
            //while (theByte != -1)
            //{
            //    destinationStream.WriteByte((byte)theByte);
            //    theByte = deCompressor.ReadByte();
            //}

            deCompressor.Close();
            destinationStream.Close();
        }
    }
}

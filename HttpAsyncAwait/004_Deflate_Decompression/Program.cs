using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Deflate_Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream archiveStream = File.OpenRead(@"D:\archive_dfl.dfl");

            FileStream destinationStream = File.Create(@"D:\txt_destnation_dfl.txt");

            DeflateStream deCompressor = new DeflateStream(archiveStream, CompressionMode.Decompress);

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


            deCompressor.Close();
            destinationStream.Close();
        }
    }
}

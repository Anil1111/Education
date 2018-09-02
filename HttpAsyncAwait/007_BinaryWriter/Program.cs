using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем файл
            FileStream file = File.Create(@"D:\test.txt");

            //Сообщаем с файлом на BinaryWriter
            var writer = new BinaryWriter(file); //это писатель, который не будет без спроса менять кодиировку
            //а StreamWriter - может

            //Записываем в файл разные данные.
            long number = 100;
            var bytes = new byte[] {10, 20, 50, 100};
            string s = "hunger";

            writer.Write(number);
            writer.Write(bytes);
            writer.Write(s);

            //Удаляем поток
            writer.Close();

            //Delay
            Console.ReadKey();


        }
    }
}

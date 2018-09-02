using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_StreamReader
{
    //Раота с классом StreamReader. Различные способы полученияинформации из файла.
    class Program
    {
        static void Main(string[] args)
        {
            //Открываем файл дя чтения
            FileStream file = File.Open(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.Read);

            //Создаем поток для чтения данных из файла
            StreamReader reader = new StreamReader(file);
            
            //Читаем до конца
            Console.Write(reader.ReadToEnd());

            //Закрываем файл и удаляем поток.
            reader.Close();
            //file.Close(); Закрывать на обязательно так, как reader закроет сам.

            Console.WriteLine("\n");

            //Еще раз открываем файл, используя ДРУГОЙ СПОСОБ
            StreamReader newReader = File.OpenText(@"D:\test.txt");

            //Читаем до конца и закрываем файл
            Console.WriteLine(newReader.ReadToEnd());
            reader.Close();

            Console.WriteLine("\n");

            //Delay
            Console.ReadKey();
        }
    }
}

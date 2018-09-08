using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Unicoding_003_ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание файла в кодировке UTF7.
            string file = "file.txt";
            StreamWriter writer = new StreamWriter(file, false, Encoding.UTF7);
            writer.WriteLine("Привет, мир!");
            writer.Close();

            //Cчитывание содержимого фала с явным указанием кодировки.
            StreamReader reader = new StreamReader(file, Encoding.UTF7);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            //Считывание содержимого файла БЕЗ указания кодировки.
            reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd()); //псмотри что выведется! Вот что значит принебрегать кодировками!
            reader.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

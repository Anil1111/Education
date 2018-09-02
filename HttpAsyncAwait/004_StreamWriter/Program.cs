using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_StreamWriter
{
    //Запись в файл
    class Program
    {
        static void Main(string[] args)
        {
            //Создание файла.
            FileStream file = File.Create(@"D:\test.txt");

            // 1 способ
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Hello");
            writer.Close();
            //file.Close(); //не нужно

            // 2 способ
            StreamWriter writer2 = File.CreateText(@"D:\test2.txt");
            writer2.WriteLine("Hello2");
            writer2.Close();

            // 3 способ
            File.WriteAllText(@"D:\test3.txt", "Hello3");

            // 4 способ
            file = null;
            file = File.Open(@"D:\test4.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
            file.Close();

            //5 способ
            file = File.OpenWrite(@"D:\test5.txt");
            //file.Close(); // чтобы в примере ниже было исключение

            //6. Будет исклюение, так как файл занят!
            file = File.Open(@"D:\test4.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            //file.Close();

            //Streams необходимо закрывать!

            //Delay
            Console.ReadKey();
        }
    }
}

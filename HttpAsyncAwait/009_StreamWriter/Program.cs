using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем файл
            var file = new FileInfo("Text.txt");

            //у StreamWriter`а немножко поудобнее запись, чем у стандартного 
            //FileStream`а, который нам любезно возвращается когда файл создается. вот как тут -> //var fieStream = File.Open(@"D:\test_zip_1.txt", FileMode.OpenOrCreate);
            //FileStream может читать и писать, но из него мы всегда можем сделать более удобные StreamWriter и StreamReader
            //С помощью экземпляра StreamWriter записываем в файл несколько строк текста
            StreamWriter writer = file.CreateText();

            writer.WriteLine("Первая строка текста...");
            writer.WriteLine("Вторая строка текста...");

            //Вставляем символ начала новой строки.C:\project\Education\HttpAsyncAwait\009_StreamWriter\bin\Release\
            writer.Write(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            //Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            //Метод Close() автоматически очищает все буферы!
            writer.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            //Delay
            Console.ReadKey();
        }
    }
}

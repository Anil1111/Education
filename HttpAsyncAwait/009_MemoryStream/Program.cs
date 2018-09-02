using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_MemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            var memory = new MemoryStream();

            var writer = new StreamWriter(memory); //конфигурируем StreamWriter MemoryStream`ом
            writer.WriteLine("Hello");
            writer.WriteLine("GoodBye");

            //Приказать объекту-записи writer, переписать данные в поток - memory.
            //Flush() - очищает все буферы для текущаего средства записи и вызывает запись всех данных В ПОТОК memory
            writer.Flush();

            //Создать файловый поток.
            FileStream file = File.Create(@"D:\test.txt");

            //Переписать содержимое потока памяти в файл целиком.
            memory.WriteTo(file);
            file.Close();

            var reader = File.OpenText(@"D:\test.txt");
            Console.WriteLine(reader.ReadToEnd());

            //Освободить ресурсы.
            writer.Close();
            memory.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

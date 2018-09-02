using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_FileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем файл
            //var file = new FileInfo("Text.txt");

            //С помощью экземпляра StreamWritter записываем в файл несколько строк текста.
            //StreamWriter writer = file.CreateText();

            var file2 = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            var writter2 = new StreamWriter(file2, Encoding.GetEncoding(1251));

            writter2.WriteLine("Первая строка текста...");
            writter2.WriteLine("Вторая строка текста...");

            //Вставляем символ начала новой строки
            writter2.Write(writter2.NewLine);

            writter2.WriteLine("Треться строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writter2.Write(i + " ");
            }

            //Метод Close автоматически очищает все буфферы.
            writter2.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            //Выводим информацию из файла на консоль при помощи StreamWriter.
            Console.WriteLine("Содеримое файла Text.txt:\n");

            StreamReader reader = File.OpenText("Text.txt");

            string input;
            while ((input = reader.ReadLine()) != null) //когда дошли до конца, метод ReadLine() возвращает null
            {
                Console.WriteLine(input);
            }

            reader.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

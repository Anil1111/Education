﻿using System;
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

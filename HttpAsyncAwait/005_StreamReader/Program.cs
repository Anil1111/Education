using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_StreamReader
{
    //Чтение из потоков
    class Program
    {
        static void Main(string[] args)
        {
            // \r - возвращает на начало строки(это называется переводом каретки)
            string s = "Hello all!" + Environment.NewLine + "This is a multi-line \n\r text string.";

            var reader = new StringReader(s); //позволяет работать со string`ой как с потоком. Например: если у нас есть
            //электронная книга, то нам не нужно открывать ее все. нам нужно только 1 страницу и это можно сделать с помощью StringReader

            //Метод Peek возвращает целочисленное значение, чтобы определить, произола ли ошибка или достигнут конец файла.
            //Это позволяет пользователю сначала проверить, не равно ли возвращенное значение -1, прежде чем приводить его к типу Char.

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

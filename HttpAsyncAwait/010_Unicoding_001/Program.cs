using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Unicoding_001
{
    class Program
    {
        //есть кодовая таблица. в ней есть код элемента и рисунок этого элемента, кототорый лежит в соответствии с его кодом
        static void Main(string[] args)
        {
            //Строка для изменения кодировок.
            string leUnicodeStr = "apple";
            
            //Настойки кодировок.
            //Unicode - Получает кодировка для формата UTF-16 с ПРЯМЫМ прядком байтов.
            //В Unicode - каждый сомвол занимает 2 байта
            Encoding leUnicode  = Encoding.Unicode;

            //BigEndianUnicode - Получает кодировку для формата UTF-16 С ОБРАТНЫМ порядком байтов
            Encoding beUnicode = Encoding.BigEndianUnicode;

            //UTF8 - Получает кодировку для формата UTF8
            Encoding utf8 = Encoding.UTF8;

            //Массивы байтов для хранения конвертированной строки. 
            byte[] leUnicodeBytes = leUnicode.GetBytes(leUnicodeStr);                        //В Unicode
            //                                      from        to         сами байты
            byte[] beUnicodeBytes = Encoding.Convert(leUnicode, beUnicode, leUnicodeBytes);  //В EndianUnicode
            //                                  from        to         сами байты
            byte[] utf8Bytes = Encoding.Convert(leUnicode, utf8, leUnicodeBytes);            //В UTF8


            //Выводим содержимое массово на экран.
            Console.WriteLine("Исходная строка: {0}\n", leUnicodeStr);

            Console.WriteLine("Байты Unicode, сначала пладший:");
            var builder = new StringBuilder();
            foreach (var b in leUnicodeBytes)
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine("{0}\n", builder);

            Console.WriteLine("Байты Unicode, сначала старший:");
            builder = new StringBuilder();
            foreach (var b in beUnicodeBytes)
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine("{0}\n", builder);

            Console.WriteLine("Байты UTF:");
            builder = new StringBuilder();
            foreach (var b in utf8Bytes)
            {
                builder.Append(b).Append(":");
            }
            Console.WriteLine(builder.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}

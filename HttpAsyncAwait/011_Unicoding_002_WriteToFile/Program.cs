using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Unicoding_002_WriteToFile
{
    //Запись в файл с явным указанием кодировок.
    class Program
    {
        static void Main(string[] args)
        {
            //Второй параметр конструктора StreamWriter - append Тип: System.Boolean
            //Определяет, требуется ли добавить в файл данные.
            //Если файл существует и значение параметра append равно false, файл ПЕРЕЗАПИСЫВАЕТСЯ
            //Если файл существует и значение параметра append равно true,В ФАЙЛ ДОБАВЛЯЮТСЯ ДАННЫЕ.
            //В противном случае создается новый файл.

            //Записываем файл в кодировке UTF7
            var swUtf7 = new StreamWriter("text.txt", true, Encoding.UTF7);
            swUtf7.WriteLine("Hello, world");
            swUtf7.Close();

            //Записываем файл в кодировке UTF8
            var swUtf8 = new StreamWriter("text.txt", true, Encoding.UTF8);
            swUtf8.WriteLine("Hello, world");
            swUtf8.Close();

            //Записываем файл в кодировке Unicode
            var swUtf16 = new StreamWriter("text.txt", true, Encoding.Unicode); //в Unicode размер 65536 символов
            swUtf16.WriteLine("Hello, world");
            swUtf16.Close();

            //Записываем файл в кодировке UTF32
            var swUtf32 = new StreamWriter("text.txt", true, Encoding.UTF32);
            swUtf32.WriteLine("Hello, world");
            swUtf32.Close();

            //метод строкой ниже перезапишет то, что я писал ранее, по этому и пришлось его закомментировать
            //File.WriteAllText("text.txt", "Hello, world", Encoding.BigEndianUnicode);

            Console.WriteLine(File.ReadAllText("text.txt"));

            //Delay
            Console.ReadKey();
        }
    }
}

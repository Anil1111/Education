using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Строка на самом деле не строка. Все символы хранятся в виде чисел в таблице. Вот например фотография - весит очень много,
            //а текстовый файл - нет. Так в чем же дело? Дело в том, что текст  "здорово" не хранится в виде картинок(символов), он 
            //хранится в виде чисел. ИИ ТАБЛИЦА, КОТОРАЯ ОПИСЫВАЕТ СООТВЕТСТВИЕ СИМВОЛОВ И ЧИСЕЛ НАЗЫВАЕТСЯ КОДИРОВКОЙ.
            string someText = "здорово";  //в С# по умолчанию используется UTF-16(Unicode)

            //Кракозябры - получатся тогда, когда текст написан в одной кодировке, а мы читаем его в другой.

            //Unicode - Получает кодировка для формата UTF-16 с ПРЯМЫМ прядком байтов.
            //В Unicode - каждый сомвол занимает 2 байта
            Encoding unicode = Encoding.Unicode; //UTF16

            //UTF8 - Получает кодировку для формата UTF8
            Encoding utf8 = Encoding.UTF8;

            //Массивы байтов для хранения конвертированной строки.
            string utf8String = utf8.GetString(unicode.GetBytes(someText));  //В UTF8
            //unicode.GetBytes(leUnicodeStr) - метод GetBytes разбирает строку на символы и получает код каждого символа 
            //и эти коды превращаются в наборы байтов - в результате получится массив байтов.
            //utf8.GetString(...) - мы передаем методу наборы байтов и GetString пытается его расшифровать формате utf8
            //Т.Е У НАС ЕСТЬ НАБОР БАЙТОВ В КОДИРОВКЕ Encoding.Unicode, А МЫ ПЫТАЕМСЯ ЕГО РАСШИФРОВАТЬ В КОДИРОВКЕ Encoding.UTF8 - хорошего ничего не получится

            //Выводим содержимое массивов на экран.
            Console.WriteLine("Исходная строка: {0}\n", someText);

            Console.WriteLine("Байты UTF : {0}", utf8String);

            Console.WriteLine("Обратно раскодированное слово: {0}", unicode.GetString(utf8.GetBytes(utf8String))); //проводим обратную процедуру

            //Так же мы можем использовать разные кодировки, чтобы писать или читать данные из файла.
            //ВАЖНО!!! Мы пишем в формате UTF8, значит и текстовый редактор тоже должен быть настроен на UTF8. Иначе будут кракозябры
            StreamWriter writer = new StreamWriter(@"D:\test.txt", false, Encoding.ASCII);
            writer.WriteLine(someText); //записал в Encoding.ASCII, а прочить NotePad не может
            writer.Close();

            //Чем меньше кодировка - тем меньше памяти нужно, чтобы хранить ее. 
            //Маленьких кодировок хватает с головой, ну а если уж сильно нужно - то только тогда переходим на более тяжелые кодировки.

            //Delay
            Console.ReadKey();
        }
    }
}

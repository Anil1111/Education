using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_String
{
    class Program
    {
        //Механизм интернирования строк срабатывает при компиляции.
        //А уже после компиляции - уже ничего не проверяется! Т.е если я возьму одну строковую
        //параменную и присвою ей значение возвращаемое методом , то оно не будет проверяться пуллом интернирования. Это не выгодно с точки зрения производительности.
        //И если эти значения одинаковы - это будут 2 разных объекта в памяти, у которых одинаковое значение.
        //Если мы хотим все таки подключить механизм интернирования во время выполнения программы - вызываем метод Intern.

        static void Main(string[] args)
        {
            //Создаем две строки:
            //Эти строковые переменные ссылаются на одно место в памяти
            string string1 = "c:\\windows\\system";
            string string2 = @"c:\windows\system";

            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("string2 = " + string2);
            Console.WriteLine("Object.ReferenceEquals(string1, string2) {0}",
                Object.ReferenceEquals(string1, string2));

            //----А ТЕПЕРЬ ясоздал файлик и записал в него значение 123 и сейчас,
            //когда значение из файла будет доставаться, механизм интернирования строк не будет работать! Если я хочу, чтобы он сработал
            //нужно воспользоваться методом String.Intern

            var fileInfo = File.OpenRead(@"D:\Test.txt");
            var reader = new StreamReader(fileInfo);
            
            string text1 = reader.ReadToEnd();
            reader.Close();

            string text2 = "123";

            //Демонстрация того, что ссылки действительно совпадат.
            Console.WriteLine("text1 = " + text1);
            Console.WriteLine("text2 = " + text2);
            Console.WriteLine("Object.ReferenceEquals(string1, string2) {0}",
                Object.ReferenceEquals(text1, text2));

            //---------------------

            Console.WriteLine("\nEnter some string");

            //ВАРИАНТ ПЕРВЫЙ
            //string stringNew = Console.ReadLine();
            //ВАРИАНТ ВТОРОЙ
            string stringNew = String.Intern(Console.ReadLine());  //ввел c:\windows\system, а оно побежало в пулл интернирования
            //я спросил "а есть такая строка?", она есть и метод String.Intern вернул ссылку на уже сущевствующую в пулле интернирования строку.

            Console.WriteLine("Object.ReferenceEquals(stringNew, string2) {0}",
                Object.ReferenceEquals(stringNew, string2));
            //при обычном  string stringNew = Console.ReadLine(); - вывело False, потому, что не проверяло есть ли такая строка в пулле интернирования и создало ещё одну такую же
            //а при string stringNew = String.Intern(Console.ReadLine());- вывело True - потому, что проверило есть ли такая строка в пулле интерирования и не стало создавать ещё одну.


            //--------------------------------------------
            //Когда м пользуемся конкатенацией - сборщик мусора выходит на кучу и начинает все чистить. Из-за этого это так долго делается.
            //StringBuilder - собирает внутри себя строку, не порождая экзампляров, оперируя всего одним экземпляром.
            //в +100 000 раз быстрее чем конкатенация
            var builder = new StringBuilder();

            builder.Append("StringBuilder").Append("является").Append("очень ...");

            string build1 = builder.ToString();

            builder.Append("быстрым");

            string build2 = builder.ToString();

            Console.WriteLine(build1);
            Console.WriteLine(build2);

            //Delay
            Console.ReadKey();
        }
    }
}

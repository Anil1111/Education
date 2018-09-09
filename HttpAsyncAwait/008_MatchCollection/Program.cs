using System;
using System.Text.RegularExpressions;

namespace _008_MatchCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            //    .   Определяет любой символ кроме символа новой стоки.в тестах SpecFlow испольуется символ.* т.е любой символ кроме символа новой стоки 0 или более раз
            //    \.  Определяет символ точки
            Regex regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+.[a-zA-Z]{2,4}"); //если точка светится синим, значит это "." символ, 
            //а если перед ней поставить \, то будет \. и оно будет светиться  оранжевым. Главное, что есть знак "@" т.к знак \. будет считаться знаком \.

            MatchCollection matchCollection = regex.Matches("русский edu@cbsystematics.com текст123ещерусскийsupport@cbsystematics.comаппапап");

            foreach (Match match in matchCollection) //match.Groups["link"] - для переменных, но у нас тут нету переменных
            {
                Console.WriteLine("{0,-25} на {1,-3} позиции", match.Value, match.Index);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

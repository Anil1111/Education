using System;
using System.Text.RegularExpressions;

namespace _008_MatchCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сцепление строк (конкатенация)
            //1 вариант
            string word1 = "Привет ";
            string word2 = "Мир!";
            string phrase = word1 + word2; //Знак + когда используется со строками обозначает СЦЕПЛЕНИЕ!

            //2 вариант
            Console.WriteLine("Hello" + "World!");

            //Delay
            Console.ReadLine();
        }
    }
}

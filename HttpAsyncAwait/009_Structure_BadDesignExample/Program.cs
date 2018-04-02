using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры. Пример плохого дизайна.
namespace _009_Structure_BadDesignExample
{
    struct ZipCode
    {
        //Поля
        private int fiveDigitCode;     //ПОЛЯ В СТРУКТУРЕ НЕ МОЖЕМ СРАЗУ ЖЕ ПРОИНИЦИАЛИЗИРОВАТЬ.
        private int plusFourExtension; //ПОЛЯ В СТРУКТУРЕ НЕ МОЖЕМ СРАЗУ ЖЕ ПРОИНИЦИАЛИЗИРОВАТЬ.

        //Свойства
        public int FiveDigitCode
        {
            get => fiveDigitCode;
            set => fiveDigitCode = value;
        }
        public int PlusFourExtension
        {
            get => plusFourExtension;
            set => plusFourExtension = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode(); // если откажемся от конструктора - то будет ошибка. Почему? потому, что 
            //никто не обещает в методах set свойств FiveDigitCode и PlusFourExtension СДЕЛАТЬ ПРИСВОЕНИЕ.
            //А если мы вызываем конструктор - то там будут значения по умолчанию 100%!

            zipCode.FiveDigitCode = 12345;
            zipCode.PlusFourExtension = 1234;
            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);

            //Delay
            Console.ReadKey();
        }
    }
}

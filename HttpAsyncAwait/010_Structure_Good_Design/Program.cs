using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры.
//Пример хорошего дизайна.
namespace _010_Structure_Good_Design
{
    struct ZipCode
    {
        //Поля
        private int fiveDigitCode;
        private int plusFourExtension;

        //Конструкторы
        public ZipCode(int fiveDigitCode, int plusFourExtension)
        {
            this.fiveDigitCode = fiveDigitCode;
            this.plusFourExtension = plusFourExtension;
        }

        public ZipCode(int fiveDigitCode)
            : this(fiveDigitCode, 0)
        {
        }

        //Свойства - только для чтения. Если что-то поменяется - лучше создать новый экземпляр.
        //Пример с ПАСПОРТОМ И ПРОПИСКОЙ. НОВАЯ прописка - НОВЫЙ штамп.
        // ООП для того и создавалось, чтобы проводить паралели из реального мира.
        public int FiveDigitCode => fiveDigitCode;
        public int PlusFourExtension => plusFourExtension;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode(12345, 5555);

            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);
            
            //Delay
            Console.ReadKey();
        }
    }
}

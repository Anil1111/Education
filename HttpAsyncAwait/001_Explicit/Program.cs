using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Explicit
{
    // Перегрузка оператора явного преобразования типа.
    // Ключевое слово explicit служит для создания оператора явного преобразования типа.
    struct Digit
    {
        public byte value;

        public Digit(byte value)
        {
            this.value = value;
        }
        //Оператор явного преобразования типа byte-to-Digit;
        public static explicit operator Digit(byte argument) //  Digit - тип возвращаемого значения
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte variable = 1;
            //Явное преобразование byte-to-Digit
            Digit digit = (Digit) variable;
            Console.WriteLine(digit);

            //Delay
            Console.ReadKey();
        }
    }
}

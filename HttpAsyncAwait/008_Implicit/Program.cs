using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Implicit
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
        //Оператор неявного преобразования типа byte-to-Digit;
        public static implicit operator Digit(byte argument) //  Digit - тип возвращаемого значения
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
            //Неявное преобразование byte-to-Digit (Casting)
            Digit digit = variable; //в скобках ничего нету т.к это оператор НЕявного преобразования.
            Console.WriteLine(digit);

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_CustomFormatter_001
{
    //Если дискриминан меньше нуля, (D < 0), то квадратное управление
    //не имеет действитльных корней, а имеет комплексные корни.

    //Создание форматированного пользоватльского вывода
    //Проблемма - помочь математикам -> американские захотят там видеть точки, а русские - запятые.
    public struct Complex : IFormattable
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        //Реализация IFormatable
        // format - С, F etc,  formatProvider - американский или русский.
        public string ToString(string format, IFormatProvider formatProvider)
        {
            //можем билдить строки(там все записуется на мниный листочек), а потом сказать "дай мне текст"
            //быстрее чем конкатенация - в конце модуля "1.Работа с текстом будет пример".
            var builder = new StringBuilder(); //классная штука!

            if (format == "TEST")
            {
                // Генерация отладочного вывода для данного объекта
                // \t - это 4 проблела
                //Append - добавить
                builder.Append(this.GetType() + "\n");
                builder.AppendFormat(" действительная:\t{0}\n", real);
                builder.AppendFormat(" мнимая:\t\t{0}\n", imaginary);
            }
            else
            {
                //Double уже имеет реализоыванны ToString, так что используем их
                builder.Append(" ( ");
                builder.Append(real.ToString(format, formatProvider));
                builder.Append(" : ");
                builder.Append(imaginary.ToString(format, formatProvider));
                builder.Append(" ) ");
            }

            return builder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCultureInfo = CultureInfo.CurrentCulture;
            var uaCultureInfo = new CultureInfo("uk-UA");

            var complex = new Complex(12.3456, 1234.5678);

            string stringComplex = complex.ToString("F", myCultureInfo); // F - по умолчанию = F2.
            Console.WriteLine(stringComplex); // RU - запятая в числе

            stringComplex = complex.ToString("F2", uaCultureInfo);
            Console.WriteLine(stringComplex); // US - тока в числе

            Console.WriteLine("\nОтладочный вывод:\n{0:TEST}", complex);
            //!!!!ВАЖНО. У нас получилсь сделать {0:TEST}", complex потому, что complex реализует IFormattable
            //а культура передестся по умолчанию, которая установлена на компютере. Можешь подебажить!
            
            //Delay
            Console.ReadKey();
        }
    }
}

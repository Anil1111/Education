using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_CustomFormatter_002
{
    //Создание форматированного польовательского вывода.
    public class ComplexTestFormatter : IFormatProvider, ICustomFormatter
    {
        //Реализация  IFormatProvider. Неявно вызывается методом String.Format(...
        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter) // formatType == typeof(ICustomFormatter) означает : реализует ли formatType  интерфейс ICustomFormatter или нет??
                ? this //мы моли бы не наследовать ComplexTestFormatter от IFormatProvider и тогда нам нужно было бы возвращать не this, а на тот
                       //класс кто реализует интерфейс ICustomFormatter, а значит имеет метод Format
                : CultureInfo.CurrentCulture.GetFormat(formatType);
        }

        //Реализация ICustomFormatter
        //string format - формат F, C etc
        //object arg - наше комплексное число
        //IFormatProvider formatProvider - формат (в прошлых примера было CultureInfo.CurrentCulture)
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is Complex && format == "TEST")
            {
                var complex = (Complex)arg;

                //Сгенерировать отлидочный вывод для данного объекта
                var builder = new StringBuilder();

                builder.Append(this.GetType() + "\n");
                builder.AppendFormat(" действительная:\t{0}\n", complex.Real);
                builder.AppendFormat(" мнимая:\t\t{0}\n", complex.Imaginary);

                return builder.ToString();
            }
            else
            {
                var formattable = arg as IFormattable;

                return formattable != null
                    ? formattable.ToString(format, formatProvider)
                    : formattable.ToString(); //в худшем случае вернет полное квалифицированное имя типа
            }
        }
    }

    public struct Complex : IFormattable
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real => real;
        public double Imaginary => imaginary;

        //Реализация IFormatable
        // format - С, F etc,  formatProvider - американский или русский.
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var builder = new StringBuilder();

            //Double уже имеет реализоыванны ToString, так что используем их
            builder.Append(" ( ");
            builder.Append(real.ToString(format, formatProvider));
            builder.Append(" : ");
            builder.Append(imaginary.ToString(format, formatProvider));
            builder.Append(" ) ");

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

            var testFormatter = new ComplexTestFormatter();
            //testFormatter - задает правила форматирования
            //"{0:TEST}" сам формат
            //complex - само число
            stringComplex = String.Format(testFormatter, "{0:TEST}", complex);
            //Метод String.Format вызывает метод GetFormat - он возвращает экзампляр класса, у которого есть метод Format, и потом уже происходит форматирование.

            Console.WriteLine("\nОтладочный вывод:\n{0}",stringComplex);

            //Delay
            Console.ReadKey();
        }
    }
}

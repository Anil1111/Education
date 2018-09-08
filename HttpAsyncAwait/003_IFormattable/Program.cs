using System;
using System.Globalization;

//Использоване интерфейа IFormattable
namespace _003_IFormattable
{
    //У нас Цельсии, в других странах Кельвины, у нас точка (20.5), а там - запятая (20,5) и т.д
    public class Temperature : IFormattable
    {
        private decimal temperature;

        public Temperature(decimal temperature) //принимает тепмпературу в цельсиях
        {
            if (temperature < -273.15m)
            {
                //По шкале Цельсия абсолютному нулю соответсвует тепраратура -273,25 °C
                //т.е можем заморзить ручку до такой температуры, что дальше она замораживаться не будет - это и есть обсолютный ноль
                throw new ArgumentOutOfRangeException(
                    string.Format($"{temperature} is less than absolute zero"));
            }

            this.temperature = temperature;
        }

        public decimal Celsius
        {
            get { return temperature; }
        }

        public decimal Fahrenheit
        {
            // Перевод Цельсия в Фаренгейт
            get { return temperature * 9 / 5 + 32; }
        }

        public decimal Kelvin
        {
            //Перевод Цельсия в Кельвин
            get { return temperature + 273.15m; }
        }

        //переопределяем из Object`а и он использует public string ToString(string format, IFormatProvider formatProvider)
        //НО ОН ТОЖЕ НЕ НУЖЕН ТУТ. Потому, что автоматитом будет вызываться  public string ToString(string format, IFormatProvider formatProvider)
        //public override string ToString()
        //{
        //    return this.ToString("G", CultureInfo.CurrentCulture); //Культура - это Цельсий или Кельвин, это точка или запятая и т.д
        //}

        //просто, чтобы показать, что мы можем сделать ToString и с одним аргументом.
        //public string ToString(string format)
        //{
        //    return this.ToString(format, CultureInfo.CurrentCulture);
        //}

        //IFormatProvider - поставщик формата
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";
            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    //F2 - формат вывода вещественного числа (2 знака после запятой).
                    return temperature.ToString("F2", formatProvider) + " °C";
                case "F":
                    //temperature, Fahrenheit, Kelvin - это decimal, а decimal  тоже реализует IFormattable и там есть подходящий ToString
                    return Fahrenheit.ToString("F2", formatProvider) + " °F";
                case "K":
                    //F2 - означает, что оставить 2 знака после запятой. Можно посомтреть в табличце форматов на MSDN
                    return Kelvin.ToString("F2", formatProvider) + " K";
                default:
                    throw new FormatException(
                        String.Format($"The {format} string is not supported"));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var temperature = new Temperature(12); //12 °C

            //Это все делалось потому, чтобы при выводе на консоль temperature сработал метод ToString
            //и вывел не полное квалифицированное имя, а всю важную для нас информацию.
            Console.WriteLine($"Temperature [default]       = {temperature}"); //тут неявно вызывается метод ToString(string format, IFormatProvider formatProvider)

            //ОЧЕНЬ ВАЖНО! Из 0:K откусывается 'K' и передается в метод ToString(string format, IFormatProvider formatProvider)
            //попробуй отдебажить
            Console.WriteLine("Temperature [Farenheit]     = {0:K}", temperature); //{0:K} ВОТ такое можно сделать с тем элементом, который наследуется от IFormattable!
            Console.WriteLine("Temperature [CultureInfo]   = {0}", 
                temperature.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Temperature [CultureInfo]   = {0}",
                temperature.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));

            //Delay
            Console.ReadKey();
        }
    }
}

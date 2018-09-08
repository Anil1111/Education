using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_CustomCulture
{
    //Вывод строк с использованием настроек культуры
    class Program
    {
        static void Main(string[] args)
        {
            //Сумма, которую необходимо вывести на экран.
            double money = 122345.45;

            //Три доступные культуры
            var americanCultureInfo = new CultureInfo("en-US");
            var germanyCultureInfo = new CultureInfo("de-DE");
            var russianCultureInfo = new CultureInfo("ru-RU");

            //Фокусируем строки под нужную культуру и сохраняем результат в переменной.
            //помним, что Double наследуется от IFormattable, так что специальный метод ToString есть
            string localMoney = money.ToString("C", americanCultureInfo); // $122345,45
            string result = $"Деньги США {localMoney}"; 

            localMoney = money.ToString("C", germanyCultureInfo); //122345,45€
            result += $"\nДеньги Германии {localMoney}";

            localMoney = money.ToString("C", russianCultureInfo); //122345,45₽
            result += $"\nДеньги России {localMoney}";

            //Выводим содержимое на экран
            Console.WriteLine(result);

            //Delay
            Console.ReadKey();
        }
    }
}

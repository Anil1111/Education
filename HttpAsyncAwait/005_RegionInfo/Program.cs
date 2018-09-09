using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_RegionInfo
{
    //Работа с регионом. Есть понятие культуры, а есть - региона. Культура CultureInfo, регион - RegionInfo


    //Список обознаений культур:
    //http://www1.cs.columbia.edu/~lok/csharp/refdocs/System.Globalization/types/CultureInfo.html
    class Program
    {
        static void Main(string[] args)
        {
            //Получение информации о текущем регионе.
            RegionInfo regionInfo = RegionInfo.CurrentRegion; //RegionInfo не относится к геолокации. Геолокация определяется с помощью IP
            //\t   Перемещает позицию печати к следующей позиции горизонтальной табуляции.
            Console.WriteLine($"EnglishName региона:\t{regionInfo.EnglishName}");
            Console.WriteLine($"NativeName региона:\t{regionInfo.NativeName}");

            Console.WriteLine(new string('-', 35));

            Console.WriteLine($"CurrencySymbol региона:\t{regionInfo.CurrencySymbol}");
            Console.WriteLine($"CurrencyEnglishName региона:\t{regionInfo.CurrencyEnglishName}");
            Console.WriteLine($"CurrencyNativeName региона:\t{regionInfo.CurrencyNativeName}");

            Console.WriteLine(new string('-', 35));

            //Получение информации о текущем формате даты: названия дней

            string[] dayNames = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            Console.WriteLine("Дни недели:");
            foreach (string day in dayNames)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine(new string('-', 35));

            //Получение информации о формате даты в немецком языке: названия дней

            string[] germanDayNames = CultureInfo.GetCultureInfo("de-DE").DateTimeFormat.DayNames;
            // string[] germanDayNames = CultureInfo.GetCultureInfo("kk-KZ").DateTimeFormat.DayNames; - если в названии
            //дней недели есть буквы, которых у нас нету, то они будут заменены знаками вопроса. В такой случае нужно
            //скачать языковый пакет.
            Console.WriteLine("Дни недели на немецком:");
            foreach (string day in germanDayNames)
            {
                Console.WriteLine(day);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Globalization;

namespace _004_CulruteInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получение информации о текущей культуре.
            CultureInfo currentCultureInfo = CultureInfo.CurrentCulture;
            Console.WriteLine($"Текущая локаль: {currentCultureInfo}");

            Console.ReadKey();

            //Информация о всех культурах доступных в системе.
            CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine($"В системе определены {cultureInfo.Length} различные культуры.");

            foreach (CultureInfo cInfo in cultureInfo)
            {
                Console.WriteLine(cInfo.EnglishName + " | " + cInfo.ToString());
            }

            //Все культуры созданные пользователем.
            cultureInfo = CultureInfo.GetCultures(CultureTypes.UserCustomCulture);

            if (cultureInfo.Length < 1)
            {
                Console.WriteLine("Пользователь не создавал собственные локальные культуры");
            }
            else
            {
                Console.WriteLine("Локали, созданые пользователем");

                foreach (CultureInfo cInfo in cultureInfo)
                {
                    Console.WriteLine(cInfo.EnglishName + " | " + cInfo.ToString());
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}

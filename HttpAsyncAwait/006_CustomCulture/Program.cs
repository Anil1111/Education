using System;
using System.Globalization;

namespace _006_CustomCulture
{
    //Содание собственной (пользовательский культуры).
    //Для работы с CultureAndRegionInfoBiulder необходимо подключить библиотеку
    class Program
    {
        static void Main(string[] args)
        {
            var regionInfo = new RegionInfo("Us");
            Console.WriteLine($"Значение свойство US.IsMetric = {regionInfo.IsMetric}");
            Console.WriteLine(new string('-', 25));

            // var builder = new CultureAndRegionInfoBuilder();

            //Это нужно если я куплю денег и выкуплю свой остров. Тогда придумаю свою систему и т.д
            //Так же создание культуры будет полезно при распаде одно страны на несколько
        }
    }
}

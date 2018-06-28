using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    /// <summary>
    /// Теперь в С# 6.0 свойства и методы можно определять через лямбда-выражения.
    /// И это существенно уменьшает коливество кода.
    /// </summary>
    class Program
    {
        //Раньше
        //static string[] GetDaysOfWeek()
        //{
        //    return new string[] {"Monday", "Tuesday", "Wendnesday", "Thursday", "Friday", "Saturday", "Sunday"};
        //}

        //В C# 6.0
        static string[] GetDaysOfWeek() => new string[] { "Monday", "Tuesday", "Wendnesday", "Thursday", "Friday", "Saturday", "Sunday" };

        static void Main(string[] args)
        {
            var daysOfWeek = GetDaysOfWeek();
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

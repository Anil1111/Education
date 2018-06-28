using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Dictionary
{
    /// <summary>
    /// В С# 6.0 добавлена возможность инициализации Dictionary,
    /// по ключу значения. Это упрощает инициализацию словарей. Key указывается в [] скобках
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Раньше:
            var daysOfWeek = new Dictionary<int, string>();
            daysOfWeek.Add(1, "Monday");

            //В С# 6.0
            var days = new Dictionary<int, string>
            {
                [0] = "Monday",
                [1] = "Tuesday",
                [2] = "Wendnesday",
                [3] = "Thursday",
                [4] = "Friday",
                [5] = "Saturday",
                [22] = "Sunday"
            };

            var days2 = new Dictionary<string, string>
            {
                ["Monday"] = "Monday"
            };

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _017_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                { new{Key ="table"},     new {Value="стол"} },
                { new{Key ="apple"},     new {Value="яблоко"} },
                {new{Key ="pen"},       new {Value="ручка"} },
                {new{Key ="pencil"},    new {Value="карандаш"} },
                {new{Key ="task"},      new {Value="задание"} },
                {new{Key ="key"},       new {Value="ключ"} },
                {new{Key ="customer"},  new {Value="покупатель"} },
                {new{Key ="ship"},      new {Value="корабль"} },
                {new{Key ="car"},       new {Value="машина"} },
                {new{Key ="cup"},       new {Value="чашка"} },
            };

            foreach (dynamic item in dictionary)
            {
                WriteLine($"{item.Key.Key} - {item.Value.Value}"); //не забывать, что Intelisense не работает! пришлось рукми дописывать .Key и .Value
            }

            //Delay
            ReadKey();
        }
    }
}

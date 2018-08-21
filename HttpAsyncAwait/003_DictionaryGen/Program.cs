using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DictionaryGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict[3] = "Three";
            dict[4] = "Four";
            dict[1] = "One";
            dict[2] = "Two";
            dict[2] = "Two1"; //заменит слово

            string str = dict[3];
            //Dictionary состоит из массива элементов типа KeyValuePair
            foreach (KeyValuePair<int, string> i in dict)
            {
                Console.WriteLine($"{i.Key} = {i.Value}");
            }

            Console.WriteLine(new string('-', 25));

            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

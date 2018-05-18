using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionary = new Dictionary<int, string>();

            dictionary.Add(0, "Ноль");
            dictionary.Add(1, "Один");
            dictionary.Add(2, "Два");
            dictionary.Add(3, "Три");

            Console.WriteLine(dictionary.ContainsKey(0));
            Console.WriteLine(dictionary.ContainsValue("Ноль"));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

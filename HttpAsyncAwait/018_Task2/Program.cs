using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using _014_Task2;

namespace _018_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            _014_Task2.MyDictionary<char, string> dictionary = new _014_Task2.MyDictionary<char, string>();
            dictionary.Add('1', "One");
            dictionary.Add('2', "Two");
            dictionary.Add('3', "Three");

            Console.WriteLine(dictionary[2]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

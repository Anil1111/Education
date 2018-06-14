using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Яблоко", "Apple");
            myDictionary.Add("Стол", "Table");
            myDictionary.Add("Машина", "Car");

            foreach (var item in myDictionary)
            {
               Console.WriteLine(item); 
            }

            var secondValue = myDictionary[1];
            Console.WriteLine(secondValue);

            var elementsNumber = myDictionary.Length;
            Console.WriteLine(elementsNumber);

            //Delay
            Console.ReadKey();
        }
    }
}

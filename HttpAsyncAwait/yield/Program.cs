using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace yield
{
    class Program
    {
        private static List<int> myList = new List<int>();

        static void Fill()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
        }
        static void Main(string[] args)
        {
            Fill();
            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-".PadRight(50));
            foreach (var element in Method())
            {
                Console.WriteLine(element);
            }

            //Delay
            Console.ReadKey();
        }

        private static IEnumerable Method()
        {
            foreach (var element in myList)
            {
                if (element > 2)
                {
                    yield return element;
                }

                if (element == 5)
                {
                    yield break;
                }
            }
        }
    }
}

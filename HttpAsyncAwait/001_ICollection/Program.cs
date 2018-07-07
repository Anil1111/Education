using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ICollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 5));

            var array = new object[collection.Count];

            collection.CopyTo(array, 0);

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

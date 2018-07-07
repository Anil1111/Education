using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ICollection_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //мы теперь можем использовать БЛОК ИНИЦИАЛИЗАТОРА т.к наша коллекция реализует интерфейс ICollection<T>
            var collection = new UserCollection<int> { 1, 2, 3 }; 

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(collection.Contains(2));

            //Delay
            Console.ReadKey();
        }
    }
}

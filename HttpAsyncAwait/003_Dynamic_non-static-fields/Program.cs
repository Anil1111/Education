using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Dynamic_non_static_fields
{
    class Program
    {
        dynamic field = 1, field2 = "Hello", field3 = true;
        static void Main(string[] args)
        {
            dynamic instance = new Program();

            Console.WriteLine(instance.field); // пришлось дописывать вручную т.к Intellisence не показал

            instance.field = "Hello world";
            Console.WriteLine(instance.field);

            instance.field = DateTime.Now;
            Console.WriteLine(instance.field);

            //Delay
            Console.ReadKey();
        }
    }
}

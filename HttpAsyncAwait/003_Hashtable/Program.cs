using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //trying to create duplicates
            var duplicates = new Hashtable();

            duplicates["First"] = "1st";
            duplicates["First"] = "the first"; //заменит и элемент останется один

            Console.WriteLine(duplicates.Count);

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_SortedDictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedDict = new SortedDictionary<string, int>();
            sortedDict["One"] = 1;
            sortedDict["Two"] = 2;
            sortedDict["Three"] = 3;

            foreach (KeyValuePair<string,int> i in sortedDict)
            {
                Console.WriteLine(i); // Выведет [One , 1] и так далее
            }

            //Delay
            Console.ReadKey();
        }
    }
}

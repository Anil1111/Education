
//попробовать закоментить и раскоментить
#define DEBUG  
#define version7


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Preprocessor_Directives
{
    class Program
    {
        static void Main(string[] args)
        {
#if (DEBUG && !version7)
Console.WriteLine("DEBUG IS defined");
#elif (!DEBUG && version7)
Console.WriteLine("version 7 IS defined");
#elif(DEBUG && version7)
            Console.WriteLine("DEBUG and version 7 are defined");
#else
Console.WriteLine("DEBUG and version7 are not defined");

#endif
            //Delay
            Console.ReadKey();
        }
    }
}


//#define DEBUG

//Так же в свойствах(Properties) сборки можно выбрать Define DEBUG constant и Define TRACE constant

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _002_Preprocessor_Directives
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#endif
            //TODO: посмотреть в Task List
            //HACK: посмотреть в Task List

            Console.WriteLine("Release version");

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Method
{
    class Program
    {
        static string Function()   
        {                                 //Область видимости 1
            string word = "Hello!";  
            return word;
        }
        static void Main(string[] args)
        {                                 //Область видимости 2
            string word = Function();
            Console.WriteLine(word);

            //Delay
            Console.ReadKey();
        }
    }           //В РАЗНЫХ ОБЛАСТЯХ ВИДИМОСТИ МОГУТ БЫТЬ ОДНОИМЕННЫЕ ПЕРЕМЕННЫЕ
}

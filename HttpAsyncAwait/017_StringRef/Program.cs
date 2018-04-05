using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_StringRef
{
    //КОГДА ИСПОЛЬЗУЮ ref со string - меняется
    //class Program
    //{
    //    static void Method(ref string a) 
    //    {
    //        a = "aaaa";
    //    }
    //    static void Main(string[] args)
    //    {
    //        string a = "bbb";
    //        Method(ref a); 

    //        //Delay
    //        Console.ReadLine();
    //    }
    //}
    
    //БЕЗ ref НЕ ПОМЕНЯЛОСЬ!
    class Program
    {
        static void Method( string a)
        {
            a = "aaaa";
        }
        static void Main(string[] args)
        {
            string a = "bbb";
            Method( a);

            //Delay
            Console.ReadLine();
        }
    }
}

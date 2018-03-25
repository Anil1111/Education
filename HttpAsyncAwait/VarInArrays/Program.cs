using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarInArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] intArray = new int[]{1,2,3,4};
            var varArray = new [] {"string"};
           // var varArray2 = new[] { "string",1 }; ошибка - мы не можем указывать более одного типа в блоке инициализатора

            Console.WriteLine(varArray.GetType());

            //Delay
            Console.ReadKey();
        }
    }
}

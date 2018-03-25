using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void ShowArray(string s,params int[] array)     //В метод с ключевым словом params можно передавать как и массивы, так и 
        {                                             //цифры, которые будут "трансформированы" в массив благодаря слову params
            for (int i = 0; i < array.Length; i++)    // параметр с ключевым словом params должен быть последним 
            {
                Console.WriteLine(array[i]);
            }
        }

        //static void ShowArray(params int[] array, string s)     //Ошибка!  параметр с ключевым словом params должен быть последним 
        //{                                             
        //    for (int i = 0; i < array.Length; i++)    
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}

        private static int[] array = new int[] {1, 2, 3, 4, 5};
        static void Main(string[] args)
        {
            ShowArray("Roma",1,2,3,4,5,6,7,8);
            ShowArray("Vasya",array);



            //Delay
            Console.ReadKey();
        }
    }
}

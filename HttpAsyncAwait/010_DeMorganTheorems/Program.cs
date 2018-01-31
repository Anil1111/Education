using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_DeMorganTheorems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Преобразования логических переменных в соответствии с теоремами Де Моргана.

            //Для применения теорем Де Моргана к логическому оператору AND или OR И паре операндов,
            //требуется ИНВЕРТИРОВАТЬ(добавить еще один !) оба оператора, замениь (AND на OR)
            //или (OR на AND) и инвертировать все выражение полностью.

            //Исходное выражение                           Эквивалентное выражение
            //      !A && !B          =        !(!!A ||!! B)     =  !(A || B)
            //      !A && B                           =           !(A || !B)  
            //      A && !B                           =           !(!A || B)  
            //      A && B                            =           !(!A || !B)
            //      !A || !B                          =           !(A && B)  
            //      !A || B                           =           !(A && !B)  
            //      A || !B                           =           !(!A && B) 
            //      A || B                            =           !(!A && !B)  

            bool A = true;
            bool B = false;
            //Условие до применения теоремы Де Моргана
            if (!A || !B) ///
                Console.WriteLine();

            //Условие после применения теоремы Де Моргана
            if (!(A && B))  //Ну красивее же смотрится)
                Console.WriteLine();


        }
    }
}

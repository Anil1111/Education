using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "roma";
            var b = a.ToCharArray(); //разбиваем строку на массив char'ов
            var c = b.Reverse(); //amor
        }
    }
}

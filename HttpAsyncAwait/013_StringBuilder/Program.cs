using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_StringBuilder
{
    //Использование StringBuilder
    class Program
    {
        static void Main(string[] args)
        {
            var  builder = new StringBuilder();

            builder.Append("StrngBuilder ").Append("является ").Append("очень ...");

            string build1 = builder.ToString();
            builder.Append("быстрым");

            string build2 = builder.ToString();

            Console.WriteLine(build1);
            Console.WriteLine(build2);
            
            //Delay
            Console.ReadKey();
        }
    }
}

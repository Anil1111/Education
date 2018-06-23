using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2015, 12, 4));
            Console.WriteLine(date2.ToString());

            Console.WriteLine(MyDate.Sub(date1,date2).ToString());
            Console.WriteLine(MyDate.Add(date1, date2).ToString());

            //Delay
            Console.ReadKey();
        }
    }
}

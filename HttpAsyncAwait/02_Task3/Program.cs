using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(245, "Roman", "Comfy")
            {
                Article = "laptop",
                Quantity = 50
            };
            invoice.Calculate(needNDS:true);
            invoice.Calculate(needNDS:false);

            //Delay
            Console.ReadKey();
        }
    }
}

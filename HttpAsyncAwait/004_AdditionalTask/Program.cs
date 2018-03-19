using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            var file = redactor.ChooseDocument();

            file.Create();
            file.Open();
            file.Change();
            file.Save();

            //Delay
            Console.ReadKey();

        }
    }
}

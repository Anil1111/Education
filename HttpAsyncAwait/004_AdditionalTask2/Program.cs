using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_AdditionalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentClass document = new DocumentClass("Контракт");
            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И";

            document.Show();

            //Delay
            Console.ReadKey();
        }
    }
}

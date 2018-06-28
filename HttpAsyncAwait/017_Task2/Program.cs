using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _017_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listAuto = new List<Auto>
            {
                new Auto("Fiat","Bravo", 2005, "red"),
                new Auto("Mersedes","E", 2010, "black"),
                new Auto("Skoda","Fabia", 2009, "yellow"),
                new Auto("Mersedes","A", 2009, "grey"),
            };

            listAuto.ForEach(x => WriteLine(x.ToString()));

            WriteLine(new string('-', 50));

            var listOfCustomers = new List<Customercs>
            {
                new Customercs("Petrov", "Mersedes", "0509864578"),
                new Customercs("Ivanov", "Fiat", "050986545"),
                new Customercs("Vasiliev", "Skoda", "0504789863"),
            };

            listOfCustomers.ForEach(x => WriteLine(x.ToString()));

            WriteLine(new string('-', 50));

            var query = from auto in listAuto
                        select new { Marka = auto.Marka, Color = auto.Color };

            foreach (var item in query)
            {
                WriteLine($"Марка авто: {item.Marka} - {item.Color}");
            }

            WriteLine(new string('-', 50));

            var query1 = from customer in listOfCustomers
                         join auto in listAuto on customer.Model equals auto.Marka
                         select new
                         {
                             Name = customer.Name,
                             Tel = customer.Tel,
                             Model = customer.Model,
                             Color = auto.Color,
                             Marka = auto.Model,
                             Year = auto.Year
                         };
            WriteLine(new string('-', 50));

            foreach (var item in query1)
            {
                WriteLine($"{item.Name}, {item.Tel}, {item.Model}, {item.Color}, {item.Marka}, {item.Year}");
            }

            //Delay
            ReadKey();
        }
    }
}

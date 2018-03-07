using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _02_Task3
{
    public class Invoice
    {
        public readonly int Account = 0;
        public readonly string customer = null;
        public readonly string provider = null;

        public Invoice(int Account, string customer, string provider)
        {
            this.Account = Account;
            this.customer = customer;
            this.provider = provider;
        }
        public  string Article { get; set; }
        public  int Quantity { get; set; }

        public void Calculate(bool needNDS)
        {
            double cost;
            switch (Article)
            {
                case "laptop": cost = 5500;
                    break;
                case "SD-card": cost = 50;
                    break;
                case "USB-hab": cost=18;
                    break;
                default:Console.WriteLine("There is no info about article");
                    return;
            }

            if (needNDS)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine($"Сумма оплаты{cost*Quantity}");
        }
    }
}

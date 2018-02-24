using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Goods
    {
        private string name;
        private int price = 55;

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value)) //(!string.IsNullOrEmpty(value)) классная штука, нужно запомнить!
                    name = value;
                else
                {
                    name = "No name";
                    Console.WriteLine("Не указано название товара");
                }
            }
            get { return name; }
        }

        public int Price
        {
            set
            {
                if (value > 0)
                    price = value;
                else
                {
                    price = 0;
                    Console.WriteLine("Не верно указана цена");
                }
            }
            get => price;
        }

        public void ShowNameAndPriceOfGood()
        {
            Console.WriteLine($"Имя товара: {Name}  Цена товара: {Price}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Task2
{
    public class Article
    {
        public Article(string productName, string shop, int price)
        {
            this.ProductName = productName;
            this.Shop = shop;
            this.Price = price;
        }
        private string productName;
        private string shop;
        private int cost;

        public string ProductName
        {
            get
            {
                if (productName != null)
                    return productName;
                else
                    Console.WriteLine($"Элемент {productName} не имеет значения");
                return "nothing";
            }
            set
            {
                if (value != null)
                    productName = value;
                else
                    Console.WriteLine($"Значение null не может быть присвоено полю {productName}");
            }
        }

        public string Shop
        {
            get
            {
                if (shop != null)
                    return shop;
                else
                    Console.WriteLine($"Элемент {shop} не имеет значения");
                return "nothing";
            }
            set
            {
                if (value != null)
                    shop = value;
                else
                    Console.WriteLine($"Значение null не может быть присвоено полю {shop}");
            }
        }
        public int Price
        {
            get
            {
                if (cost > 0)
                    return cost;
                else
                    Console.WriteLine($"Элемент {cost} не имеет значения");
                return 0;
            }
            set
            {
                if (value > 0)
                    cost = value;
                else
                    Console.WriteLine($"Значение 0 не может быть присвоено полю {cost}");
            }
        }

        public string Info()
        {
            return $"{ProductName} из {Shop} стоимость: {Price} грн.";
        }
    }
}

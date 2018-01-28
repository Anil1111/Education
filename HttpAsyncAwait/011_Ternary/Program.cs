using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //int quantity = 10;
            //int price = 100;
            float discount = 0.75f;
            float cost;

            Console.WriteLine("Введите стоимость 1 еденицы товара");
            float price = Convert.ToUInt32(Console.ReadLine());
            while (price <= 0)
            {
                Console.WriteLine("Вы ввели неверную цену");
                Console.WriteLine("Введите стоимость 1 еденицы товара снова");
                price = Convert.ToUInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите количество едениц товара");
            float quantity = Convert.ToUInt32(Console.ReadLine());
            while (quantity <= 0)
            {
                Console.WriteLine("Вы ввели количество едениц товара");
                Console.WriteLine("Введите количество едениц товара снова");
                quantity = Convert.ToUInt32(Console.ReadLine());
            }

            cost = quantity >= 10 ? (price * quantity * discount) : (price * quantity);
            Console.WriteLine($"Стоимость Вашей покупки составляет {cost} y.e");

            //Delay
            Console.ReadLine();
        }
    }
}

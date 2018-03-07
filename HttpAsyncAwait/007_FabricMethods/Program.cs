using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_FabricMethods
{//Использование техники фабричных методов
    class Product
    {
        public Product()
        {
            Console.WriteLine("Создан экземпляр класса Product");
        }
    }

    class Factory
    {
        public Product FactoryMethod()
        {
            return  new Product();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();

            //Delay
            Console.ReadKey();
        }
    }
}

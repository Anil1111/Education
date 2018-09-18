using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _031_CustomerSerializer
{
    [Serializable] //опять вылезла ошибка из-за того, что я забыл декорировать этот класс атрибутом  [Serializable]
    class ShoppingCartItem : ISerializable
    {
        public int productId;
        public decimal price;
        public int quantity;

        [NonSerialized]
        public decimal total;

        //Конструктор для начального создания экземпляра
        public ShoppingCartItem(int productId, decimal price, int quantity)
        {
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.total = quantity * price;
        }

        //Специальный конструктор для десериализации
        protected ShoppingCartItem(SerializationInfo propertyBag, StreamingContext context) //сюда парадется уде набитый мешок
        {
            this.productId = propertyBag.GetInt32("Product Id");
            this.price = propertyBag.GetDecimal("Price");
            this.quantity = propertyBag.GetInt32("Quantity");
            this.total = this.price * this.quantity;
        }

        //Метод, вызываемый во время сериализации
        public virtual void GetObjectData(SerializationInfo propertyBag, StreamingContext context)
        {
            propertyBag.AddValue("Product Id", productId);
            propertyBag.AddValue("Price", price);
            propertyBag.AddValue("Quantity", quantity);
        }

        public override string ToString()
        {
            return "id: " + productId + ": " + price + " x " + quantity + " = " + total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream;
            BinaryFormatter formatter = new BinaryFormatter();
            ShoppingCartItem item = new ShoppingCartItem(22, 50000, 2);

            //Серилизация
            using (stream = new FileStream("SerializedItem.txt", FileMode.Create))
            {
                formatter.Serialize(stream, item);
            }

            //Десериализация
            using (stream = new FileStream("SerializedItem.txt", FileMode.Open))
            {
                //object objectItem =  formatter.Deserialize(stream); //так тоже можно
                item = (ShoppingCartItem) formatter.Deserialize(stream);
            }

            Console.WriteLine(item);

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _001_CustomSerialization
{
    [Serializable]
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
        protected ShoppingCartItem(SerializationInfo propertyBag, StreamingContext context)
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
            ShoppingCartItem instance = new ShoppingCartItem(22, 50000, 2);

            //Сериализация - сериализуется не ShoppingCartItem, а коллекция(мешочек), которую мы напилнили в методе GetObjectData
            stream = new FileStream("SerializedItem.txt", FileMode.Create);
            formatter.Serialize(stream,instance);
            stream.Close();

            //Десериализация - а здесь десериализуется тот мешочек, что был сериализован
            stream = new FileStream("SerializedItem.txt", FileMode.Open);
            instance = (ShoppingCartItem) formatter.Deserialize(stream);
            stream.Close();

            //Отображение значений полей.
            Console.WriteLine(instance);

            //Delay
            Console.ReadKey();
        }
    }
}

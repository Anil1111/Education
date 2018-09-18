using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _033_OnSerializing_OnSerialized
{
   [Serializable] 
    class ShoppingCartItem
    {
        public int productId;
        public decimal price;
        public int quantity;
        public decimal total;

        //Конструктор для начального создания экземпляра
        public ShoppingCartItem(int productId, decimal price, int quantity)
        {
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.total = quantity * price;
        }

        //НУЖНО чтобы методы принимали StreamingContext context и возвращали void иначе все всрется "Application is in Break Point..."
        [OnSerializing] //ДО ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CalculateTotal(StreamingContext context) 
        {
            Console.WriteLine("OnSerializing");
        }

        [OnSerialized]  //ПОСЛЕ ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CalculateTotal2(StreamingContext context)
        {
            Console.WriteLine("OnSerialized");
        }

        [OnDeserializing] //ДО ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CheckTotal(StreamingContext context)
        {
            Console.WriteLine("OnDeserializing");
        }

        [OnDeserialized] //ПОСЛЕ ВЫПОЛНЕНИЯ ДЕСЕРИАЛИЗАЦИИ
        void CheckTotal2(StreamingContext context)
        {
            Console.WriteLine("OnDeserialized");
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

            //Сериализация - т.е метод Serialize проверяет, есть ли методы, которые декорированы атрибутами OnSerializing или OnSerialized
            stream = new FileStream("SerializedItem.txt", FileMode.Create);
            formatter.Serialize(stream,instance);
            stream.Close();

            //Десериализация - т.е метод Deserialize проверяет, есть ли методы, которые декорированы атрибутами OnDeserializing или OnDeserialized
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

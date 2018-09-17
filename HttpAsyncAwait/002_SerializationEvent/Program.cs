using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

//Атрибуты демаркации - OnSerializing, OnSerialized и OnDeSerializing, Deserialized.
namespace _002_SerializationEvent
{
    [Serializable] //Выскочил Exception когда я забыл пометить класс, который сериализую/десериализую.
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

        //Используйте OnSerializingAttribute, чтобы выполнять действия с объектом ДО ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        //Чтобы использовать OnSerializingAttribute, метод должен содержать параметр StreamingContext.
        //Метод, декорированный атрибутом OnSerializing вызывается методом Serialize
        [OnSerializing]
        void CalculateTotal(StreamingContext context) 
        {
            Console.WriteLine("OnSerializing");
        }

        [OnSerialized]  //ПОСЛЕ ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CalculateTotal2(StreamingContext context)
        {
            Console.WriteLine("OnSerialized");
        }

        //Используйте OnDeserializing Attribute, чтобы задать значения по умолчанию непосредственно ПЕРЕД ДЕСЕРИАЛИЗАЦИЕЙ
        //Например, если десериализируемый тип не содержит конструктор, создайте метод,
        //чтобы задать значения любых полей в экземпляре и применить атрибут к методу.
        //Чтобы использовать OnDeserializingAttribute метод должен содержать параметр StreamingContext
        [OnDeserializing]
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

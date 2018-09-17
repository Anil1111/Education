using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _001_NonSerialized
{
    [Serializable]
    class ShoppongCartItem : IDeserializationCallback
    {
        public int productId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total; //total = price * quantity и мы не хотим это сериализовать/десериализовать. Пусть лучше в конце десериализации total посчитуется!

        public ShoppongCartItem(int productId, decimal price, int quantity)
        {
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            //this.total = total;
        }

        //метод, который будет вызываться методом Deserialize после его в конце
        void IDeserializationCallback.OnDeserialization(object sender)
        {
            //После десериализации мы посчитываем общую стоимость!
            this.total = price * quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var item = new ShoppongCartItem(323235453, 50000, 5);
            var formatter = new BinaryFormatter();
            #region Сериализация

            using (var fileStream = new FileStream("SerializedShopItem.txt", FileMode.Create))
            {
                formatter.Serialize(fileStream, item);
            }

            #endregion

            #region Десериализация

            using (FileStream fileStream = new FileStream("SerializedShopItem.txt", FileMode.Open))
            {
                item = (ShoppongCartItem)formatter.Deserialize(fileStream); //в конце выполнения метода Deserialize происходит проверка в стиле if(item is IDeserializationCallback)
                                                                                                                                                      //{ OnDeserialization(); }
            }
            //Отображаем десериализированную строку.
            Console.WriteLine($"Total  : {item.total}"); 

            #endregion

            //Delay
            Console.ReadKey();
        }
    }
}

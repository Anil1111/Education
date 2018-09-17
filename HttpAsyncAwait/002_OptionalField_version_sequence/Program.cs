using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _002_OptionalField_version_sequence
{
    //Представим ситуацию: я сделал программу и распространил ее много куда. Тети бугалтера что-то вычислили, надали кнопку "Сохранить" -> сериализовали объект и пошли спать.
    //Админы ночью утсановили новую версию моей программы тетям на компьютер. А в новой версии я добавил новое поле. Тётя проходит утром, запускает приложение, а у нее
    //летят Exception`ы.
    [Serializable]
    class ShoppongCartItem : IDeserializationCallback
    {
        public int productId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;

        //Поле добавленного в класс в новой версии. При десериализации это [OptionalField] будет проинициализировано значением по умолчанию.
        //Т.е десерилизация будет происходит по не 3м, а по 4м полям, но taxable будет инициализировано значением по умолчанию.
        //Тётя даже ничего не заметит, что подлые админы ей ночью подменили версию. Это новое поле будет, но там будет значение по умолчанию
        //и тётя увидит это и сможет уже пользоваться этим полем.
        //[OptionalField]
        public bool taxable;

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
        //Нужно скипировать файл SerializedShopItem.txt" из предидущего примера
        static void Main(string[] args)
        {
            var formatter = new BinaryFormatter();
            var item = new ShoppongCartItem(323235453, 50000, 5);

            //Когда будешь сериализовать - закомменти [OptionalField] и public bool taxable;
            //using (var fileStream = new FileStream("SerializedShopItem.txt", FileMode.Create))
            //{
            //    formatter.Serialize(fileStream, item);
            //    Console.WriteLine("Сериализация окончена");
            //}

            using (FileStream fileStream = new FileStream("SerializedShopItem.txt", FileMode.Open))
            {
                item = (ShoppongCartItem)formatter.Deserialize(fileStream);

                //Отоюражаем десериализованную строку:
                Console.WriteLine("Taxable  : {0}", item.taxable); //Вывело false - значение по умолчанию.
            }

            //Не получается сделать так, чтобы оно всралось. Все равно даже после сериализации без поля
            //taxable при десериализации с этим полем БЕЗ атрибута [OptionalField] - этиму полю присваивается значение по умолчанию.

            //Delay
            Console.ReadKey();
        }
    }
}

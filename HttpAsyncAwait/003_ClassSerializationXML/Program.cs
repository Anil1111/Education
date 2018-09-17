﻿using System.IO;
using System.Xml.Serialization;

/*
 Чтобы создать класс, который можно сериализировать в формат XML, нужно выполнить следующее:
 - объявить класс, как открытый (public)
 - объявить все члены, которые нужно сериализовать, как открытые (public)
 - создать конструктор по умолчанию (без параметров)
 */
namespace _003_ClassSerializationXML
{
    public class ShoppingCartItem
    {
        public int productId;
        public decimal price;
        public int quantity;
        public decimal total;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var instance = new ShoppingCartItem { productId = 22, price = 50000, quantity = 2 };
            instance.total = instance.quantity * instance.price;

            //Создаем файл для сохранения данных.
            FileStream fileStream = new FileStream("SerializedClass.xml", FileMode.Create);

            //Создаем объект XmlSerializer для выполнения сериализации
            XmlSerializer serializer = new XmlSerializer(typeof(ShoppingCartItem));

            //Используем объект XmlSerializer для сериализации данных в файл.
            serializer.Serialize(fileStream, instance);

            fileStream.Close();
        }
    }
}

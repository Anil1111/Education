using System;
using System.Xml;

namespace _005_XML_attribute_reading
{
    class Program
    {
        //Чтение аттрибутов
        static void Main(string[] args)
        {
            var xmlTextReader = new XmlTextReader("books.xml");

            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType == XmlNodeType.Element)
                {
                    //Проверка на тип узла необходима, иначе будут найдены НЕ только открывающие элементы,
                    //но и закрывающие (т.е есть еще XmlNodeType.EndElement и т.д)

                    if (xmlTextReader.Name.Equals("Title")) //Закомментировать и выполнить
                    {
                        Console.WriteLine($"{xmlTextReader.GetAttribute("FontSize")}");
                    }
                }
            }

            //Delay
            Console.ReadKey();

        }
    }
}

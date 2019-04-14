 using System;
using System.Threading;
using System.Xml;

namespace _006_XML_attributes_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlTextReader = new XmlTextReader("books.xml");

            // выведет атрибуты со всех уровней(я добавил свой атрибут в XML на уровне выше, чем другие и он вывелся!)
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlTextReader.HasAttributes)
                    {
                        while (xmlTextReader.MoveToNextAttribute())
                        {
                            Console.WriteLine($"{xmlTextReader.Name} = {xmlTextReader.Value}");
                        }
                    }
                }
            }

            //Delay
            Thread.Sleep(3000);
        }
    }
}

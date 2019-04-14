using System;
using System.IO;
using System.Xml;

namespace _003_XMLString
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlDate = "<?xml version='1.0' encoding='utf-8' ?><Book><Title>CLR via C#</Title></Book>";

            var stringReader = new StringReader(xmlDate);
            var xmlReader = new XmlTextReader(stringReader); //тут используется паттерн Декоратор

            while (xmlReader.Read())
            {
                //Слово Element - это открывающщие скобки в XML (<tagName>), а EndElement - закрывающие скобки(</tagName>) в  документе.
                Console.WriteLine("{0, -15} {1, -15} {2, -15}",
                xmlReader.NodeType, //запусти программу и посмотри что такое NodeType, Name, Value
                xmlReader.Name,
                xmlReader.Value);
            }

            stringReader.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

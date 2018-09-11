using System;
using System.IO;
using System.Xml;

namespace _002_XMLTextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Загрузка содержимого из XML файла

            Console.SetWindowSize(80, 45);

            FileStream stream = new FileStream("books.xml", FileMode.Open);

            //Читатель текста в формате XML
            XmlTextReader xmlReader = new XmlTextReader(stream); //конструктор принимает FileStream

            while (xmlReader.Read())
            {
                //Слово Element - это открывающщие скобки в XML (<tagName>), а EndElement - закрывающие скобки(</tagName>) в  документе.
                Console.WriteLine("{0, -15} {1, -15} {2, -15}",
                xmlReader.NodeType, //запусти программу и посмотри что такое NodeType, Name, Value
                xmlReader.Name,
                xmlReader.Value);
            }

            xmlReader.Close();
            stream.Close();

            //Delay
            Console.ReadKey();
        }
    }
}

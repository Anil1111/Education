using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;

namespace _007_XML_writting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создавать файл не нужно, оно делает все САМО

            //Щас будем сами создавать XML документ. Писаться текст будет без форматирования - просто в одну строку
            var xmlWriter = new XmlTextWriter("books.xml", Encoding.UTF32);
            

            xmlWriter.WriteStartDocument();                    //заголовок XML - <?xml version="1.0"?>

            xmlWriter.WriteStartElement("ListOfBooks");        //Корневой элемент - <ListOfBooks>

            xmlWriter.WriteStartElement("Book");               //Книга 1 - <Book
            xmlWriter.WriteStartAttribute("FontSize");         //Атрибут - FontSize
            xmlWriter.WriteString("8");                        // = "8"
            xmlWriter.WriteEndAttribute();                     //>

            xmlWriter.WriteStartAttribute("Price");            //Атрибут - Price
            xmlWriter.WriteString("100500");                   // = "100500"
            xmlWriter.WriteEndAttribute();                     //>

            xmlWriter.WriteString("Title-1");                  //Title-1
            xmlWriter.WriteEndElement();                       //</Book>

            xmlWriter.WriteEndElement();                       //</ListOfBooks>

            xmlWriter.Close();

            //Delay
            Thread.Sleep(3000);
        }
    }
}

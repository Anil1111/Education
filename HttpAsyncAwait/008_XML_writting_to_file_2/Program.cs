using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace _008_XML_writting_to_file_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Щас будем сами создавать XML документ. Писаться текст будет без форматирования - просто в одну строку
            
            //Создаем все то же самое, что и в предидущем примере, НО БЕЗ АТТРИБУТОВ У ЭЛЕМЕНТОВ
            var xmlWriter = new XmlTextWriter("books.xml", null); //не указываем Encoding

            xmlWriter.WriteStartDocument();                    // <?xml version="1.0"?>

            xmlWriter.WriteStartElement("ListOfBooks");        //<ListOfBooks>

            xmlWriter.WriteStartElement("Book");               //   <Book>
            xmlWriter.WriteString("Title-1");                  //          "Title-1"
            xmlWriter.WriteEndElement();                       //   </Book>

            xmlWriter.WriteStartElement("Book");               //   <Book>
            xmlWriter.WriteString("Title-2");                  //          "Title-2"
            xmlWriter.WriteEndElement();                       //   </Book>

            xmlWriter.WriteEndElement();                       //</ListOfBooks>

            xmlWriter.Close();

            //Delay
            Thread.Sleep(3000);
        }
    }
}

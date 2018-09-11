using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace _009_XML_writting_comment
{
    class Program
    {
        //Запись комментариев в XML файл
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", Encoding.GetEncoding(1251));

            xmlWriter.WriteStartDocument();                // <?xml version="1.0">
            xmlWriter.WriteStartElement("ListOfBooks");    //<ListOfBooks>
            xmlWriter.WriteComment("someComment");         //
            xmlWriter.WriteEndElement();                   //</ListOfBooks>

            xmlWriter.Close();

            //Delay
            Thread.Sleep(3000);
        }
    }
}

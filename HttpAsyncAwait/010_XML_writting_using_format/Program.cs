using System.Threading;
using System.Xml;

namespace _010_XML_writting_using_format
{
    //Запись в XML файл со специальным форматированием
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null); //На этот раз без кодировки

            //Включить форматирование документа (с отступом)
            xmlWriter.Formatting = Formatting.Indented;

            //Для выделелния уровня документа использовать табуляцию, указываем СИМВОЛ!
            //xmlWriter.IndentChar = '\t';

            //Использовать 1 символ табуляции для отступа
            //xmlWriter.Indentation = 1; //т.е мы будем использовать 1 символ xmlWriter.IndentChar . Попробуй поставить 5 символов

            //Аналогично можно указать выравнивание с помощью четырех пробелов:
            xmlWriter.IndentChar = '*';
            xmlWriter.Indentation = 4;

            //По умолчанию строки в XML файл записываются с помощью двуйных кавычек.
            //Использование одиночных кавычек производится так:
            xmlWriter.QuoteChar = '\''; //т.е просто указали кавычку

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("ListOfBooks");
            //namespace нужны для того, чтобы можно было использовать одноименные классы
            xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test"); //"http://localhost/test" это namespace, в XML файле оно будет отображаться как xmlns
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            xmlWriter.Close();

            //Delay
            Thread.Sleep(3000);

        }
    }
}

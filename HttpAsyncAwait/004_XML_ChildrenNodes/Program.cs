using System;
using System.Xml;

namespace _004_XML_ChildrenNodes
{
    //Обход всех элементов XML файла
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load("books.xml");

            XmlNode rootElement = document.DocumentElement; //ListOfBooks - это Root

            //Напечатает "document.DocumentElement=ListOfBooks"
            Console.WriteLine($"document.DocumentElement {rootElement?.LocalName}\n");

            foreach (XmlNode books in rootElement.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }

                Console.WriteLine(new string('-', 50));
            }

            //В общем вся суть в ДЕРЕВЕ! Любая файловая система - это дерево, вот так и у нас. XML- это тоже дерево.
            //Посмотри паттерн Композит.

            //Delay
            Console.ReadKey();
        }
    }
}

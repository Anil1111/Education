using System;
using System.IO;
using System.Xml;

namespace _024_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("books.xml", FileMode.Open);

            //XmlTextReader - оптимальное решение ДЛЯ ЧТЕНИЯ БОЛЬШИХ ДОКУМЕНТОВ
            //XmlTextReader - не считывает файл целиком - он увидел элемент - потом считал его и так постоянно
            XmlTextReader xmlReader = new XmlTextReader(stream); //конструктор принимает FileStream
            //XmlTextReader - не лучший помошник, если я хочу иерархию посмотреть

            while (xmlReader.Read())
            {
                //Слово Element - это открывающщие скобки в XML (<tagName>), а EndElement - закрывающие скобки(</tagName>) в  документе.
                Console.WriteLine("{0, -15} {1, -15} {2, -15}",
                xmlReader.NodeType, //тип элемента (это ENUM, посмотри какие они вообще бывают)
                xmlReader.Name,     //имя элемента
                xmlReader.Value);   //значение элемента
            }

            //xmlReader.Close(); - заккоментил потому, что я все равно закрываю stream, а он закроет и xmlReader
            stream.Close();

            //Delay
            Console.ReadKey();

            //--------------------------------------------------------------------------------------------
            //А XmlDocument умеет ОТСЛЕЖИВАТЬ ИЕРАРХИЧЕСКИЕ СВЯЗИ В XML
            var document = new XmlDocument();
            document.Load("books.xml"); //вот тут документ считывается ЦЕЛИКОМ и большие документы лучше не грузить туда (лучше использовать XPath)

            //XmlNode - это узел дерева
            XmlNode rootElement = document.DocumentElement;

            //Напечатает "document.DocumentElement=ListOfBooks"
            Console.WriteLine($"document.DocumentElement = {rootElement}");

            foreach (XmlNode books in rootElement.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }

                Console.WriteLine(new string('-', 40));
            }

            //Delay
            Console.ReadKey();
        }
    }
}

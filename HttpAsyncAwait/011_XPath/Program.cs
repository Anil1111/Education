using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _011_XPath
{
    /*
     System.Xml.XPath - пространство имен, позволяющее использовать возможности языка XPath (XML Path Language).
     Содержит класс XPathDocument, позволяющий создавать экземпляры XPathNavigator.
     XPathNavigator - представляет курсор-ориентируемую модель для просмотра и редактирования XML данных

     XPath - это язык запросов в XML документу
     */
    class Program
    {
        //Выборка из XML с помощью XPath (Запросы XPath)
        static void Main(string[] args)
        {
            //Создание XPath документа.
            var document = new XPathDocument("books.xml"); //а у класса XPathDocument куча конструкторов и 1 метод - CreateNavigator()!
            //Для того, чтобы делать запросы - создаем навигатор
            XPathNavigator navigator = document.CreateNavigator();

            //Прямой зарос Xpath
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");

            foreach (var item in iterator1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            //Скоспилированный запрос XPath
            //Все, что скомпилировано - работает быстрее! Это лучше, чем просто пихать строку в метод Select(), как я сделал выше

            XPathExpression expression = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(expression);

            foreach (var item in iterator2)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

using System;
using System.Threading;
using System.Xml;
using System.Xml.XPath;

namespace _012_XPath_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание XPath документа
            var document = new XPathDocument("books.xml");

            //Единственное назначение XPathDocument - создание навигатора.
            XPathNavigator xPathNavigator= document.CreateNavigator();

            //При создании навигатора при помощи XPathDocument ВОЗМОЖНО ВЫПОЛНЯТЬ ТОЛЬКО ЧТЕНИЕ.
            Console.WriteLine($"Навигатор создан только для чтения. Свойство CanEdit = {xPathNavigator.CanEdit}");

            // Используя XmlDocument навигатор можно использовать и для редактирования.
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("books.xml");

            xPathNavigator = xmlDoc.CreateNavigator();
            Console.WriteLine($"Навигатор получил возможность редактирования. Свойство CanEdit = {xPathNavigator.CanEdit}");

            //Теперь можно попробовать что-то записать в XML документ.
            //Выполняем навигацию к узлу Book.
            xPathNavigator.MoveToChild("ListOfBooks", "");
            xPathNavigator.MoveToChild("Book", "");

            //Проводим вставку значений
            xPathNavigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
            xPathNavigator.AppendChild("<AppendChild>append_child</AppendChild>");
            xPathNavigator.InsertAfter("<InsertAfter>insert_before</InsertAfter>");

            xPathNavigator.MoveToNext("Book", "");
            xPathNavigator.InsertBefore("<InsertBefore>11111111111111</InsertBefore>");
            xPathNavigator.AppendChild("<AppendChild>2222222222222</AppendChild>");
            xPathNavigator.InsertAfter("<InsertAfter>3333333333333</InsertAfter>");

            //Сохраняем изменения:
            xmlDoc.Save("books.xml");


            //Delay
            Thread.Sleep(3000);
        }
    }
}

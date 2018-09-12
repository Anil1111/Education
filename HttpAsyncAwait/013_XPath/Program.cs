using System;
using System.Xml.XPath;

namespace _013_XPath
{
    class Program
    {
        //Вычисление выражений с помощью XPath
        static void Main(string[] args)
        {
            double sum = 0;

            //Создание XPath документа:
            XPathDocument xPathDocument = new XPathDocument("books.xml");
            XPathNavigator xPathNavigator = xPathDocument.CreateNavigator();

            //Вычисляющий запрос с дополнительной компиляцией.
            XPathExpression xPathExpression = xPathNavigator.Compile("sum(ListOfBooks/Book/Price/text())");

            Console.WriteLine(xPathExpression.ReturnType);

            if (xPathExpression.ReturnType == XPathResultType.Number)
            {
                sum = (double)xPathNavigator.Evaluate(xPathExpression);
                Console.WriteLine(sum);
            }

            //Вычисляющий запрос без предварительной компиляции.
            //Кроме выборки производится арифметическое вычисление.
            sum = (double) xPathNavigator.Evaluate("sum(//Price/text())*10");
            Console.WriteLine(sum);

            XPathNodeIterator elements = (XPathNodeIterator)xPathNavigator.Evaluate("//Title[@FontSize='10']");
            var enumaretor = elements.GetEnumerator();

            while (enumaretor.MoveNext())
            {
                Console.WriteLine((enumaretor.Current as XPathNavigator).Value);
            }

            //Delay
            Console.ReadKey();

        }
    }
}

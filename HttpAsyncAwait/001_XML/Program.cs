using System;
using System.Xml;

namespace _001_XML
{
    //System.Xml 
    //Пространство имен, в котором содержаться классы, необходимые для работы в XML файлами.
    /*
     * <ListOfBooks>   //корневой узел (рутовая нода)
         <Book>        //ветка
           <Title FontSize ="8">Title-1</Title> //Title-1 - листик
           <Price>50</Price>
         </Book>
         <Book>        //ветка
           <Title FontSize="10">Title-2</Title> //Title-2 - листик
           <Price>150</Price>
         </Book>
       </ListOfBooks>
     */
    class Programё
    {
        //Загрузка содержимоего XML из файла

        //Примечание: В окне свойств для файла book.xml,
        //свойство - Copy to Output Directory, присвойте значение - Copy always.
        //Это необходимо, чтобы файл books.xml копировался в папку рядом с *.exe файлом.
        static void Main(string[] args)
        {
            //Загрузка XML из файла:
            var document = new XmlDocument(); //объектно - ориентированное представление XML документа
            document.Load("books.xml");

            //Показ содержимого XML
            Console.WriteLine(document.InnerText); //выводится текст "Title-150Title-2150"

            Console.WriteLine(new string('-', 30));

            //Пока кода XML документа
            Console.WriteLine(document.InnerXml); //выводится  строка без форматирования document.InnerXml="<?xml version=\"1.0\" encoding=\"utf-8\"?><ListOfBooks><Book><Title FontSize=\"8\">Title-1</Title><..."

            //Delay
            Console.ReadKey();
        }
    }
}

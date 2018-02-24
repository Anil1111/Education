using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _012_Document.Document.Parts;

namespace _013_Document.Document
{
    class Program
    {   //Сравни с файлом 012_Document. В этом документе реализована Инкапсуляция Вариаций, что очень важно.
        //Пример с ботинками и девушкой => делегирование, вся слава девушке!
        //Наш документ (этот класс) по сути сам ничего не может делать, но он предоставляет нам помимо
        //чистой инкапсуляции - абстракцию как собирательное понятие.
        // !!!!!!!!!!  Document за собой скрывает объекты Title, Body,Footer .
        //(Document - это собирательно понятие для Title, Body,Footer.)
        static void Main(string[] args)
        {
            //По-старому
            Document document1 = new Document("Контракт");
            document1.Body = "Тело контракта ...";
            document1.Footer = "Директор: Иванов И.И.";
            document1.Show();

            //По-новому
            Document document2 = new Document("Контракт")
            {
                Body = "Тело контракта ...",
                Footer = "Директор: Иванов И.И."
            };
            document2.Show();
            //Delay
            Console.ReadKey();
        }
    }
}

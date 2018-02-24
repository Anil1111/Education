using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _012_Document.Document;
using _012_Document.Document.Parts;

namespace _012_Document
{
    class Program
    {   //Очень неудобная программа!!
        static void Main(string[] args)
        {
            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта ...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document.Document document = new Document.Document(title,body,footer);
            document.Show();

            //Delay
            Console.ReadKey();
        }
    }
}

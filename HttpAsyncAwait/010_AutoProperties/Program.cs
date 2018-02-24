using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _010_AutoProperties
{   //Автоматически реализуемые свойства (Auto-Implemented properties).
    //Автоматически реализуемые свойства это более лаконичная форма свойств, и их есть смысл использовать,
    //когда в методах доступа (get и set) НЕ ТРЕБУЕТСЯ ДОПОЛНИТЕЛЬНАЯ ЛОГИКА!
    //При создании автоматиески реализуемых свойств, компилятор создаст ЗАКРЫТОЕ АНОНИМНОЕ РЕЗЕРВНОЕ ПОЛЕ,
    //которое будет доступно с помощью методов get и set свойства.
    class Program
    {
        public class Author
        {
            private string name;
            public string Name {
                get { return name; }
                set
                {
                    if (value!="fool")
                    name = value;
                }
            }
            public string Book { get; set; }
        }

        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",           //Блок инициализатора
                Book = "CLR via C#"
            };
            Author author2 = new Author     //()  Можно ставить, а можно и не ставить, если используем конструктор по умолчанию
            {
                Name = "Steve McConnel",           //Блок инициализатора
                Book = "Code Complete"
            };
            Author author3 = new Author     //()  Можно ставить, а можно и не ставить, если используем конструктор по умолчанию
            {
                Name = "fool",           //Блок инициализатора
                Book = "Code Complete"
            };

            Console.WriteLine($"Name: {author1.Name}, Book: {author1.Book}");
            Console.WriteLine($"Name: {author2.Name}, Book: {author2.Book}");
            Console.WriteLine(new string('-',30));
            Console.WriteLine($"Name: {author3.Name}, Book: {author3.Book}");

            //Delay
            Console.ReadKey();
        }
    }
}

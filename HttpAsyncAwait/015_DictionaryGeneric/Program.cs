using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict[3] = "Three";
            dict[4] = "Four";
            dict[1] = "One";
            dict[2] = "Two";
            dict[2] = "Two1"; //заменит слово

            string str = dict[3];
            //Dictionary состоит из массива элементов типа KeyValuePair
            foreach (KeyValuePair<int, string> i in dict)
            {
                Console.WriteLine($"{i.Key} = {i.Value}");
            }

            Console.WriteLine(new string('-', 25));

            foreach (var value in dict)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(new string('-', 25));


            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }

            //----------------------------------------------------------------------------------------
            //Смотри какая большая шляпа!
            Dictionary<int, Contact> phoneBook = new Dictionary<int, Contact>();
            phoneBook.Add(123456, new Contact { FirstName = "Luk", LastName = "Skywalker" });
            phoneBook.Add(567897, new Contact { FirstName = "Obivan", LastName = "Kenobi" });

            //А вот что можно сделать если просто немного схитрить:
            PhoneBook ph = new PhoneBook //блок инициализатора при компиляции разворачивается в метод Add
            {
                {123456, "Luk", "Skywalker" },
                {567897, "Obivan", "Kenobi" }
            };

            foreach (var phone in ph)
            {
                Console.WriteLine(phone);
            }

            //Delay
            Console.ReadKey();
        }
    }
}

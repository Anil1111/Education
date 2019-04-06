using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Hashtable
{
    class Program
    {
        //У Hashable есть ограничения:
        //1. Нельзя выбирать элементы по индексу - индексатор принимает ключ, а не индекс.
        //2. При использовании итератора(чтобы обойти ограничение выше), ЕЛЕМЕНТЫ БУДУТ УПОРЯДОЧЕНЫ ПО ХЭШ КОДАМ.

        //Эти проблеммы отсутствуют в OrderedDictionary. Он очень похож на Hashable, но там есть дополнительный функционал,
        //например перегруженный индексатор(для доступа по индексу), Insert по индексу, RemoveAt по индексу
        //Благодяря этому функционалу, набор можно обрабатывать как ГИБРИД ArrayList и Hashtable
        static void Main(string[] args)
        {
            //ПОРЯДОК ЭЛЕМЕНТОВ В КОТОРОМ ОНИ ДОБАВЛЯЛИСЬ НЕ БУДЕТ СОХРАНЯТЬСЯ т.е происходит сортировка по ХЭШАМ

            var emailLookup = new Hashtable();

            // Метод Add принимает в качестве первого пареметра ключ,
            // а в качестве второго - значение
            emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");

            // Невозможно добавить элемент с уже имеющимся в хэш-таблице кючом.
            //emailLookup.Add("sbishop@contoso.com", "Bishop, Scott2"); //System.ArgumentException

            // Особенности использовани индексаторов.

            // Использовани индексатора эквивалнтно вызову Add, если такого индекса не сущевствует.
            emailLookup["s.bishop@contoso.com"] = "Bishop, Scott"; //contoso - второе название компании Microsoft

            //Если такой индекс существует, то происходит только замена значения
            emailLookup["s.bishop@contoso.com"] = "------------";

            Console.WriteLine(emailLookup["sbishop@contoso.com"]);
            Console.WriteLine(emailLookup["s.bishop@contoso.com"]);

            //Delay
            Console.ReadKey();

            //Когда нужно использовать Hashtable?
            //Когда размер коллекции будет БОЛЬШЕ 10ти элементов.
            //Если в коллекции Hashtable меньше 10ти элементов - то это называется неоптимальным.
        }
    }
}

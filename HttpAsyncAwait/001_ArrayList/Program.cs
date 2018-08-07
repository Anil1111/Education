using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            //Добавление в набор одиночных элементов используя метод Add.
            //добавляет элементы в конец
            string s = "Hello";
            list.Add(s);
            list.Add("hi");
            list.Add(50);
            list.Add(new object());

            //Добавление в набор групп элементов используя метод AddRange.
            //добавило 3 новых элемента так же в конец
            var anArray = new[] { "more", "or", "less" };
            list.AddRange(anArray);

            var anotherArray = new[] { new object(), new ArrayList() };
            list.AddRange(anotherArray);

            //Вставка элементов в заданное положение используя метод Insert.(Сдвиг массива ВПРАВО)
            list.Insert(3, "Hey all");

            //Вставка элементоВ в заданное положение используя метод InsertRange.(Сдвиг массива ВПРАВО)
            var moreString = new[] { "goodnight", "see ya" };
            list.InsertRange(4, moreString);

            //Вставка элементов в заданное положение используя индексатор.
            // (!) При использовании индексатора элемент не вставляется в набор, а ЗАМЕНЯЕТ СУЩЕВСТВУЮЩИЙ
            list[3] = "Hey All 2";

            //Удаление из набора одиночных жлементв используя метод Remove(удаляет толко первое вхождение)
            list.Add("Hello"); //Мы уже вставили 2й раз
            list.Remove("Hello"); //удаляет ПЕРВОЕ вхождение(от [0] индекса идет)

            //Удаление из набора одиночных элементов с заданным индексом используя метод RemoveAt
            list.RemoveAt(0);

            //Удаление их набора, группы элементов с заданным диапазоном используя метод RemoveRange
            list.RemoveRange(0, 4); //начиная от индекса 0 удалить 4 элемента

            //Другие метожды для добавления и удаления элементов набора - Contains, IndexOf, Clear
            string myString = "My String";
            list.Add(myString);

            if (list.Contains(myString))
            {
                int index = list.IndexOf(myString);
                list.RemoveAt(index);
            }
            else
            {
                list.Clear();
            }

            //Delay
            Console.ReadKey();
        }
    }
}

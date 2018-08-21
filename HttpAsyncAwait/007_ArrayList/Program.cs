using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            //Добавления в набор одиночных элементов используя метод Add.
            string s = "Hello";
            list.Add(s);
            list.Add("hi");
            list.Add(50);
            list.Add(new object());

            //Добавление в абор групп элементов используя метод AddRange.
            var anArray = new[] { "more", "or", "less" };
            list.AddRange(anArray);

            var anotherArray = new[] { new object(), new ArrayList() };
            list.AddRange(anotherArray);

            //Вставка элементов в заданное положеие используя метод Insert.
            list.Insert(3, "Hey All");

            //Вставка элементов в заданное положение используя метод InsertRange.
            var moreStrings = new[] { "goodnight", "see ya" };
            list.InsertRange(4, moreStrings);

            //Вставка элементов а заданное положение использу идексатор.
            //(!!!) При использовании индекстаора элемент не вставляется в набр, а перезаписывается ПРЕЖНИЙ ОБЪЕКТ бы
            list[3] = "Hey All2";

            //Удаление и набора одиночных элементов используя метод Remove - ПЕРВОЕ ВХОЖДЕНИЕ
            list.Add("Hello");
            list.Remove("Hello");

            //Удаление из набора одиночных элементов с заданным индексам используя метод RemoveAt
            list.RemoveAt(0);

            // Удаление из набора ГРУППЫ ЭЛМЕНТОВ с заданным даипазоном используя метод RemoveRange
            list.RemoveRange(0, 4);

            //Другие методы для добавления и удаления элементо набора - Contains, IndexOf, Clear.
            string myStrng = "My String";

            if (list.Contains(myStrng))
            {
                int index = list.IndexOf(myStrng);
                list.RemoveAt(index);
            }
            else
            {
                list.Clear();
            }
        }
    }
}

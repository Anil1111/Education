using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    //Класс UserCollection коллекция (набор) обьектов класса Element.
    //Для применения foraech, необходимо, чтобы класс реализовывал интерфейс - IEnumerable.
    public class UserCollection : IEnumerable, IEnumerator //интерфейс - это контракт
    {
        private Element[] elementsArray = null; //скрываем массив

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }
        //указатель текущей позиции элемента в массиве.
        private int position = -1;

        //--------------------------------------------------------------------
        //Реализация интерфейса IEnumerator(синоним слова ИТЕРАТОР - перечислитель).
        public bool MoveNext() //иди дальше - проверяет position и если его длина меньше, чем длина массива - делает position++
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                //Reset(); убрать коммент и все будет ок
                return false;
            }
        }

        public void Reset() //position = -1;
        {
            position = -1;
        }

        public object Current => elementsArray[position]; //будет обращаться к массиву elementsArray и в качестве индекса указывать поле position;

        //Реализация интерфейса IEnumerable - метод в этом интерфейсе должен возвращать перечислитель(возвращает  кассира)
        IEnumerator IEnumerable.GetEnumerator() //На экземпляре не видим private методов интерфейсов!
        {
            return this as IEnumerator;
        }
    }
}

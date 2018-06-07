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
        public Element[] elementsArray = null;

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
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current { get; }
    }
}

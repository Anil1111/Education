using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterIEnumerable
{
    //ИТЕРАТОР - обьект, который занимается БЕЗОПАСНЫМ перебором элементов коллекций.
    //почему безопасным? потому, что мы там можем наустанавливать своих защит. 
    class UserCollection : IEnumerable //мы не наследуемся от IEnumerator потому, что yield нам уже и так его возвращает
    {
        //в С# 2.0 и выше показывается слово yield - а не должно! в С# 1.0  - все ок т.к yield появился в 2.0
        // Fields
        public Element[] elementsArray = null;
        private int position = -1;

        // Methods
        public UserCollection()
        {
            this.elementsArray = new Element[]
            {
                new Element("A", 1, 10),
                new Element("B", 2, 20),
                new Element("C", 3, 30),
                new Element("D", 4, 40)
            };
        }
        public IEnumerator GetEnumerator()
        {
            ClassGetEnumerator instance = new ClassGetEnumerator(0);
            instance.This = this;
            return instance;
        }
        public void Reset()
        {
            this.position = -1;
        }

        // Nested Types
        private sealed class ClassGetEnumerator : IEnumerator<object>, IDisposable, IEnumerator
        {
            private int state;
            private object current;
            public UserCollection This;

            public ClassGetEnumerator(int state)
            {
                this.state = state;
            }

            //private bool MoveNext()
            public bool MoveNext()
            {
                switch (this.state)
                {
                    case 0:
                        this.state = -1;
                        break;

                    case 1:
                        this.state = -1;
                        break;

                    default:
                        return false;
                }
                if (this.This.position < (this.This.elementsArray.Length - 1))
                {
                    this.This.position++;
                    this.current = this.This.elementsArray[this.This.position];
                    this.state = 1;
                    return true;
                }
                this.This.Reset();
                return false;
            }

            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
            }

            // Properties
            object IEnumerator<object>.Current
            {
                get
                {
                    return this.current;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.current;
                }
            }
        }



        //public Element[] elementsArray = null;

        //public UserCollection()
        //{
        //    elementsArray = new Element[4];
        //    elementsArray[0] = new Element("A", 1, 10);
        //    elementsArray[1] = new Element("B", 2, 20);
        //    elementsArray[2] = new Element("C", 3, 30);
        //    elementsArray[3] = new Element("D", 4, 40);
        //}
        ////указатель текущей позиции элемента в массиве.
        //private int position = -1;

        ////Установить указатель (position) перед началом набора.
        //public void Reset()
        //{
        //    position = -1;
        //}

        ////--------------------------------------------------------------
        ////Реализация интерфейса - IEnumerable.

        //public IEnumerator GetEnumerator()
        //{
        //    while (true)
        //    {
        //        if (position < elementsArray.Length - 1)
        //        {
        //            position++;
        //            yield return elementsArray[position]; //тут метод MoveNext присвоит полю значение и вернет true
        //        }
        //        else
        //        {
        //            Reset();
        //            yield break; //тут метод MoveNext вернет false
        //        }
        //    }
        //}
    }
}

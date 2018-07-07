using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _004_Collection_yield_realisation
{
    //CLR понимает только одно - байт код, это ВИРТУАЛЬНАЯ МАШИНА.

    //Коллекция, которая может получится после автоматической генерации 
    //програмного кода при использовании оператора yield.
    public class UserCollection<T> //не используем наследование от интерфейсов, а вместо этого будем использовать yield
    {
        private T[] elements;
        private int position = -1;

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public UserCollection()
        {
            this.elements = new T[4];
            this.position = -1;
        }

        public void Reset() => position = -1;

        public IEnumerator GetEnumerator()
        {
            Enumerator enumerator = new Enumerator(0); //конфигурируем экземпляр класса нулем.
            enumerator.@this = (UserCollection<T>)this;
            return enumerator;
        }
        //Nested Class - сгенерируемый by yield
        private sealed class Enumerator : IEnumerator<object>, IDisposable
        {
            private int state; //Состояние конечного автомата.
            private object current;
            public UserCollection<T> @this;

            public Enumerator(int state)
            {
                this.state = state;
            }

            public bool MoveNext()
            {
                //Диспетчер состояний конечного автомата
                switch (this.state) //В качестве выражения селектора передаем поле state.
                {
                    case 0:
                    case 1:
                        this.state = -1;
                        break;
                    default:
                        goto Label10;
                }

                if (this.@this.position < (this.@this.elements.Length - 1))
                {
                    this.@this.position++;
                    this.current = this.@this.elements[this.@this.position];
                    this.state = 1;
                    return true;
                }
                this.@this.Reset();

                Label10:
                return false;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            object IEnumerator<object>.Current => this.current;

            object IEnumerator.Current => this.current;
        }
    }
}

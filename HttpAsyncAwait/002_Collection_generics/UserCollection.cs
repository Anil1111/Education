using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Collection_generics
{
    //we are creating UserCollection of T
    public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        //заходим и смотрим на интерфейсы IEnumerable<T>, IEnumerator<T>. Каждый из них наследуется от обычных интерфейсов, а IEnumerator<T> ещё и от IDisposable
        // IEnumerable<T>, IEnumerator<T> - ШИРОКИЕ интерфейсы, а IEnumerable, IEnumerator - узкие.
        //и соответственно если мы наследуемся от IEnumerable<T>, IEnumerator<T> мы должны реализовать все методы
        //КАК ИЗ ЭТИХ ИНТЕРФЕЙСОВ, ТАК ИЗ ТЕХ, ОТ КОТОРЫХ ОНИ НАСЛЕДУЮТСЯ и т.д

        //IEnumerable<T> члены: IEnumerator<T> GetEnumerator(), IEnumerator GetEnumerator()
        //IEnumerator<T> члены: T Current { get; }, object Current { get; }, bool MoveNext(), void Reset(), void Dispose();

        readonly T[] elements = new T[4];

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        private int position = -1;

        //Реализация интерфейса IEnumerator<T>
        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            //метода Reset тут не будет т.к он будет помещен в метода Dispose
            return false;
        }

        //в имени члена явно указываем имя интерфейса, которому принадлежит этот метод.
        void IEnumerator.Reset() => this.position = -1;

        public T Current => this.elements[position]; 

        object IEnumerator.Current => Current; //этот метод не будет вызываться. будет вызываться метод public T Current

        //Реализация интерфейса IEnumerable<T>
        public IEnumerator<T> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //Реализация интерфейса IDisposable
        void IDisposable.Dispose() => ((IEnumerator)this).Reset();
        //Методы Dispose учавствует в финализации.
        //Когда foreach закончит перебирать коллекцию(MoveNext вернет false),
        //она скажет: "Ага, надо посмотреть, имеет ли эта коллекция одим из базовыи интерфейсов интерфейс IDisposable"
        //Как foreach будет это проверять? с помощью оператором is, as (он попробует привести коллекцию к IDisposable)
    }
}

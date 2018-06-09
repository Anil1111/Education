using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Yield_while_true
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            return new ClassPower();
        }

        private sealed class ClassPower : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
        {
            //Поля
            private object current;

            bool IEnumerator.MoveNext() //если yield "чувствует", что используется бесконечный цикл, то он присваивает полю 
            {//current значение "Hello world!" и возвращает true.
                this.current = "Hello world!";
                return true;
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                return this;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (this as IEnumerable<object>).GetEnumerator();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            object IEnumerator<object>.Current => this.current;

            object IEnumerator.Current => this.current;
        }
    }
}

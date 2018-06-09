using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Yield_break
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            return new ClassPower(-2);
        }

        class ClassPower : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
        {
            //поля
            private int state1;
            private object current2;
            private int initialThreadId_1;
            //конструтор
            public ClassPower(int state)
            {
                this.state1 = state;
                this.initialThreadId_1 = Thread.CurrentThread.ManagedThreadId;
            }

            bool IEnumerator.MoveNext()
            {
                if (this.state1 == 0)
                {
                    this.state1 = -1;
                }

                return false; //главная строка! оно просто возвращает false и все! никакой ошибки нету
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                if ((Thread.CurrentThread.ManagedThreadId == this.initialThreadId_1) && (this.state1 == -2))
                {
                    this.state1 = 0;
                    return this;
                }
                return new UserCollection.ClassPower(0);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (this as IEnumerable<object>).GetEnumerator();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            //Свойства
            object IEnumerator<object>.Current => this.current2;

            object IEnumerator.Current => this.current2;
        }
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            return new ClassPower(-2); //оператор автоматической генерации програмного кода ИТЕРАТОРОВ(переборщиков коллекции)
        }
        //IEnumerable<object> наследуется от IEnumerable, а IEnumerator<object> - от IEnumerator
        private sealed class ClassPower : IEnumerable<object>, IEnumerator<object>, IEnumerator, IDisposable
        {
            //Поля
            private int state;
            private object current;
            private int initialThreadId;
            //коструктор
            public ClassPower(int state)
            {
                this.state = state;
                this.initialThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            bool IEnumerator.MoveNext()
            {
                switch (state)
                {
                    case 0:
                        this.state = -1;
                        this.current = "Hello world";
                        this.state = 1;
                        return true;
                    case 1:
                        this.state = -1;
                        break;
                }

                return false;
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                if ((Thread.CurrentThread.ManagedThreadId == this.initialThreadId) && (this.state == -2))
                {
                    this.state = 0;
                    return this;
                }
                return new UserCollection.ClassPower(0);
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
            }
            //Свойства
            object IEnumerator<object>.Current => this.current;

            object IEnumerator.Current => this.current;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Collection
{
    public class UserCollection  //Не наследуемся ни от IEnumerable, ни от IEnumerator
    {
        readonly Element[] elements = new Element[4];

        public Element this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        private int position = -1;

        public bool MoveNext() //должно быть public, если мы не наследуемся от интерфейсов, иначе foreach будет ругаться.
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        // Reset - не нужен для foreach
        private void Reset() => position = -1;

        public object Current => elements[position];

        public UserCollection GetEnumerator() => this; //попробовать закомментировать. Будет ошибка
    }
}

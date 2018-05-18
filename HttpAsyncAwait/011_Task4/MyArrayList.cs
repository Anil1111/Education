using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Task4
{
    class MyArrayList
    {
        private object[] array;

        public MyArrayList()
        {
            array = new object[0];
        }

        public void Add(object a)
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;
            array = tempArray; //Когда мы заменяем новый массив на старый, то старый уходит в распоряжение Garbage Collector`а
        }

        public object this[int index] => array[index];
        public int Count => array.Length;

        public void Clear()
        {
            this.array = new object[0];
        }

        public bool Contains(object item) //метод придекат
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }

            return "Размерность массива:" + array.Length + " Элементы массива:" + stroka;
        }
    }
}
